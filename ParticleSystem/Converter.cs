using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticleSystem
{
    //Конвертер
    abstract class Converter<FROM, TO>
    {
        protected FROM value;

        public Converter(FROM value)
        {
            this.value = value;
        }
        public abstract TO Convert();
    }
}
