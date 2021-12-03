using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticleSystem
{
    //Точка притяжения
    class GravityPoint : ImpactPoint
    {
        protected short power;
        protected bool isReversed;

        public GravityPoint()
        {
            power = 100;
            x = 0;
            y = 0;
            height = 0;
            width = 0;
            isReversed = false;
        }

        public GravityPoint(float x, float y, int width, int height, short power, bool isReversed)
        {
            this.x = x;
            this.y = y;
            this.height = height;
            this.width = width;
            this.power = power;
            this.isReversed = isReversed;
        }

        public void SetPower(short power)
        {
            this.power = power;
        }

        public void AddPower(short power)
        {
            this.power += power;
        }

        public void SetReverse(bool isReversed)
        {
            this.isReversed = isReversed;
        }

        public override void Impact(Particle particle)
        {
            float gX = x - particle.GetX();
            float gY = y - particle.GetY();

            float r = (float)Math.Max(100, gX * gX + gY * gY);
            particle.AddSpeedX(isReversed ? -(gX * power / r) : gX * power / r);
            particle.AddSpeedY(isReversed ? -(gY * power / r) : gY * power / r);
        }
    }
}
