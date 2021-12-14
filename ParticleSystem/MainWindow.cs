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
        private Analyzer analyzer;
        private List<Label> particleValues;
        private DebugMode debugMode;

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
            simulationSpeedBar.Maximum = 5;
            simulationSpeedBar.Minimum = 1;
            particleValues = new List<Label>() { circleValue, dotValue, leftWingValue, rightWingValue, streamValue};

            viewPort.Image = new Bitmap(viewPort.Width, viewPort.Height);

            debugMode = new DebugMode((byte)time.Interval);
            generators = new List<Generator>();
            generators.Add(new Generator(viewPort.Width / 2, viewPort.Height / 2 - 250, 10, 100, 10, 10, 0, 10, "ffff0000", "0000ff00", 10, 0, 0));
            generators.Add(new Generator(viewPort.Width / 2, viewPort.Height / 2 + 120, 10, 100, 1, 10, 0, 10, "ffff0000", "000000ff", 10, 0, 1));
            generators.Add(new Generator(viewPort.Width / 2 - 10, viewPort.Height / 2 - 80, 10, 100, 1, 1, 0, 1, "ffff0000", "000000ff", 10, 0, 1));
            generators.Add(new Generator(viewPort.Width / 2 + 10, viewPort.Height / 2 - 80, 10, 100, 1, 1, 180, 1, "ffff0000", "000000ff", 10, 0, 1));
            generators.Add(new Generator(100, 100, 10, 100, 1, 1, 0, 1, "ffff0000", "000000ff", 10, 0, 0.5f));
            collector = new ParticleCollector(0, 0, 100, false);
            teleport = new Teleport(100, 500, 80, 80, 800, 100, true);
            antiGravityPoint = new GravityPoint(1660, viewPort.Height / 2, 50, 15, 200, true, false);
            analyzer = new Analyzer(0, 0, 10, true);
            generators[0].AddImpactPoint(new GravityPoint(viewPort.Width / 2, viewPort.Height / 2, 500, 500, 100, false, true));
            generators[1].AddImpactPoint(new GravityPoint(viewPort.Width / 2, viewPort.Height / 2 + 120, 20, 20, 50, false, true));
            generators[2].AddImpactPoint(new GravityPoint(viewPort.Width / 2 - 80, viewPort.Height / 2 - 80, 20, 20, 500, false, true));
            generators[3].AddImpactPoint(new GravityPoint(viewPort.Width / 2 + 80, viewPort.Height / 2 - 80, 20, 20, 500, false, true));
            foreach (Generator generator in generators)
            {
                generator.AddImpactPoint(analyzer);
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
            else if (e.Button == MouseButtons.Middle)
            {
                analyzer.SetInteraction(analyzer.IsActive() ? (byte)5 : (byte)0);
            }
        }

        //обработка движения мыши
        private void viewPort_MouseMove(object sender, MouseEventArgs e)
        {
            collector.SetX(e.X);
            collector.SetY(e.Y);
            analyzer.SetX(e.X);
            analyzer.SetY(e.Y);
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
                    generators[debugMode.GetActiveGenerator()].SetFrequency((int)uint.Parse(frequencyField.Text));
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
                debugMode.SetCollectorSizeFlag(1);
            }
            else if (e.KeyCode == Keys.X)
            {
                debugMode.SetCollectorSizeFlag(-1);
            }
            else if (e.KeyCode == Keys.C)
            {
                debugMode.SetCollectorSizeFlag(0);
            }
            else if (e.KeyCode == Keys.V)
            {
                collector.Clear();
            }
            else if (e.KeyCode == Keys.Up)
            {
                analyzer.SetInteraction(analyzer.IsActive() ? (byte)1 : (byte)0);
            }
            else if (e.KeyCode == Keys.Down)
            {
                analyzer.SetInteraction(analyzer.IsActive() ? (byte)2 : (byte)0);
            }
            else if (e.KeyCode == Keys.Left)
            {
                analyzer.SetInteraction(analyzer.IsActive() ? (byte)3 : (byte)0);
            }
            else if (e.KeyCode == Keys.Right)
            {
                analyzer.SetInteraction(analyzer.IsActive() ? (byte)4 : (byte)0);
            }
            else if (e.KeyCode != Keys.Left && e.KeyCode != Keys.Right && e.KeyCode != Keys.Up && e.KeyCode != Keys.Down)
            {
                frequencyField.Focus();
            }
        }

        //событие при очередном тике таймера
        private void time_Tick(object sender, EventArgs e)
        {
            radiusBar.Value = generators[debugMode.GetActiveGenerator()].GetMaxRadius();
            healthBar.Value = generators[debugMode.GetActiveGenerator()].GetMaxHealth();
            speedBar.Value = generators[debugMode.GetActiveGenerator()].GetMaxSpeed();
            directionBar.Value = generators[debugMode.GetActiveGenerator()].GetDirection();
            spreadingBar.Value = generators[debugMode.GetActiveGenerator()].GetSpreading();
            collector.AddWidth(debugMode.GetCollectorSizeFlag());           
            using (Graphics drawer = Graphics.FromImage(viewPort.Image))
            {
                drawer.Clear(Color.Black);
                byte i = 0;
                foreach (Generator generator in generators)
                {
                    if (generator.IsActive())
                    {
                        generator.Update(debugMode.GetStepFlag());
                        infoField.Text = analyzer.GetInfo();
                        particleValues[i].Text = generator.GetParticlesAmount().ToString();
                        generator.Render(drawer, debugMode.GetXRayFlag());
                    }
                    ++i; ;
                }
            }

            if (debugMode.GetStepFlag() == 1)
                debugMode.SetStepFlag(2);
            viewPort.Invalidate();                
        }

        #region[установка цветов]
        //выбор начального красного цвета для частиц
        private void redColorButton_Click(object sender, EventArgs e)
        {
            generators[debugMode.GetActiveGenerator()].SetStartColor("ffff0000");
        }

        //выбор конечного оранжевого цвета для частиц
        private void orangeColorButton_Click(object sender, EventArgs e)
        {
            generators[debugMode.GetActiveGenerator()].SetStartColor("ffff8000");
        }

        //выбор начального желтого цвета для частиц
        private void yellowColorButton_Click(object sender, EventArgs e)
        {
            generators[debugMode.GetActiveGenerator()].SetStartColor("ffffff00");
        }

        //выбор конечного синего цвета для частиц
        private void blueColorButton_Click(object sender, EventArgs e)
        {
            generators[debugMode.GetActiveGenerator()].SetEndColor("000000ff");
        }

        //выбор конечного розового цвета для частиц
        private void pinkColorButton_Click(object sender, EventArgs e)
        {
            generators[debugMode.GetActiveGenerator()].SetEndColor("00ec0dda");
        }

        //выбор конечного зеленого цвета для частиц
        private void greenColorButton_Click(object sender, EventArgs e)
        {
            generators[debugMode.GetActiveGenerator()].SetEndColor("0000ff00");
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
            generators[debugMode.GetActiveGenerator()].SetMaxRadius((short)radiusBar.Value);
            tip.SetToolTip(radiusBar, radiusBar.Value.ToString());
        }

        private void healthBar_Scroll(object sender, EventArgs e)
        {
            generators[debugMode.GetActiveGenerator()].SetMaxHealth((short)healthBar.Value);
            tip.SetToolTip(healthBar, healthBar.Value.ToString());
        }

        private void speedBar_Scroll(object sender, EventArgs e)
        {
            generators[debugMode.GetActiveGenerator()].SetMaxSpeed((short)speedBar.Value);
            tip.SetToolTip(speedBar, speedBar.Value.ToString());
            if (debugMode.GetActiveGenerator() == 0)
                generators[debugMode.GetActiveGenerator()].SetMinSpeed((short)speedBar.Value);
        }

        private void directionBar_Scroll(object sender, EventArgs e)
        {
            generators[debugMode.GetActiveGenerator()].SetDirection((short)directionBar.Value);
            tip.SetToolTip(directionBar, directionBar.Value.ToString());
        }

        private void spreadingBar_Scroll(object sender, EventArgs e)
        {
            generators[debugMode.GetActiveGenerator()].SetSpreading((short)spreadingBar.Value);
            tip.SetToolTip(spreadingBar, spreadingBar.Value.ToString());
        }
        #endregion[изменение параметров генератора]

        #region[выбор генератора]
        private void generator1Button_Click(object sender, EventArgs e)
        {
            debugMode.SetActiveGenerator(0);
        }

        private void generator2Button_Click(object sender, EventArgs e)
        {
            debugMode.SetActiveGenerator(1);
        }

        private void generator3Button_Click(object sender, EventArgs e)
        {
            debugMode.SetActiveGenerator(2);
        }

        private void generator4Button_Click(object sender, EventArgs e)
        {
            debugMode.SetActiveGenerator(3);
        }

        private void generator5Button_Click(object sender, EventArgs e)
        {
            debugMode.SetActiveGenerator(4);
        }
        #endregion[выбор генератора]       

        //Включение/отключение генераторов
        private void switchButton_Click(object sender, EventArgs e)
        {
            generators[debugMode.GetActiveGenerator()].SwitchActivity();
            tip.SetToolTip(switchButton, "Включение/Отключение компонента");
        }

        //Запуск отталкивающей точки
        private void interactiveButton_Click(object sender, EventArgs e)
        {
            antiGravityPoint.SetActivity(true);
            tip.SetToolTip(interactiveButton, "Запуск интерактивной анимации");
        }

        //Активация сборщика частиц
        private void collectorSwitchButton_Click(object sender, EventArgs e)
        {
            collector.SwitchActivity();
            analyzer.SwitchActivity();          
            if (collector.IsActive())
            {
                tip.SetToolTip(collectorSwitchButton, "Смена сборщика частиц на анализатор частиц");
                tip.SetToolTip(viewPort, "Управление сборщиком частиц:\nУвеличить размер - Z\nУменьшить размер - X\nЗафиксировать размер - С\nОчистить - V");
                collectorSwitchButton.Text = "Сборщик";
            }
            else
            {
                tip.SetToolTip(collectorSwitchButton, "Смена анализатора частиц на сборщик частиц");
                tip.SetToolTip(viewPort, "Наведите на частицу курсор мыши, чтобы отобразить её характеристики\nИспользуйте стрелки для изменения параметров частицы\nПри нажатии колеса мыши частица будет удалена");
                collectorSwitchButton.Text = "Анализатор";
            }
        }

        //Установка пошаговой симуляции
        private void stepButton_Click(object sender, EventArgs e)
        {
            switch (debugMode.GetStepFlag())
            {
                case 0:
                    debugMode.SetStepFlag(1);
                    break;
                default:
                    debugMode.SetStepFlag(0);
                    debugMode.SetStepFlag(1);
                    break;
            }
            tip.SetToolTip(stepButton, "Выполнить шаг симуляции");
        }

        //Изменение скорости симуляции
        private void simulationSpeedBar_Scroll(object sender, EventArgs e)
        {          
            debugMode.SetDelta((byte)simulationSpeedBar.Value);
            time.Interval = debugMode.CalculateSpeed();
            debugMode.SetStepFlag(0);
            tip.SetToolTip(simulationSpeedBar, simulationSpeedBar.Value.ToString());
        }

        //Выбор режима ускорения или замедления
        private void deltaButton_Click(object sender, EventArgs e)
        {
            debugMode.SwitchSign();
            tip.SetToolTip(deltaButton, "Ускорение/Замедление");
        }

        //Включение рентгена
        private void xRayButton_Click(object sender, EventArgs e)
        {
            switch (debugMode.GetXRayFlag())
            {
                case 0:
                    debugMode.SetXRayFlag(1);
                    break;
                default:
                    debugMode.SetXRayFlag(0);
                    break;
            }

            tip.SetToolTip(xRayButton, "Отрисовка контура частиц для отображения пересечения");
        }
    }
}
