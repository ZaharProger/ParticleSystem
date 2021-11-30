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
        private byte health;
        private float speedX;
        private float speedY;
        private string startColor;
        private string endColor;
        private static Random dataGenerator = new Random();
        public Particle(float x, float y, string startColor, string endColor)
        {
            radius = (short)dataGenerator.Next(1, 16);
            health = (byte)dataGenerator.Next(10, 101);
            speedX = (float)(Math.Cos(dataGenerator.Next(360) / 180 * Math.PI) * dataGenerator.Next(1, 11));
            speedY = -(float)(Math.Sin(dataGenerator.Next(360) / 180 * Math.PI) * dataGenerator.Next(1, 11));
            this.x = x;
            this.y = y;
            this.startColor = startColor;
            this.endColor = endColor;
        }

        //Отрисовка
        public void Draw(System.Drawing.Graphics drawer)
        {
            float transparency = Math.Min(1, health / 100);
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

            System.Drawing.Color brushColor = System.Drawing.Color.FromArgb((byte)(convertedEndColor.GetAlpha() * transparency + convertedStartColor.GetAlpha() * (1 - transparency)),
                                                                            (byte)(convertedEndColor.GetRed() * transparency + convertedStartColor.GetRed() * (1 - transparency)),
                                                                            (byte)(convertedEndColor.GetGreen() * transparency + convertedStartColor.GetGreen() * (1 - transparency)),
                                                                            (byte)(convertedEndColor.GetBlue() * transparency + convertedStartColor.GetBlue() * (1 - transparency)));
            drawer.FillEllipse(new System.Drawing.SolidBrush(brushColor), x - radius, y - radius, radius * 2, radius * 2);
        }
    }
}
