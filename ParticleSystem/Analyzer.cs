using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticleSystem
{
    class Analyzer : ImpactPoint
    {
        private string info;
        private byte interactionType;

        public Analyzer()
        {
            x = 0;
            y = 0;
            width = 0;
            height = 0;
            isActive = true;
            interactionType = 0;
        }

        public Analyzer(float x, float y, float width, bool isActive)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = width;
            this.isActive = isActive;
            interactionType = 0;
        }

        public void SetInteraction(byte type)
        {
            interactionType = type;
        }

        public string GetInfo()
        {
            return info;
        }

        public override void Impact(Particle particle)
        {
            if (Math.Sqrt(Math.Pow(particle.GetX() - x, 2) + Math.Pow(particle.GetY() - y, 2)) <= particle.GetRadius())
            {
                info = particle.GetInfo();
                particle.SetAnalization(true);
                particle.Analyze(interactionType);
                interactionType = 0;
            }
            else
                particle.SetAnalization(false);
        }
    }
}
