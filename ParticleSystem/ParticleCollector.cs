using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticleSystem
{
    //Собиратель частиц
    class ParticleCollector : ImpactPoint
    {
        //Число частиц каждого размера
        private int smallAmount;
        private int mediumAmount;
        private int largeAmount;

        public ParticleCollector()
        {
            x = 0;
            y = 0;
            width = 0;
            height = 0;
            isActive = true;
        }

        public ParticleCollector(float x, float y, int width, bool isActive)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            height = 0;
            this.isActive = isActive;
        }

        public void Clear()
        {
            smallAmount = 0;
            mediumAmount = 0;
            largeAmount = 0;
        }

        public override void Impact(Particle particle)
        {
            if (Math.Sqrt(Math.Pow(particle.GetX() - x, 2) + Math.Pow(particle.GetY() - y, 2)) < width / 2)
            {
                particle.SetHealth(0);
                if (particle.GetRadius() >= 1 && particle.GetRadius() <= 5)
                    ++smallAmount;
                else if (particle.GetRadius() >= 6 && particle.GetRadius() <= 10)
                    ++mediumAmount;
                else
                    ++largeAmount;
            }

            if (smallAmount < 0)
                smallAmount = 0;
            else if (mediumAmount < 0)
                mediumAmount = 0;
            else if (largeAmount < 0)
                largeAmount = 0;
        }

        public override void Draw(System.Drawing.Graphics drawer)
        {
            int totalAmount = smallAmount + mediumAmount + largeAmount;
            drawer.FillEllipse(new System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(255, (totalAmount > 255) ? 255 : totalAmount, 0, 0)), x - width / 2, y - width / 2, width, width);

            drawer.DrawEllipse(new System.Drawing.Pen(System.Drawing.Color.White, 2), x - width / 2, y - width / 2, width, width);

            System.Drawing.StringFormat format = new System.Drawing.StringFormat();
            format.Alignment = System.Drawing.StringAlignment.Center;
            format.LineAlignment = System.Drawing.StringAlignment.Center;
            drawer.DrawString($"Маленькие: {smallAmount}\nСредние: {mediumAmount}\nБольшие: {largeAmount}\nВсего: {totalAmount}", new System.Drawing.Font("Times New Roman", 12), new System.Drawing.SolidBrush(System.Drawing.Color.White), x, y, format);
        }
    }
}
