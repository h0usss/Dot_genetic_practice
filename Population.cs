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
        public List<Dot> dots { get; private set; }
        public int dotBrainSize;

        private Vector2 finishPos;
        private Vector2 startPos;
        private List<Dot> elite;
        private Random random;
        private bool isUseElite = true;
        private int eliteCount = 2;
        private int chanceMutation = 1;
        private int chanceCrosover = 90;
        private int popSize;

        public Population(int popSize, Vector2 startPos, Vector2 finishPos)
        {
            random = new Random();
            this.finishPos = finishPos;
            this.startPos = startPos;
            this.popSize = popSize;

            dots = new List<Dot>();
            for (int i = 0; i < popSize; i++)
                dots.Add(new Dot(startPos));
            dotBrainSize = dots[0].brain.sizeBrain;
        }

        public void Move()
        {
            for (int i = 0; i < dots.Count; i++)
            {
                dots[i].Move();
                dots[i].minDistance = MathF.Min(dots[i].minDistance, MathF.Abs((dots[i].position - finishPos).Length()));
            }
        }

        public float Fitnes(Dot dot)
        {
            int finishBonus = 2000 * (dot.isFinish ? 1 : 0);
            float distanceBonus = 0;
            int stepBonus = 0;

            if (dot.minDistance > 0)
            {
                if (!dot.isFinish)
                    distanceBonus = 500 * (1 / dot.minDistance);
            }
            else
                distanceBonus = 500;

            if (dot.isFinish)
                stepBonus = 10000 * 1 / dot.step;

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

        public void SelectionTourney(int countParticipent)
        {
            int countAddInNewPop = dots.Count;
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

            dots = newDots;
        }

        public void CrisoverUniform()
        {
            for (int i = 0; i < dots.Count; i += 2)
                if (random.Next(1, 101) <= chanceCrosover)
                    for (int j = 0; j < dotBrainSize; j++)
                        if (random.Next(0, 2) == 1)
                            (dots[i].brain.acceleration[j], dots[i + 1].brain.acceleration[j]) =
                            (dots[i + 1].brain.acceleration[j], dots[i].brain.acceleration[j]);
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
