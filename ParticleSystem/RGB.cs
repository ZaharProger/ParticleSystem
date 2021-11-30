using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticleSystem
{
    public class RGB
    {
        private byte alpha;
        private byte red;
        private byte green;
        private byte blue;

        public RGB()
        {
            alpha = 0;
            red = 0;
            green = 0;
            blue = 0;
        }

        public RGB(byte alpha, byte red, byte green, byte blue)
        {
            this.alpha = alpha;
            this.red = red;
            this.green = green;
            this.blue = blue;
        }

        public void SetAlpha(byte alpha)
        {
            this.alpha = alpha;
        }

        public void SetRed(byte value)
        {
            red = value;
        }

        public void SetGreen(byte value)
        {
            green = value;
        }

        public void SetBlue(byte value)
        {
            blue = value;
        }

        public byte GetAlpha()
        {
            return alpha;
        }

        public byte GetRed()
        {
            return red;
        }

        public byte GetGreen()
        {
            return green;
        }

        public byte GetBlue()
        {
            return blue;
        }

        public void AddAlpha(byte value)
        {
            alpha += value;
        }

        public void AddRed(byte value)
        {
            red += value;
        }

        public void AddGreen(byte value)
        {
            green += value;
        }

        public void AddBlue(byte value)
        {
            blue += value;
        }
    }
}
