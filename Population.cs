using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GeneticPractice
{
    internal class Population
    {
        public Brush dotBrush;
        public Color dotColor;
        public int dotBrainSize;
        public string name;
        public List<Dot> dots { get; private set; }

        private SelectionType selection;
        private CrossoverType crossover;

        private Vector2 startPos;
        private Vector2 finishPos;

        private Random random;

        private List<Dot> elite;

        private bool isUseElite;

        private int popSize;
        private int eliteCount;
        private int chanceMutation = 1;
        private int chanceCrosover = 90;
        private int countParticipent = 3;

        public Population(string name, int popSize, Vector2 startPos, Vector2 finishPos, Color dotColor, SelectionType selection, CrossoverType crossover, int eliteCount = 0)
        {
            this.selection = selection;
            this.crossover = crossover; 
            this.finishPos = finishPos;
            this.dotColor = dotColor;
            this.startPos = startPos;
            this.popSize = popSize;
            this.name = name;

            random = new Random();
            dotBrush = new SolidBrush(dotColor);

            dots = new List<Dot>();
            for (int i = 0; i < popSize; i++)
                dots.Add(new Dot(startPos));
            dotBrainSize = dots[0].brain.sizeBrain;

            if (eliteCount == 0)
                isUseElite = false;
            else
            {
                isUseElite = true;
                this.eliteCount = eliteCount;
            }
        }

        public void Move()
        {
            for (int i = 0; i < dots.Count; i++)
            {
                dots[i].Move();
                dots[i].minDistance = MathF.Min(dots[i].minDistance, MathF.Abs((dots[i].position - finishPos).Length()));
            }
        }

        public void Genetic()
        {            
            switch (selection)
            {
                case SelectionType.Tournament: SelectionTourney(); break;
                case SelectionType.BestDot:    SelectionBestDot(); break;
                default: throw new Exception("Unrealized selection!");
            }

            switch (crossover)
            {
                case CrossoverType.Uniform: CrossoverUniform(); break;
                case CrossoverType.DoublePoint: Crossover2Point(); break;
                case CrossoverType.RandPoint: CrossoverRandPoint(); break;
                case CrossoverType.None: break;
                default: throw new Exception("Unrealized crossover!");
            }

            Mutation();
        }

        public static float Fitnes(Dot dot)
        {
            float distanceBonus = 0;
            float stepBonus = 0;
            int finishBonus = 0;

            if (dot.isFinish)
            {
                finishBonus = 500;
                stepBonus = 1000f * 1f / dot.step;
            }
            else
                distanceBonus = 400f * 1f / dot.minDistance;

            return finishBonus + distanceBonus + stepBonus;
        }

        public void SelectionBestDot()
        {
            dots.Sort((x, y) => Fitnes(y).CompareTo(Fitnes(x)));
            
            int countNewDots = isUseElite ? dots.Count - eliteCount : dots.Count;
            List<Dot> newDots = new List<Dot>();

            if (isUseElite)
                elite = new List<Dot>();

            for (int i = 0; i < countNewDots; i++) 
                newDots.Add(dots[0].Copy());

            for (int i = 0; i < eliteCount; i++)
                elite.Add(dots[0].Copy());

            dots = newDots;
        }

        public void SelectionTourney() 
        {
            int countAddInNewPop = isUseElite ? dots.Count - eliteCount : dots.Count;
            List<Dot> newDots = new List<Dot>();


            for (int i = 0; i < countAddInNewPop; i++)
            {
                HashSet<int> participent = new HashSet<int>();
                while (participent.Count != countParticipent)
                    participent.Add(random.Next(0, dots.Count));

                List<Dot> individuals = new List<Dot>();
                foreach (int indx in participent)
                    individuals.Add(dots[indx]);

                individuals.Sort((x, y) => Fitnes(y).CompareTo(Fitnes(x)));
                newDots.Add(individuals[0].Copy());
            }

            if (isUseElite)
            {
                elite = new List<Dot>();
                dots.Sort((x, y) => Fitnes(y).CompareTo(Fitnes(x)));
                for (int i = 0; i < eliteCount; i++)
                    elite.Add(dots[i].Copy());
            }

            dots = newDots;
        }

        public void CrossoverUniform()
        {
            for (int i = 0; i < dots.Count; i += 2)
                if (random.Next(1, 101) <= chanceCrosover)
                    for (int j = 0; j < dotBrainSize; j++)
                        if (random.Next(0, 2) == 1)
                            (dots[i].brain.acceleration[j], dots[i + 1].brain.acceleration[j]) =
                            (dots[i + 1].brain.acceleration[j], dots[i].brain.acceleration[j]);
        }

        public void Crossover2Point()
        {
            int[] points = new int[2] { random.Next(0, dots[0].brain.sizeBrain + 1), 
                                        random.Next(0, dots[0].brain.sizeBrain + 1)};

            for (int i = 0; i < dots.Count; i += 2)
                foreach (int j in points)
                {
                    List<Vector2> temp1 = dots[i].brain.acceleration.GetRange(0, j + 1);
                    temp1.AddRange(dots[i + 1].brain.acceleration.GetRange(j + 1, dots[i + 1].brain.sizeBrain));
                    List<Vector2> temp2 = dots[i + 1].brain.acceleration.GetRange(0, j + 1);
                    temp2.AddRange(dots[i].brain.acceleration.GetRange(j + 1, dots[i + 1].brain.sizeBrain));

                    dots[i].brain.acceleration = new List<Vector2>(temp1);
                    dots[i + 1].brain.acceleration = new List<Vector2>(temp2);
                }            
        }

        public void CrossoverRandPoint()
        {
            int countSlicePoint = random.Next(0, dots[0].brain.sizeBrain / 2);
            int step = dots[0].brain.sizeBrain / countSlicePoint;

            for (int i = 0; i < dots.Count; i += 2)
                for(int j = 1; j < countSlicePoint; j++)
                {
                    List<Vector2> temp1 = dots[i].brain.acceleration.GetRange(0, j * step - 1);
                    temp1.AddRange(dots[i + 1].brain.acceleration.GetRange(j * step - 1, dots[i + 1].brain.sizeBrain));
                    List<Vector2> temp2 = dots[i + 1].brain.acceleration.GetRange(0, j * step - 1);
                    temp2.AddRange(dots[i].brain.acceleration.GetRange(j * step - 1, dots[i + 1].brain.sizeBrain));

                    dots[i].brain.acceleration = new List<Vector2>(temp1);
                    dots[i + 1].brain.acceleration = new List<Vector2>(temp2);
                }
        }

        public void Mutation()
        {
            foreach (Dot dot in dots)
                for (int i = 0; i < dotBrainSize; i++)
                    if (random.Next(1, 101) <= chanceMutation)
                    {
                        float rad = (float)random.NextDouble() * 2 * MathF.PI;
                        dot.brain.acceleration[i] = new Vector2(MathF.Cos(rad), MathF.Sin(rad));
                    }
            if (isUseElite)
                dots.AddRange(elite);
        }

        public bool AllDotsDead()
        {
            foreach (Dot dot in dots)
                if (dot.isLive)
                    return false;
            return true;
        }
    }
}
