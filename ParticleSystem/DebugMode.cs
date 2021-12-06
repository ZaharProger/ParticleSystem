using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticleSystem
{
    //Дебаг режим
    class DebugMode
    {
        private byte stepFlag;
        private short delta;
        private short speed;
        private byte sign;

        public DebugMode()
        {
            stepFlag = 0;
            delta = 1;
            speed = 30;
            sign = 1;
        }

        public void SetStepFlag(byte value)
        {
            stepFlag = value;
        }

        public byte GetStepFlag()
        {
            return stepFlag;
        }

        public void SetDelta(short delta)
        {
            this.delta = delta;
        }

        public void SwitchSign()
        {
            switch (sign)
            {
                case 1:
                    sign = 0;
                    break;
                case 0:
                    sign = 1;
                    break;
            }
        }

        public short CalculateSpeed()
        {
            return (sign == 1) ? (short)(speed / delta) : (short)(speed * delta);
        }
    }
}
