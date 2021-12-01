using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticleSystem
{
    //Генератор частиц
    class Generator
    {
        private List<Particle> particles;
        private int particlesAmount;
        private int x;
        private int y;
        private static float gravitationX = 0;
        private static float gravitationY = 1;
        private string startColor;
        private string endColor;

        public Generator()
        {
            particles = new List<Particle>();
            x = 0;
            y = 0;
            startColor = "ffff0000";
            endColor = "000000ff";
            particlesAmount = 0;
        }

        public Generator(int x, int y, string startColor, string endColor)
        {
            particles = new List<Particle>();
            this.x = x;
            this.y = y;
            this.startColor = startColor;
            this.endColor = endColor;
            particlesAmount = 0;
        }

        public void SetX(int x)
        {
            this.x = x;
        }

        public void SetY(int y)
        {
            this.y = y;
        }

        public void SetStartColor(string startColor)
        {
            this.startColor = startColor;
        }

        public void SetEndColor(string endColor)
        {
            this.endColor = endColor;
        }

        public int GetParticlesAmount()
        {
            return particlesAmount;
        }

        //Обновление генератора
        public void Update()
        {
            //Вычитаем время жизни у частиц, обновляя их характеристики при нулевом времени жизни, иначем придаем динамику
            foreach (Particle particle in particles)
            {
                particle.AddHealth(-0.5f);
                if (particle.GetHealth() < 0)
                {
                    particle.ResetHealth();
                    particle.ResetRadius();
                    particle.ResetSpeedX();
                    particle.ResetSpeedY();
                    particle.SetX(x);
                    particle.SetY(y);
                    ++particlesAmount;
                }
                else
                {
                    particle.AddSpeedX(gravitationX);
                    particle.AddSpeedY(gravitationY);
                    particle.AddX(particle.GetSpeedX());
                    particle.AddY(particle.GetSpeedY());
                }
            }

            //создаем частицы в количестве 10 штук за тик до 500 штук
            for (int i = 0; i < 20 && particles.Count < 500; ++i)
            {
                particles.Add(new Particle(x, y));
            }
        }

        //Отрисовка частиц
        public void Render(System.Drawing.Graphics drawer)
        {
            foreach (Particle particle in particles)
            {
                particle.Draw(drawer, startColor, endColor);
            }
    }
    }
}
