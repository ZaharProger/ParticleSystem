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
        private byte reverseFlag;
        private List<System.Drawing.Image> buffer;
        private const short bufferCapacity = 1000;

        public DebugMode()
        {
            stepFlag = 0;
            delta = 1;
            speed = 30;
            sign = 1;
            reverseFlag = 0;
            buffer = new List<System.Drawing.Image>();
        }

        public void AddSystemStatus (System.Drawing.Image status)
        {
            if (buffer.Count < bufferCapacity)
                buffer.Add(status);
        }

        public bool isBufferEmpty()
        {
            return buffer.Count == 0;
        }

        public System.Drawing.Image GetPreviousSystemStatus()
        {
            System.Drawing.Image systemStatus = buffer[buffer.Count - 1];
            buffer.RemoveAt(buffer.Count - 1);

            return systemStatus;
        }

        public void SetReverseFlag(byte value)
        {
            reverseFlag = value;
        }

        public byte GetReverseFlag()
        {
            return reverseFlag;
        }

        public void SetStepFlag(byte value)
        {
            stepFlag = value;
        }

        public byte GetStepFlag()
        {
            return stepFlag;
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
