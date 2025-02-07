using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GeneticPractice
{
    internal class Dot
    {
        public Vector2 position {  get; set; }
        private Vector2 direction;
        private Vector2 startPos;

        internal Brain brain;
        public int step = 0;

        public bool isLive = true;
        public bool isFinish = false;
        public float minDistance = float.PositiveInfinity;

        public Dot(Vector2 startPos)
        {
            this.startPos = startPos;

            position = startPos;
            direction = Vector2.Zero;
            brain = new Brain();
        }

        public Dot(Vector2 startPos, Brain brain)
        {
            position = startPos;
            direction = Vector2.Zero;

            this.startPos = startPos;
            this.brain = brain;
        }

        public void Move()
        {
            if (isLive)
                if (step < brain.sizeBrain)
                {
                    direction += brain.acceleration[step];
                    position += direction;
                    step++;
                }
                else
                    isLive = false;
        }

        public Dot Copy()
        {
            return new Dot(startPos, brain.Copy());
        }
    }
}
