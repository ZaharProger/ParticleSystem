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
        private List<ImpactPoint> impactPoints;
        private bool isActive;
        private long particlesAmount;
        private int x;
        private int y;
        private short particleMaxRadius;
        private short particleMinSpeed;
        private short particleMaxSpeed;
        private short particleMaxHealth;
        private short direction;
        private short spreading;
        private float gravitationX;
        private float gravitationY;
        private string startColor;
        private string endColor;
        private int frequency;
       
        public Generator()
        {
            particles = new List<Particle>();
            impactPoints = new List<ImpactPoint>();
            isActive = true;
            x = 0;
            y = 0;
            particleMaxRadius = 15;
            particleMaxHealth = 100;
            particleMinSpeed = 1;
            particleMaxSpeed = 10;
            direction = 0;
            spreading = 360;
            startColor = "ffff0000";
            endColor = "000000ff";
            particlesAmount = 0;
            frequency = 10;
            gravitationX = 0;
            gravitationY = 1;
        }

        public Generator(int x, int y, short maxRadius, short maxHealth, short minSpeed, short maxSpeed, short direction, short spreading, string startColor, string endColor, int frequency, float gravitationX, float gravitationY)
        {
            particles = new List<Particle>();
            impactPoints = new List<ImpactPoint>();
            isActive = true;
            this.x = x;
            this.y = y;
            particleMaxRadius = maxRadius;
            particleMaxHealth = maxHealth;
            particleMinSpeed = minSpeed;
            particleMaxSpeed = maxSpeed;
            this.direction = direction;
            this.spreading = spreading;
            this.startColor = startColor;
            this.endColor = endColor;
            particlesAmount = 0;
            this.frequency = frequency;
            this.gravitationX = gravitationX;
            this.gravitationY = gravitationY;
        }

        public void SwitchActivity()
        {
            isActive = !isActive;
        }

        public bool IsActive()
        {
            return isActive;
        }

        public void SetX(int x)
        {
            this.x = x;
        }

        public void SetY(int y)
        {
            this.y = y;
        }

        public void SetMaxRadius(short radius)
        {
            particleMaxRadius = radius;
        }

        public short GetMaxRadius()
        {
            return particleMaxRadius;
        }

        public void SetMaxHealth(short health)
        {
            particleMaxHealth = health;
        }

        public short GetMaxHealth()
        {
            return particleMaxHealth;
        }

        public void SetMaxSpeed(short speed)
        {
            particleMaxSpeed = speed;
        }

        public void SetMinSpeed(short speed)
        {
            particleMinSpeed = speed;
        }

        public short GetMaxSpeed()
        {
            return particleMaxSpeed;
        }

        public void SetSpreading(short spreading)
        {
            this.spreading = spreading;
        }

        public short GetSpreading()
        {
            return spreading;
        }

        public void SetDirection(short direction)
        {
            this.direction = direction;
        }

        public short GetDirection()
        {
            return direction;
        }

        public void SetStartColor(string startColor)
        {
            this.startColor = startColor;
        }

        public void SetEndColor(string endColor)
        {
            this.endColor = endColor;
        }

        public long GetParticlesAmount()
        {
            return particlesAmount;
        }

        public void SetFrequency(int frequency)
        {
            this.frequency = frequency;
            particles.Clear();
        }

        public void AddImpactPoint(ImpactPoint point)
        {
            impactPoints.Add(point);
        }

        //Обновление генератора
        public void Update(byte stepFlag)
        {
            //Вычитаем время жизни у частиц, обновляя их характеристики при нулевом времени жизни, иначем придаем динамику
            if (stepFlag != 2)
            {
                foreach (Particle particle in particles)
                {
                    particle.AddHealth(-0.5f);
                    if (particle.GetHealth() < 0)
                    {
                        particle.ResetHealth(particleMaxHealth);
                        particle.ResetRadius(particleMaxRadius);
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
            }

            ReleaseImpact(stepFlag);
            CreateParticles(frequency);
        }


        //Отрисовка
        public void Render(System.Drawing.Graphics drawer, byte xRayFlag)
        {
            foreach (Particle particle in particles)
            {
                particle.Draw(drawer, startColor, endColor, xRayFlag);
            }

            foreach (ImpactPoint point in impactPoints)
            {
                if ((point is ParticleCollector || point is Teleport || point == impactPoints[impactPoints.Count - 1]) && point.IsActive())
                    point.Draw(drawer);
            }
        }

        //Создание частиц
        private void CreateParticles(int frequency)
        {
            //создаем частицы
            for (int i = 0; i < frequency && particles.Count < frequency * 50; ++i)
            {
                particles.Add(new Particle(x, y, particleMaxRadius, particleMaxHealth, particleMinSpeed, particleMaxSpeed, direction, spreading));
            }
        }

        //Взаимодействие с точками
        private void ReleaseImpact(byte stepFlag)
        {
            foreach (Particle particle in particles)
            {
                foreach (ImpactPoint point in impactPoints)
                {
                    if (stepFlag != 2)
                    {
                        if (point == impactPoints[impactPoints.Count - 1] && point.IsActive())
                        {
                            point.AddX(-0.04f);
                            if (point.GetX() <= -60)
                            {
                                point.SetActivity(false);
                                point.SetX(1660);
                            }
                        }

                        if (point.IsActive())
                            point.Impact(particle);
                    }
                    else if (point is Analyzer && point.IsActive())
                        point.Impact(particle);
                }
            }
        }
    }
}
