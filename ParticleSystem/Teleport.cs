using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticleSystem
{
    //телепорт
    class Teleport : ImpactPoint
    {
        private float outputX;
        private float outputY;
        private static Random positionSwitcher = new Random();

        public Teleport()
        {
            x = 0;
            y = 0;
            width = 0;
            height = 0;
            outputX = 0;
            outputY = 0;
            isActive = true;
        }

        public Teleport(float x, float y, float width, float height, float outputX, float outputY, bool isActive)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.outputX = outputX;
            this.outputY = outputY;
            this.isActive = isActive;
        }

        public void SetOutputX(float outputX)
        {
            this.outputX = outputX;
        }

        public void SetOutputY(float outputY)
        {
            this.outputY = outputY;
        }

        public override void Impact(Particle particle)
        {
            if (Math.Sqrt(Math.Pow(particle.GetX() - x, 2) + Math.Pow(particle.GetY() - y, 2)) < width / 2 ||
                Math.Sqrt(Math.Pow(particle.GetX() - x, 2) + Math.Pow(particle.GetY() - y, 2)) < height / 2)
            {
                particle.SetX(outputX + positionSwitcher.Next((int)-width / 4, (int)width / 4));
                particle.SetY(outputY + positionSwitcher.Next((int)-height / 4, (int)height / 4));
            }
        }

        public override void Draw(System.Drawing.Graphics drawer)
        {
            base.Draw(drawer);
            drawer.DrawEllipse(new System.Drawing.Pen(System.Drawing.Color.White, 2), outputX - width / 2, outputY - height / 2, width, height);
            System.Drawing.StringFormat format = new System.Drawing.StringFormat();
            format.Alignment = System.Drawing.StringAlignment.Center;
            format.LineAlignment = System.Drawing.StringAlignment.Center;
            drawer.DrawString("Вход", new System.Drawing.Font("Times New Roman", 12), new System.Drawing.SolidBrush(System.Drawing.Color.White), x, y, format);
            drawer.DrawString("Выход", new System.Drawing.Font("Times New Roman", 12), new System.Drawing.SolidBrush(System.Drawing.Color.White), outputX, outputY, format);
        }
    }
}
