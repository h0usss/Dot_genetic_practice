using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GeneticPractice
{
    internal class Brain
    {
        internal int sizeBrain = 400;

        internal List<Vector2> acceleration;
        
        private Random random;

        public Brain()
        {
            acceleration = new List<Vector2>();
            random = new Random();

            FillRandAcc();
        }

        public Brain( List<Vector2> acceleration)
        {
            this.acceleration = new List<Vector2>(acceleration);
        }

        private void FillRandAcc()
        {
            float rad;

            for (int i = 0; i < sizeBrain; i++)
            {
                rad = (float)random.NextDouble() * 2 * MathF.PI;
                acceleration.Add(new Vector2(MathF.Cos(rad), MathF.Sin(rad)));
            }
        }

        public Brain Copy()
        {
            return new Brain(acceleration);
        }
    }
}
