using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParticleSystem
{
    public partial class MainWindow : Form
    {

        private Generator generator;
        public MainWindow()
        {
            InitializeComponent();
            viewPort.Image = new Bitmap(viewPort.Width, viewPort.Height);
            generator = new Generator();
        }

        //считывание координат курсора
        private void viewPort_MouseMove(object sender, MouseEventArgs e)
        {
            generator.SetX(e.X);
            generator.SetY(e.Y);
        }

        //закрытие формы клавишей
        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        //событие при очередном тике таймера
        private void time_Tick(object sender, EventArgs e)
        {
            generator.Update();
            particlesAmountValue.Text = generator.GetParticlesAmount().ToString();
            using (Graphics drawer = Graphics.FromImage(viewPort.Image))
            {
                drawer.Clear(Color.Black);
                generator.Render(drawer);
            }
            viewPort.Invalidate();
        }

        #region[установка цветов]
        //выбор начального красного цвета для частиц
        private void redColorButton_Click(object sender, EventArgs e)
        {
            generator.SetStartColor("ffff0000");
        }

        //выбор конечного оранжевого цвета для частиц
        private void orangeColorButton_Click(object sender, EventArgs e)
        {
            generator.SetStartColor("ffff8000");
        }

        //выбор начального желтого цвета для частиц
        private void yellowColorButton_Click(object sender, EventArgs e)
        {
            generator.SetStartColor("ffffff00");
        }

        //выбор конечного синего цвета для частиц
        private void blueColorButton_Click(object sender, EventArgs e)
        {
            generator.SetEndColor("000000ff");
        }

        //выбор конечного розового цвета для частиц
        private void pinkColorButton_Click(object sender, EventArgs e)
        {
            generator.SetEndColor("00ec0dda");
        }

        //выбор конечного зеленого цвета для частиц
        private void greenColorButton_Click(object sender, EventArgs e)
        {
            generator.SetEndColor("0000ff00");
        }
        #endregion[установка цветов]

        #region[события при наведении курсора на кнопки]
        private void redColorButton_MouseMove(object sender, MouseEventArgs e)
        {
            redColorButton.FlatAppearance.BorderSize = 2;
        }

        private void redColorButton_MouseLeave(object sender, EventArgs e)
        {
            redColorButton.FlatAppearance.BorderSize = 1;
        }

        private void orangeColorButton_MouseMove(object sender, MouseEventArgs e)
        {
            orangeColorButton.FlatAppearance.BorderSize = 2;
        }

        private void orangeColorButton_MouseLeave(object sender, EventArgs e)
        {
            orangeColorButton.FlatAppearance.BorderSize = 1;
        }

        private void yellowColorButton_MouseMove(object sender, MouseEventArgs e)
        {
            yellowColorButton.FlatAppearance.BorderSize = 2;
        }

        private void yellowColorButton_MouseLeave(object sender, EventArgs e)
        {
            yellowColorButton.FlatAppearance.BorderSize = 1;
        }

        private void blueColorButton_MouseMove(object sender, MouseEventArgs e)
        {
            blueColorButton.FlatAppearance.BorderSize = 2;
        }

        private void blueColorButton_MouseLeave(object sender, EventArgs e)
        {
            blueColorButton.FlatAppearance.BorderSize = 1;
        }

        private void pinkColorButton_MouseMove(object sender, MouseEventArgs e)
        {
            pinkColorButton.FlatAppearance.BorderSize = 2;
        }

        private void pinkColorButton_MouseLeave(object sender, EventArgs e)
        {
            pinkColorButton.FlatAppearance.BorderSize = 1;
        }

        private void greenColorButton_MouseMove(object sender, MouseEventArgs e)
        {
            greenColorButton.FlatAppearance.BorderSize = 2;
        }

        private void greenColorButton_MouseLeave(object sender, EventArgs e)
        {
            greenColorButton.FlatAppearance.BorderSize = 1;
        }
        #endregion[события при наведении курсора на кнопки]


    }
}
