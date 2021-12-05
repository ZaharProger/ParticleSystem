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
        private byte speedDelta;

        public DebugMode()
        {
            stepFlag = 0;
            speedDelta = 1;
        }

        public void SetStepFlag(byte value)
        {
            stepFlag = value;
        }

        public byte GetStepFlag()
        {
            return stepFlag;
        }

        public void SetDelta(byte value)
        {
            stepFlag = value;
        }

        public byte GetDelta()
        {
            return stepFlag;
        }
    }
}
