using System.Drawing.Drawing2D;
using System.Numerics;

namespace GeneticPractice
{
    public partial class Form1 : Form
    {
        private int popSize = 400;
        private int finishSide = 20;
        private int epoch = 0;

        private Vector2 startPosition;
        private Vector2 finishPosition;

        private Population population;

        private Bitmap buffer;

        private System.Windows.Forms.Timer moveTimer;

        private Brush DotBrush;

        private Color BGColor;
        private Color DotColor;
        private Color FinishColor = Color.FromArgb(0, 255, 0);

        public Form1()
        {
            InitializeComponent();

            ChangeTheme('d');

            DoubleBuffered = true;

            buffer = new Bitmap(PicBox.Size.Width, PicBox.Size.Height);

            startPosition = new Vector2(PicBox.Size.Width / 2, PicBox.Size.Height - 20);
            finishPosition = new Vector2(PicBox.Size.Width / 2, 20);
            population = new Population(popSize, startPosition, finishPosition);


            moveTimer = new System.Windows.Forms.Timer();
            moveTimer.Interval = 10;
            moveTimer.Tick += (s, e) =>
            {
                LogicInTick();
            };

            StartMoveDot();
        }

        private void ChangeTheme(char theme)
        {
            switch (theme)
            {
                case 'd':
                    BGColor = Color.DimGray;
                    DotColor = Color.White;
                    break;
                case 'w':
                    BGColor = Color.WhiteSmoke;
                    DotColor = Color.Black;
                    break;
                default: break;
            }

            BackColor = BGColor;
            DotBrush = new SolidBrush(DotColor);
        }

        private void StartMoveDot()
        {
            moveTimer.Start();
            EpochLabelUpdate();
            MinStepLabelUpdate();
        }

        private void LogicInTick()
        {
            if (!population.AllDotsDead())
            {
                CheckDotStatus(population);
                population.Move();

                ClearBuffer();
                DrawFinish();
                DrawDots(population);

                PicBox.Image = buffer;
                PicBox.Refresh();
            }
            else
            {
                EpochLabelUpdate();
                MinStepLabelUpdate();

                population.SelectionBestDot();
                population.Mutation();
            }
        }

        private void EpochLabelUpdate()
        {
            epoch++;
            lbEpochCount.Text = $"Epoch: {epoch}";
        }

        private void MinStepLabelUpdate()
        {
            int min = population.dotBrainSize + 1;

            foreach (Dot dot in population.dots)
                if (dot.isFinish && dot.step < min)
                    min = dot.step;

            if (min == population.dotBrainSize + 1)
                lbMinStep.Text = $"Min step: no one finished";
            else
                lbMinStep.Text = $"Min step: {min}";
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

        private void DrawDots(Population pop)
        {
            int side = 6;
            using Graphics g = Graphics.FromImage(buffer);

            for (int i = 0; i < pop.dots.Count; i++)
            {
                Vector2 pos = pop.dots[i].position;
                g.FillEllipse(DotBrush, pos[0] - side / 2, pos[1] - side / 2, side, side);
            }
        }
    }
}
