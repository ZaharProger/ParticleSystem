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
        private byte delta;
        private byte speed;
        private byte sign;
        private byte xRayFlag;
        private byte activeGenerator;
        private short collectorSizeFlag;
        public DebugMode(byte speed)
        {
            stepFlag = 0;
            delta = 1;
            this.speed = speed;
            sign = 1;
            xRayFlag = 0;
            activeGenerator = 0;
            collectorSizeFlag = 0;
        }

        public void SetActiveGenerator(byte value)
        {
            activeGenerator = value;
        }

        public byte GetActiveGenerator()
        {
            return activeGenerator;
        }

        public void SetCollectorSizeFlag(short value)
        {
            collectorSizeFlag = value;
        }

        public short GetCollectorSizeFlag()
        {
            return collectorSizeFlag;
        }

        public void SetStepFlag(byte value)
        {
            stepFlag = value;
        }

        public byte GetStepFlag()
        {
            return stepFlag;
        }

        public void SetXRayFlag(byte value)
        {
            xRayFlag = value;
        }

        public byte GetXRayFlag()
        {
            return xRayFlag;
        }

        public void SetDelta(byte delta)
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

        public byte CalculateSpeed()
        {
            return (sign == 1) ? (byte)(speed / delta) : (byte)(speed * delta);
        }
    }
}
