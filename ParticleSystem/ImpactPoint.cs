using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticleSystem
{
    //Точка, воздействующая на частицы
    abstract class ImpactPoint
    {
        protected float x;
        protected float y;
        protected float width;
        protected float height;
        protected bool isActive;

        public void SetX(float x)
        {
            this.x = x;
        }

        public void SetY(float y)
        {
            this.y = y;
        }

        public void AddX(float x)
        {
            this.x += x;
        }

        public float GetX()
        {
            return x;
        }

        public void AddWidth(float width)
        {
            this.width += width;
        }

        public void SwitchActivity()
        {
            isActive = !isActive;
        }

        public bool IsActive()
        {
            return isActive;
        }

        public void SetActivity(bool status)
        {
            isActive = status;
        }

        //Воздействие на частицу
        public abstract void Impact(Particle particle);

        //Отрисовка
        public virtual void Draw(System.Drawing.Graphics drawer)
        {
            drawer.DrawEllipse(new System.Drawing.Pen(System.Drawing.Color.White, 2), x - width / 2, y - height / 2, width, height);
        }
    }
}
