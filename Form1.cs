using System.Drawing;
using System.Drawing.Drawing2D;
using System.Numerics;
using System.Windows.Forms;

namespace GeneticPractice
{
    public partial class Form1 : Form
    {
        private int popSize = 200;
        private int finishSide = 20;
        private int startSide = 20;
        private int epoch = 1;
        private int countPop;
                
        private bool isDrawing = false;
        private bool isFirst = true;

        private Vector2 startPosition;
        private Vector2 finishPosition;

        private List<Population> populations;

        private Bitmap buffer;

        private System.Windows.Forms.Timer moveTimer;

        private Brush DotBrush;

        private Point lastPoint;

        private Color BGColor;
        private Color BarrierColor = Color.FromArgb(255, 0, 0);
        private Color FinishColor = Color.FromArgb(0, 255, 0);
        private Color StartColor = Color.FromArgb(200, 200, 200);

        // TODO: drawing barrier
        // TODO: New Selection, Crossover

        public Form1()
        {
            InitializeComponent();

            countPop = 0;
            DoubleBuffered = true;

            BGColor = PicBox.BackColor;

            buffer = new Bitmap(PicBox.Size.Width, PicBox.Size.Height);

            startPosition = new Vector2(PicBox.Size.Width / 2, PicBox.Size.Height - 20);
            finishPosition = new Vector2(PicBox.Size.Width / 2, 20);

            CreatePopulations();
            DrawScreen();

            moveTimer = new System.Windows.Forms.Timer();
            moveTimer.Interval = tbSpeed.Value;
            moveTimer.Tick += (s, e) =>
            {
                LogicInTick();
            };
        }

        private void btnNewPop_Click(object sender, EventArgs e)
        {
            PopulationInfo popin = new PopulationInfo();
            int locY = countPop == 0 ? 0 : countPop * popin.Height + 4;

            popin.Location = new Point(0, locY);
            popin.Size = new Size(panPopulations.Width - 17, popin.Height); // (-17) For vertical scrolling, so that the horizontal 
            popin.tbNamePop.Text = $"Population{countPop + 1}";            //        one does not appear
            
            btnNewPop.Location = new Point(0, btnNewPop.Location.Y + popin.Height + 4);
            countPop++;

            panPopulations.Controls.Add(popin);
        }

        private void CreatePopulations()
        {
            populations = new List<Population>();
            foreach (Control control in panPopulations.Controls)
                if (control is PopulationInfo popinfo)
                    populations.Add(new Population(
                        popinfo.tbNamePop.Text,
                        int.Parse(popinfo.tbSize.Text),
                        startPosition,
                        finishPosition,
                        popinfo.panColor.BackColor,
                        (SelectionType)popinfo.cbSelection.SelectedIndex,
                        (CrossoverType)popinfo.cbCrossover.SelectedIndex,
                        int.Parse(popinfo.tbElite.Text)));
        }

        private void LogicInTick()
        {
            if (!IsAllPopDotsDead(populations))
            {
                ClearBuffer();
                DrawFinish();

                foreach (Population population in populations)
                {
                    CheckDotStatus(population);
                    population.Move();

                    DrawDots(population);
                }

                PicBox.Image = buffer;
                PicBox.Refresh();
            }
            else
            {
                EpochLabelUpdate();
                InfoLabelUpdate();

                foreach (Population population in populations)
                    population.Genetic();
            }
        }

        private void EpochLabelUpdate()
        {
            epoch++;
            lbEpochCount.Text = $"Epoch: {epoch}";
        }

        private void InfoLabelUpdate()
        {
            int min = populations[0].dotBrainSize + 1;
            Color color = Color.FromArgb(0, 0, 0, 0);
            string name = "";

            foreach (Population population in populations)
                foreach (Dot dot in population.dots)
                    if (dot.isFinish && dot.step < min)
                    {
                        min = dot.step;
                        color = population.dotColor;
                        name = population.name;
                    }

            if (min == populations[0].dotBrainSize + 1)
                lbMinStep.Text = "Min step: no one finished";
            else
            {
                lbMinStep.Text = $"Min step: {min}";
                panColor.BackColor = color;
                lbName.Text = $"Name: {name}";
            }
        }

