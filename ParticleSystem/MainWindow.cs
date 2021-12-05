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

        private List<Generator> generators;
        private ParticleCollector collector;
        private Teleport teleport;
        private GravityPoint antiGravityPoint;
        private short collectorSizeFlag;
        private short activeGenerator;
        private List<Label> particleValues;

        public MainWindow()
        {
            InitializeComponent();
            radiusBar.Maximum = 50;
            radiusBar.Minimum = 1;           
            healthBar.Maximum = 100;
            healthBar.Minimum = 1;
            speedBar.Maximum = 100;
            speedBar.Minimum = 1;
            directionBar.Maximum = 360;
            directionBar.Minimum = 0;
            spreadingBar.Maximum = 359;
            spreadingBar.Minimum = 1;
            particleValues = new List<Label>() { circleValue, dotValue, leftWingValue, rightWingValue, streamValue};

            collectorSizeFlag = 0;
            activeGenerator = 1;
            viewPort.Image = new Bitmap(viewPort.Width, viewPort.Height);


            generators = new List<Generator>();
            generators.Add(new Generator(viewPort.Width / 2, viewPort.Height / 2 - 250, 10, 100, 10, 10, 0, 10, "ffff0000", "0000ff00", 10, 0, 0));
            generators.Add(new Generator(viewPort.Width / 2, viewPort.Height / 2 + 120, 10, 100, 1, 10, 0, 10, "ffff0000", "000000ff", 10, 0, 1));
            generators.Add(new Generator(viewPort.Width / 2 - 10, viewPort.Height / 2 - 80, 10, 100, 1, 1, 0, 1, "ffff0000", "000000ff", 10, 0, 1));
            generators.Add(new Generator(viewPort.Width / 2 + 10, viewPort.Height / 2 - 80, 10, 100, 1, 1, 180, 1, "ffff0000", "000000ff", 10, 0, 1));
            generators.Add(new Generator(100, 100, 10, 100, 1, 1, 0, 1, "ffff0000", "000000ff", 10, 0, 0.5f));
            collector = new ParticleCollector();
            teleport = new Teleport(100, 500, 80, 80, 800, 100, true);
            antiGravityPoint = new GravityPoint(1660, viewPort.Height / 2, 50, 15, 200, true, false);           
            generators[0].AddImpactPoint(new GravityPoint(viewPort.Width / 2, viewPort.Height / 2, 500, 500, 100, false, true));
            generators[1].AddImpactPoint(new GravityPoint(viewPort.Width / 2, viewPort.Height / 2 + 120, 20, 20, 50, false, true));
            generators[2].AddImpactPoint(new GravityPoint(viewPort.Width / 2 - 80, viewPort.Height / 2 - 80, 20, 20, 500, false, true));
            generators[3].AddImpactPoint(new GravityPoint(viewPort.Width / 2 + 80, viewPort.Height / 2 - 80, 20, 20, 500, false, true));
            foreach (Generator generator in generators)
            {
                generator.AddImpactPoint(collector);
                generator.AddImpactPoint(teleport);
                generator.AddImpactPoint(antiGravityPoint);
            }
        }

        //обработка нажатий клавиши мыши
        private void viewPort_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                teleport.SetX(e.X);
                teleport.SetY(e.Y);
            }
            else if (e.Button == MouseButtons.Right)
            {
                teleport.SetOutputX(e.X);
                teleport.SetOutputY(e.Y);
            }
        }

        //обработка движения мыши
        private void viewPort_MouseMove(object sender, MouseEventArgs e)
        {
            collector.SetX(e.X);
            collector.SetY(e.Y);          
        }

        //обработка нажатий клавиш
        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
            else if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    generators[activeGenerator].SetFrequency((int)uint.Parse(frequencyField.Text));
                }
                catch (FormatException)
                {
                    frequencyField.Text = "";
                    MessageBox.Show("Введите целое число!", "Ошибка");
                }
                catch (ArgumentNullException)
                {
                    MessageBox.Show("Данные не получены!", "Ошибка");
                }
                catch (OverflowException)
                {
                    MessageBox.Show("Введите положительное число не более " + int.MaxValue, "Ошибка");
                }
            }
            else if (e.KeyCode == Keys.Z)
            {
                collectorSizeFlag = 1;
            }
            else if (e.KeyCode == Keys.X)
            {
                collectorSizeFlag = -1;
            }
            else if (e.KeyCode == Keys.C)
            {
                collectorSizeFlag = 0;
            }
            else if (e.KeyCode != Keys.Left && e.KeyCode != Keys.Right && e.KeyCode != Keys.Up && e.KeyCode != Keys.Down)
            {
                frequencyField.Focus();
            }
        }

        //событие при очередном тике таймера
        private void time_Tick(object sender, EventArgs e)
        {
            radiusBar.Value = generators[activeGenerator].GetMaxRadius();
            healthBar.Value = generators[activeGenerator].GetMaxHealth();
            speedBar.Value = generators[activeGenerator].GetMaxSpeed();
            directionBar.Value = generators[activeGenerator].GetDirection();
            spreadingBar.Value = generators[activeGenerator].GetSpreading();
            collector.AddWidth(collectorSizeFlag);
            using (Graphics drawer = Graphics.FromImage(viewPort.Image))
            {
                drawer.Clear(Color.Black);
                byte i = 0;
                foreach (Generator generator in generators)
                {
                    if (generator.IsActive())
                    {
                        generator.Update();
                        particleValues[i].Text = generator.GetParticlesAmount().ToString();
                        generator.Render(drawer);
                    }
                    ++i;
                }
            }
            
            viewPort.Invalidate();
        }

        #region[установка цветов]
        //выбор начального красного цвета для частиц
        private void redColorButton_Click(object sender, EventArgs e)
        {
            generators[activeGenerator].SetStartColor("ffff0000");
        }

        //выбор конечного оранжевого цвета для частиц
        private void orangeColorButton_Click(object sender, EventArgs e)
        {
            generators[activeGenerator].SetStartColor("ffff8000");
        }

        //выбор начального желтого цвета для частиц
        private void yellowColorButton_Click(object sender, EventArgs e)
        {
            generators[activeGenerator].SetStartColor("ffffff00");
        }

        //выбор конечного синего цвета для частиц
        private void blueColorButton_Click(object sender, EventArgs e)
        {
            generators[activeGenerator].SetEndColor("000000ff");
        }

        //выбор конечного розового цвета для частиц
        private void pinkColorButton_Click(object sender, EventArgs e)
        {
            generators[activeGenerator].SetEndColor("00ec0dda");
        }

        //выбор конечного зеленого цвета для частиц
        private void greenColorButton_Click(object sender, EventArgs e)
        {
            generators[activeGenerator].SetEndColor("0000ff00");
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

        #region[изменение параметров генератора]
        private void radiusBar_Scroll(object sender, EventArgs e)
        {
            generators[activeGenerator].SetMaxRadius((short)radiusBar.Value);
            tip.SetToolTip(radiusBar, radiusBar.Value.ToString());
        }

        private void healthBar_Scroll(object sender, EventArgs e)
        {
            generators[activeGenerator].SetMaxHealth((short)healthBar.Value);
            tip.SetToolTip(healthBar, healthBar.Value.ToString());
        }

        private void speedBar_Scroll(object sender, EventArgs e)
        {
            generators[activeGenerator].SetMaxSpeed((short)speedBar.Value);
            tip.SetToolTip(speedBar, speedBar.Value.ToString());
            if (activeGenerator == 0)
                generators[activeGenerator].SetMinSpeed((short)speedBar.Value);
        }

        private void directionBar_Scroll(object sender, EventArgs e)
        {
            generators[activeGenerator].SetDirection((short)directionBar.Value);
            tip.SetToolTip(directionBar, directionBar.Value.ToString());
        }

        private void spreadingBar_Scroll(object sender, EventArgs e)
        {
            generators[activeGenerator].SetSpreading((short)spreadingBar.Value);
            tip.SetToolTip(spreadingBar, spreadingBar.Value.ToString());
        }
        #endregion[изменение параметров генератора]

        #region[выбор генератора]
        private void generator1Button_Click(object sender, EventArgs e)
        {
            activeGenerator = 0;
        }

        private void generator2Button_Click(object sender, EventArgs e)
        {
            activeGenerator = 1;
        }

        private void generator3Button_Click(object sender, EventArgs e)
        {
            activeGenerator = 2;
        }

        private void generator4Button_Click(object sender, EventArgs e)
        {
            activeGenerator = 3;
        }

        private void generator5Button_Click(object sender, EventArgs e)
        {
            activeGenerator = 4;
        }
        #endregion[выбор генератора]       

        //Включение/отключение генераторов
        private void switchButton_Click(object sender, EventArgs e)
        {
            generators[activeGenerator].SwitchActivity();
        }

        //Очистка сборщика частиц
        private void clearButton_Click(object sender, EventArgs e)
        {
            collector.Clear();
        }

        //Запуск отталкивающей точки
        private void interactiveButton_Click(object sender, EventArgs e)
        {
            antiGravityPoint.SetActivity(true);
        }
    }
}
