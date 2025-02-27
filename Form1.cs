using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Numerics;
using System.Security.Cryptography.Xml;
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
        private int BarrierWidth = 6;
        private int DotSide = 6;

        private bool isLBM = false;
        private bool isRBM = false;
        private bool isFirst = true;

        private Vector2 startPosition;
        private Vector2 finishPosition;

        private List<Population> populations;

        private Bitmap buffer;
        private Bitmap bufferBarrier;

        private System.Windows.Forms.Timer moveTimer;

        private Brush DotBrush;

        private Point lastPoint;

        private Color BGColor;
        private Color BarrierColorMain = Color.FromArgb(0, 0, 0);
        private Color FinishColor = Color.FromArgb(0, 255, 0);
        private Color StartColor = Color.FromArgb(200, 200, 200);

        private Pen PenBarrier;
        private Pen EraseBarrier;

        // TODO: drawing barrier

        public Form1()
        {
            InitializeComponent();
            this.MouseWheel += Form_MouseWheel;


            countPop = 0;
            DoubleBuffered = true;

            BGColor = this.BackColor;

            buffer = new Bitmap(PicBox.Size.Width, PicBox.Size.Height);
            bufferBarrier = new Bitmap(PicBox.Size.Width, PicBox.Size.Height);

            startPosition = new Vector2(PicBox.Size.Width / 2, PicBox.Size.Height - 20);
            finishPosition = new Vector2(PicBox.Size.Width / 2, 20);

            UpdatePen();

            CreatePopulations();
            DrawStartScreen();

            moveTimer = new System.Windows.Forms.Timer();
            moveTimer.Interval = tbSpeed.Value;
            moveTimer.Tick += (s, e) =>
            {
                LogicInTick();
            };
        }

        private void Form_MouseWheel(object sender, MouseEventArgs e)
        {
            if (rbBarrier.Checked)
            {
                if (e.Delta > 0)
                    BarrierWidth++;
                if (e.Delta < 0)
                    BarrierWidth--;
                UpdatePen();    
            }
        }

        private void UpdatePen()
        {
            PenBarrier = new Pen(BarrierColorMain, BarrierWidth)
            {
                StartCap = LineCap.Round,
                EndCap = LineCap.Round
            };

            EraseBarrier = new Pen(BGColor, BarrierWidth)
            {
                StartCap = LineCap.Round,
                EndCap = LineCap.Round
            };
        }

        private void btnNewPop_Click(object sender, EventArgs e)
        {
            PopulationInfo popin = new PopulationInfo();

            panPopulations.AutoScrollMinSize = new Size(0, btnNewPop.Location.Y + popin.Height + 4);

            popin.Location = new Point(0, btnNewPop.Location.Y);
            popin.Size = new Size(btnNewPop.Width, popin.Height);  
            popin.tbNamePop.Text = $"Population{GetNextIntPop()}";   

            btnNewPop.Location = new Point(0, btnNewPop.Location.Y + popin.Height + 4);
            countPop++;

            panPopulations.Controls.Add(popin);
        }

        public void btnDeleteThisPop(PopulationInfo child)
        {
            panPopulations.Controls.Remove(child);
            countPop--;

            int locY = 0;
            foreach (Control c in panPopulations.Controls)
                if (c is PopulationInfo popin)
                {
                    popin.Location = new Point(0, locY + panPopulations.AutoScrollPosition.Y);
                    locY += popin.Height + 4;
                }

            btnNewPop.Location = new Point(0, locY + panPopulations.AutoScrollPosition.Y);
            panPopulations.AutoScrollMinSize = new Size(0, btnNewPop.Location.Y + child.Height + 4);
        }

        private int GetNextIntPop()
        {
            int max = -9999;
            bool isFirstBlock = true;
            foreach (Control c in panPopulations.Controls)
                //if (c is PopulationInfo popin &&                     IDN what is the best way  
                //    popin.tbNamePop.Text[0..10] == "Population" &&
                //    int.TryParse(popin.tbNamePop.Text[10..].Trim(), out int num))

                if (c is PopulationInfo popin)
                    if (popin.tbNamePop.Text[0..10] == "Population")
                        if (int.TryParse(popin.tbNamePop.Text[10..].Trim(), out int num))
                        {
                            max = Math.Max(max, num);
                            isFirstBlock = false;
                        }

            if (isFirstBlock)
                return 1;
            return max + 1;
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
                DrawStartScreen();
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

                if (IsDotIntersectBarrier(dot))
                    dot.isLive = false;

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

        private bool IsDotIntersectBarrier(Dot dot)
        {
            float x1 = dot.position[0];
            float y1 = dot.position[1];
            float x2 = dot.prevPosition[0];
            float y2 = dot.prevPosition[1];

            int f(float x)
            {
                if (x2 == x1)
                    return (int)MathF.Round(y1);
                return (int)MathF.Round((x - x1) * (y2 - y1) / (x2 - x1) + y1);
            }

            bool barrierInCirc(int x, int r)
            {
                int y = f(x);

                for (int i = x - r; i <= x + r; i++)
                    for (int j = y - r; j <= y + r; j++)
                    {
                        if (i < 0 || i >= bufferBarrier.Width || j < 0 || j >= bufferBarrier.Height)
                            return false;

                        if ((i - x) * (i - x) + (j - y) * (j - y) <= r * r)
                            if (bufferBarrier.GetPixel(i, j) == Color.FromArgb(255, 0, 0, 0))
                                return true;
                    }

                return false;
            }
            int startX = (int) MathF.Min(x1, x2);
            int endX =   (int) MathF.Max(x1, x2);

            for (int i = startX; i <= endX; i++)
                if (barrierInCirc(i, DotSide / 2))
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

        private void DrawDots()
        {
            foreach (Population population in populations)
            {
                CheckDotStatus(population);
                population.Move();

                using Graphics g = Graphics.FromImage(buffer);

                for (int i = 0; i < population.dots.Count; i++)
                {
                    Vector2 pos = population.dots[i].position;
                    g.FillEllipse(population.dotBrush, pos[0] - DotSide / 2, pos[1] - DotSide / 2, DotSide, DotSide);
                }
            }
        }

        private void DrawStartScreen()
        {
            ClearBuffer();
            DraBarriers();
            DrawStart();
            DrawFinish();
            DrawDots();
            PicBox.Image = buffer;
            PicBox.Refresh();
        }

        private void DraBarriers()
        {
            using Graphics g = Graphics.FromImage(buffer);
            g.DrawImage(bufferBarrier, new Point(0, 0));
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

            DeletePopulation();
            DrawStartScreen();
        }

        private void DeletePopulation()
        {
            populations = new List<Population>();
        }
        private void PicBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isLBM = true;
                lastPoint = e.Location;
            }
            if (e.Button == MouseButtons.Right)
            {
                isRBM = true;
                lastPoint = e.Location;
            }
        }

        private void PicBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                isLBM = false;
            if (e.Button == MouseButtons.Right)
                isRBM = false;
        }

        private void PicBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (rbBarrier.Checked)
            {
                if (isLBM)
                    DrawBarrier(PenBarrier, e);
                if (isRBM)
                    DrawBarrier(EraseBarrier, e);
                DrawStartScreen();
            }
            else if (isLBM)
            {
                ref Vector2 activeEl = ref startPosition;

                if (rbStart.Checked)
                    activeEl = ref startPosition;
                if (rbFinish.Checked)
                    activeEl = ref finishPosition;

                activeEl = new Vector2(e.X, e.Y);

                activeEl.X = MathF.Max(MathF.Min(e.X, PicBox.Width), 0);
                activeEl.Y = MathF.Max(MathF.Min(e.Y, PicBox.Height), 0);

                DrawStartScreen();
            }
        }

        private void DrawBarrier(Pen pen, MouseEventArgs e)
        {
            Graphics g = Graphics.FromImage(bufferBarrier);
            g.DrawLine(pen, lastPoint, e.Location);
            lastPoint = e.Location;
        }
    }
}