        private void CheckDotStatus(Population pop)
        {
            foreach (Dot dot in pop.dots)
            {
                if (!IsDotInField(dot))
                {
                    dot.isLive = false;
                    dot.position = new Vector2(MathF.Max(MathF.Min(dot.position[0], PicBox.Width - 3), 0),   // (-3) Helps to display the collision 
                                                MathF.Max(MathF.Min(dot.position[1], PicBox.Height - 3), 0)); // with the right and bottom edges clearly
                }

                if (IsDotInFinish(dot))
                {
                    dot.isLive = false;
                    dot.isFinish = true;
                }
            }
        }

        private bool IsDotInField(Dot dot)
        {
            Vector2 pos = dot.position;

            if (pos[0] < 0 || pos[0] > PicBox.Size.Width || pos[1] < 0 || pos[1] > PicBox.Size.Height)
                return false;
            return true;
        }

        private bool IsDotInFinish(Dot dot)
        {
            Vector2 pos = dot.position;

            if (pos[0] < (finishPosition[0] + finishSide / 2) &&
                pos[0] > (finishPosition[0] - finishSide / 2) &&
                pos[1] < (finishPosition[1] + finishSide / 2) &&
                pos[1] > (finishPosition[1] - finishSide / 2))
                return true;
            return false;
        }

        private bool IsAllPopDotsDead(List<Population> pop)
        {
            foreach (Population population in pop)
                if (!population.AllDotsDead())
                    return false;
            return true;
        }

        private void ClearBuffer()
        {
            using Graphics g = Graphics.FromImage(buffer);
            g.Clear(BGColor);
        }

        private void DrawFinish()
        {
            using Graphics g = Graphics.FromImage(buffer);

            g.FillEllipse(new SolidBrush(FinishColor), finishPosition[0] - finishSide / 2, finishPosition[1] - finishSide / 2, finishSide, finishSide);
        }
        private void DrawStart()
        {
            using Graphics g = Graphics.FromImage(buffer);

            g.FillEllipse(new SolidBrush(StartColor), startPosition[0] - startSide / 2, startPosition[1] - startSide / 2, startSide, startSide);
        }

        private void DrawDots(Population pop)
        {
            int side = 6;
            using Graphics g = Graphics.FromImage(buffer);

            for (int i = 0; i < pop.dots.Count; i++)
            {
                Vector2 pos = pop.dots[i].position;
                g.FillEllipse(pop.dotBrush, pos[0] - side / 2, pos[1] - side / 2, side, side);
            }
        }

        private void DrawScreen()
        {
            ClearBuffer();
            DrawStart();
            DrawFinish();
            PicBox.Image = buffer;
            PicBox.Refresh();
        }

        private void tbSpeed_Scroll(object sender, EventArgs e)
        {
            moveTimer.Interval = tbSpeed.Value;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (isFirst)
            {
                isFirst = false;
                CreatePopulations();
            }
            if (moveTimer.Enabled)
            {
                btnStart.Text = "Start";
                moveTimer.Stop();
            }
            else
            {
                btnStart.Text = "Stop";
                moveTimer.Start();
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            if (moveTimer.Enabled)
            {
                btnStart.Text = "Start";
                moveTimer.Stop();
            }
            epoch = 0;
            EpochLabelUpdate();

            isFirst = true;

            lbMinStep.Text = "Min step:";
            lbType.Text = "Color:";

            DrawScreen();
        }

        private void PicBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = true;
                lastPoint = e.Location;
            }
        }

        private void PicBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                isDrawing = false;
        }

        private void PicBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                if (!rbBarrier.Checked)
                {
                    ref Vector2 activeEl = ref startPosition;

                    if (rbStart.Checked)
                        activeEl = ref startPosition;
                    if (rbFinish.Checked)
                        activeEl = ref finishPosition;

                    activeEl = new Vector2(e.X, e.Y);

                    activeEl.X = MathF.Max(MathF.Min(e.X, PicBox.Width), 0);
                    activeEl.Y = MathF.Max(MathF.Min(e.Y, PicBox.Height), 0);

                    DrawScreen();
                }
                else
                {
                    Graphics g = Graphics.FromImage(buffer);
                    //g.DrawLine(new Pen(BarrierColor), lastPoint, e.Location);
                    //lastPoint = e.Location;
                    //PicBox.Refresh();
                }
            }
        }
    }
}
