using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticleSystem
{
    //Частица
    class Particle
    {
        private short radius;
        private float x;
        private float y;
        private float health;
        private float speedX;
        private float speedY;       
        private static Random dataGenerator = new Random();
        public Particle(float x, float y, short maxRadius, short maxHealth, short maxSpeed, short direction, short spreading)
        {
            radius = (short)dataGenerator.Next(1, maxRadius + 1);
            health = (float)dataGenerator.Next(1, maxHealth + 1);
            float calculatedDirection = direction + (float)dataGenerator.Next(spreading + 1) - spreading / 2;
            short calculatedSpeed = (short)dataGenerator.Next(1, maxSpeed + 1);
            speedX = (float)(Math.Cos(calculatedDirection / 180 * Math.PI) * calculatedSpeed);
            speedY = -(float)(Math.Sin(calculatedDirection / 180 * Math.PI) * calculatedSpeed);
            this.x = x;
            this.y = y;
        }

        public void ResetRadius(short maxRadius)
        {
            radius = (short)dataGenerator.Next(1, maxRadius + 1);
        }

        public short GetRadius()
        {
            return radius;
        }

        public void ResetHealth(short maxHealth)
        {
            health = (float)dataGenerator.Next(1, maxHealth + 1);
        }

        public void AddHealth(float health)
        {
            this.health += health;
        }

        public float GetHealth()
        {
            return health;
        }

        public void SetHealth(float health)
        {
            this.health = health;
        }

        public void ResetSpeedX(short maxSpeed, short direction, short spreading)
        {
            float calculatedDirection = direction + (float)dataGenerator.Next(spreading + 1) - spreading / 2;
            short calculatedSpeed = (short)dataGenerator.Next(1, maxSpeed + 1);
            speedX = (float)(Math.Cos(calculatedDirection / 180 * Math.PI) * calculatedSpeed);
        }

        public void ResetSpeedY(short maxSpeed, short direction, short spreading)
        {
            float calculatedDirection = direction + (float)dataGenerator.Next(spreading + 1) - spreading / 2;
            short calculatedSpeed = (short)dataGenerator.Next(1, maxSpeed + 1);
            speedY = -(float)(Math.Sin(calculatedDirection / 180 * Math.PI) * calculatedSpeed);
        }

        public void SetX(float x)
        {
            this.x = x;
        }

        public void SetY(float y)
        {
            this.y = y;
        }

        public float GetX()
        {
            return x;
        }

        public float GetY()
        {
            return y;
        }

        public void SetSpeedX(float speedX)
        {
            this.speedX = speedX;
        }

        public void SetSpeedY(float speedY)
        {
            this.speedY = speedY;
        }

        public float GetSpeedX()
        {
            return speedX;
        }

        public float GetSpeedY()
        {
            return speedY;
        }

        public void AddX(float x)
        {
            this.x += x;
        }

        public void AddY(float y)
        {
            this.y += y;
        }

        public void AddSpeedX(float speedX)
        {
            this.speedX += speedX;
        }

        public void AddSpeedY(float speedY)
        {
            this.speedY += speedY;
        }

        //Отрисовка
        public void Draw(System.Drawing.Graphics drawer, string startColor, string endColor)
        {
            float transparency = Math.Min(1f, health / 100);
            //Выделение каждого компонента RGB в 16ричной строке для преобразования
            string[] splittedStartColor = new string[] { startColor.Substring(0, 2),
                                                         startColor.Substring(2, 2),
                                                         startColor.Substring(4, 2),
                                                         startColor.Substring(6) };
            string[] splittedEndColor = new string[] { endColor.Substring(0, 2),
                                                         endColor.Substring(2, 2),
                                                         endColor.Substring(4, 2),
                                                         endColor.Substring(6) };
            RGB convertedStartColor = new HexToRGBConverter(splittedStartColor).Convert();
            RGB convertedEndColor = new HexToRGBConverter(splittedEndColor).Convert();
            
            System.Drawing.SolidBrush brush= new System.Drawing.SolidBrush(System.Drawing.Color.FromArgb((byte)(convertedStartColor.GetAlpha() * transparency + convertedEndColor.GetAlpha() * (1 - transparency)),
                                                                                                        (byte)(convertedStartColor.GetRed() * transparency + convertedEndColor.GetRed() * (1 - transparency)),
                                                                                                        (byte)(convertedStartColor.GetGreen() * transparency + convertedEndColor.GetGreen() * (1 - transparency)),
                                                                                                        (byte)(convertedStartColor.GetBlue() * transparency + convertedEndColor.GetBlue() * (1 - transparency))));
            drawer.FillEllipse(brush, x - radius, y - radius, radius * 2, radius * 2);
            brush.Dispose();
        }
    }
}
