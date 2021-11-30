using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticleSystem
{
    //Перевод из 16ричной в бинарную
    class HexToRGBConverter : Converter<string[], RGB>
    {
        private static byte numberSystemPower = 16;
        public HexToRGBConverter(string[] hex) : base(hex)
        { }

        public override RGB Convert()
        {
            RGB result = new RGB();

            byte i = 0;
            foreach (string num in value)
            {
                byte degree = (byte)num.Length;
                foreach (char digit in num)
                {
                    byte hexValue = 0;
                    switch (digit)
                    {
                        case 'a':
                            hexValue = 10;
                            break;
                        case 'b':
                            hexValue = 11;
                            break;
                        case 'c':
                            hexValue = 12;
                            break;
                        case 'd':
                            hexValue = 13;
                            break;
                        case 'e':
                            hexValue = 14;
                            break;
                        case 'f':
                            hexValue = 15;
                            break;
                        default:
                            hexValue = (byte)(digit - '0');
                            break;
                    }

                    if (i == 0)
                        result.AddAlpha((byte)(hexValue * Math.Pow(numberSystemPower, --degree)));
                    else if (i == 1)
                        result.AddRed((byte)(hexValue * Math.Pow(numberSystemPower, --degree)));
                    else if (i == 2)
                        result.AddGreen((byte)(hexValue * Math.Pow(numberSystemPower, --degree)));
                    else
                        result.AddBlue((byte)(hexValue * Math.Pow(numberSystemPower, --degree)));
                }
                ++i;
            }

            return result;
        }
    }
}
