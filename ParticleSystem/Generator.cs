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
        private short particleMinRadius;
        private short particleMaxRadius;
        private short particleMinSpeed;
        private short particleMaxSpeed;
        private short particleMinHealth;
        private short particleMaxHealth;
        private short direction;
        private short spreading;
        private static float gravitationX = 0;
        private static float gravitationY = 1;
        private string startColor;
        private string endColor;
        private int frequency;

        public Generator()
        {
            particles = new List<Particle>();
            x = 0;
            y = 0;
            particleMinRadius = 1;
            particleMaxRadius = 15;
            particleMinHealth = 10;
            particleMaxHealth = 100;
            particleMinSpeed = 1;
            particleMaxSpeed = 10;
            direction = 0;
            spreading = 360;
            startColor = "ffff0000";
            endColor = "000000ff";
            particlesAmount = 0;
            frequency = 10;
        }

        public Generator(int x, int y, short minRadius, short maxRadius, short minHealth, short maxHealth, short minSpeed, short maxSpeed, short direction, short spreading, string startColor, string endColor, int frequency)
        {
            particles = new List<Particle>();
            this.x = x;
            this.y = y;
            particleMinRadius = minRadius;
            particleMaxRadius = maxRadius;
            particleMinHealth = minHealth;
            particleMaxHealth = maxHealth;
            particleMinSpeed = minSpeed;
            particleMaxSpeed = maxSpeed;
            this.direction = direction;
            this.spreading = spreading;
            this.startColor = startColor;
            this.endColor = endColor;
            particlesAmount = 0;
            this.frequency = frequency;
        }

        public void SetX(int x)
        {
            this.x = x;
        }

        public void SetY(int y)
        {
            this.y = y;
        }

        public void SetMinRadius(short radius)
        {
            particleMinRadius = radius;
        }

        public void SetMaxRadius(short radius)
        {
            particleMaxRadius = radius;
        }

        public void SetMinHealth(short health)
        {
            particleMinHealth = health;
        }

        public void SetMaxHealth(short health)
        {
            particleMaxHealth = health;
        }

        public void SetMinSpeed(short speed)
        {
            particleMinSpeed = speed;
        }

        public void SetMaxSpeed(short speed)
        {
            particleMaxSpeed = speed;
        }

        public void SetSpreading(short spreading)
        {
            this.spreading = spreading;
        }

        public void SetDirection(short direction)
        {
            this.direction = direction;
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

        public void SetFrequency(int frequency)
        {
            this.frequency = frequency;
            particles.Clear();
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
                    particle.ResetHealth(particleMinHealth, particleMaxHealth);
                    particle.ResetRadius(particleMinRadius, particleMaxRadius);
                    particle.ResetSpeedX(particleMinSpeed, particleMaxSpeed, direction, spreading);
                    particle.ResetSpeedY(particleMinSpeed, particleMaxSpeed, direction, spreading);
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

            CreateParticles(frequency);
        }

        public void ReleaseImpact(ImpactPoint point)
        {
            foreach(Particle particle in particles)
            {
                point.Impact(particle);
            }
        }

        //Отрисовка
        public void Render(System.Drawing.Graphics drawer)
        {
            foreach (Particle particle in particles)
            {
                particle.Draw(drawer, startColor, endColor);
            }
        }

        //Создание частиц
        private void CreateParticles(int frequency)
        {
            //создаем частицы
            for (int i = 0; i < frequency && particles.Count < frequency * 50; ++i)
            {
                particles.Add(new Particle(x, y, particleMinRadius, particleMaxRadius, particleMinHealth, particleMaxHealth, particleMinSpeed, particleMaxSpeed, direction, spreading));
            }
        }
    }
}
