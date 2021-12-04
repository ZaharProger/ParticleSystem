﻿
namespace ParticleSystem
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.viewPort = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.blueColorButton = new System.Windows.Forms.Button();
            this.pinkColorButton = new System.Windows.Forms.Button();
            this.greenColorButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.yellowColorButton = new System.Windows.Forms.Button();
            this.orangeColorButton = new System.Windows.Forms.Button();
            this.redColorButton = new System.Windows.Forms.Button();
            this.startColorLabel = new System.Windows.Forms.Label();
            this.endColorLabel = new System.Windows.Forms.Label();
            this.particlesAmountValue = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.generator6Button = new System.Windows.Forms.Button();
            this.generator5Button = new System.Windows.Forms.Button();
            this.generator4Button = new System.Windows.Forms.Button();
            this.generator3Button = new System.Windows.Forms.Button();
            this.generator2Button = new System.Windows.Forms.Button();
            this.spreadingBar = new System.Windows.Forms.TrackBar();
            this.directionBar = new System.Windows.Forms.TrackBar();
            this.speedBar = new System.Windows.Forms.TrackBar();
            this.healthBar = new System.Windows.Forms.TrackBar();
            this.radiusLabel = new System.Windows.Forms.Label();
            this.healthLabel = new System.Windows.Forms.Label();
            this.speedLabel = new System.Windows.Forms.Label();
            this.directionLabel = new System.Windows.Forms.Label();
            this.spreadingLabel = new System.Windows.Forms.Label();
            this.frequencyLabel = new System.Windows.Forms.Label();
            this.radiusBar = new System.Windows.Forms.TrackBar();
            this.frequencyField = new System.Windows.Forms.TextBox();
            this.generator1Button = new System.Windows.Forms.Button();
            this.time = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewPort)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spreadingBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.directionBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.healthBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiusBar)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.94657F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.05344F));
            this.tableLayoutPanel1.Controls.Add(this.viewPort, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.particlesAmountValue, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.03677F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.96323F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1582, 853);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // viewPort
            // 
            this.viewPort.BackColor = System.Drawing.Color.Black;
            this.viewPort.Cursor = System.Windows.Forms.Cursors.Cross;
            this.viewPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewPort.Location = new System.Drawing.Point(353, 8);
            this.viewPort.Name = "viewPort";
            this.viewPort.Size = new System.Drawing.Size(1221, 694);
            this.viewPort.TabIndex = 0;
            this.viewPort.TabStop = false;
            this.viewPort.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.viewPort_MouseDoubleClick);
            this.viewPort.MouseDown += new System.Windows.Forms.MouseEventHandler(this.viewPort_MouseDown);
            this.viewPort.MouseMove += new System.Windows.Forms.MouseEventHandler(this.viewPort_MouseMove);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.DimGray;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.03101F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.96899F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 801F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.startColorLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.endColorLabel, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(353, 708);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1221, 137);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.48485F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.51515F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel4.Controls.Add(this.blueColorButton, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.pinkColorButton, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.greenColorButton, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(209, 8);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(202, 88);
            this.tableLayoutPanel4.TabIndex = 15;
            // 
            // blueColorButton
            // 
            this.blueColorButton.BackColor = System.Drawing.Color.Blue;
            this.blueColorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.blueColorButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.blueColorButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.blueColorButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.blueColorButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.blueColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blueColorButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.blueColorButton.Location = new System.Drawing.Point(142, 3);
            this.blueColorButton.Name = "blueColorButton";
            this.blueColorButton.Size = new System.Drawing.Size(57, 82);
            this.blueColorButton.TabIndex = 11;
            this.blueColorButton.UseVisualStyleBackColor = false;
            this.blueColorButton.Click += new System.EventHandler(this.blueColorButton_Click);
            this.blueColorButton.MouseLeave += new System.EventHandler(this.blueColorButton_MouseLeave);
            // 
            // pinkColorButton
            // 
            this.pinkColorButton.BackColor = System.Drawing.Color.Fuchsia;
            this.pinkColorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pinkColorButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pinkColorButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.pinkColorButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia;
            this.pinkColorButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia;
            this.pinkColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pinkColorButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pinkColorButton.Location = new System.Drawing.Point(70, 3);
            this.pinkColorButton.Name = "pinkColorButton";
            this.pinkColorButton.Size = new System.Drawing.Size(66, 82);
            this.pinkColorButton.TabIndex = 10;
            this.pinkColorButton.UseVisualStyleBackColor = false;
            this.pinkColorButton.Click += new System.EventHandler(this.pinkColorButton_Click);
            this.pinkColorButton.MouseLeave += new System.EventHandler(this.pinkColorButton_MouseLeave);
            // 
            // greenColorButton
            // 
            this.greenColorButton.BackColor = System.Drawing.Color.Lime;
            this.greenColorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.greenColorButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.greenColorButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.greenColorButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.greenColorButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.greenColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.greenColorButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.greenColorButton.Location = new System.Drawing.Point(3, 3);
            this.greenColorButton.Name = "greenColorButton";
            this.greenColorButton.Size = new System.Drawing.Size(61, 82);
            this.greenColorButton.TabIndex = 9;
            this.greenColorButton.UseVisualStyleBackColor = false;
            this.greenColorButton.Click += new System.EventHandler(this.greenColorButton_Click);
            this.greenColorButton.MouseLeave += new System.EventHandler(this.greenColorButton_MouseLeave);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.69325F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.30675F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel3.Controls.Add(this.yellowColorButton, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.orangeColorButton, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.redColorButton, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(8, 8);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(195, 88);
            this.tableLayoutPanel3.TabIndex = 14;
            // 
            // yellowColorButton
            // 
            this.yellowColorButton.BackColor = System.Drawing.Color.Yellow;
            this.yellowColorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yellowColorButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yellowColorButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.yellowColorButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.yellowColorButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.yellowColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yellowColorButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yellowColorButton.Location = new System.Drawing.Point(138, 3);
            this.yellowColorButton.Name = "yellowColorButton";
            this.yellowColorButton.Size = new System.Drawing.Size(54, 82);
            this.yellowColorButton.TabIndex = 5;
            this.yellowColorButton.UseVisualStyleBackColor = false;
            this.yellowColorButton.Click += new System.EventHandler(this.yellowColorButton_Click);
            this.yellowColorButton.MouseLeave += new System.EventHandler(this.yellowColorButton_MouseLeave);
            // 
            // orangeColorButton
            // 
            this.orangeColorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.orangeColorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.orangeColorButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orangeColorButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.orangeColorButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.orangeColorButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.orangeColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orangeColorButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orangeColorButton.Location = new System.Drawing.Point(70, 3);
            this.orangeColorButton.Name = "orangeColorButton";
            this.orangeColorButton.Size = new System.Drawing.Size(62, 82);
            this.orangeColorButton.TabIndex = 4;
            this.orangeColorButton.UseVisualStyleBackColor = false;
            this.orangeColorButton.Click += new System.EventHandler(this.orangeColorButton_Click);
            this.orangeColorButton.MouseLeave += new System.EventHandler(this.orangeColorButton_MouseLeave);
            // 
            // redColorButton
            // 
            this.redColorButton.BackColor = System.Drawing.Color.Red;
            this.redColorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.redColorButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.redColorButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.redColorButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.redColorButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.redColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.redColorButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.redColorButton.Location = new System.Drawing.Point(3, 3);
            this.redColorButton.Name = "redColorButton";
            this.redColorButton.Size = new System.Drawing.Size(61, 82);
            this.redColorButton.TabIndex = 3;
            this.redColorButton.UseVisualStyleBackColor = false;
            this.redColorButton.Click += new System.EventHandler(this.redColorButton_Click);
            this.redColorButton.MouseLeave += new System.EventHandler(this.redColorButton_MouseLeave);
            // 
            // startColorLabel
            // 
            this.startColorLabel.AutoSize = true;
            this.startColorLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startColorLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startColorLabel.Location = new System.Drawing.Point(8, 99);
            this.startColorLabel.Name = "startColorLabel";
            this.startColorLabel.Size = new System.Drawing.Size(195, 33);
            this.startColorLabel.TabIndex = 16;
            this.startColorLabel.Text = "Начальный цвет частиц";
            this.startColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // endColorLabel
            // 
            this.endColorLabel.AutoSize = true;
            this.endColorLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.endColorLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endColorLabel.Location = new System.Drawing.Point(209, 99);
            this.endColorLabel.Name = "endColorLabel";
            this.endColorLabel.Size = new System.Drawing.Size(202, 33);
            this.endColorLabel.TabIndex = 17;
            this.endColorLabel.Text = "Конечный цвет частиц";
            this.endColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // particlesAmountValue
            // 
            this.particlesAmountValue.AutoSize = true;
            this.particlesAmountValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.particlesAmountValue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.particlesAmountValue.Location = new System.Drawing.Point(8, 705);
            this.particlesAmountValue.Name = "particlesAmountValue";
            this.particlesAmountValue.Size = new System.Drawing.Size(339, 143);
            this.particlesAmountValue.TabIndex = 2;
            this.particlesAmountValue.Text = "0";
            this.particlesAmountValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.DimGray;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.generator6Button, 1, 8);
            this.tableLayoutPanel5.Controls.Add(this.generator5Button, 0, 8);
            this.tableLayoutPanel5.Controls.Add(this.generator4Button, 1, 7);
            this.tableLayoutPanel5.Controls.Add(this.generator3Button, 0, 7);
            this.tableLayoutPanel5.Controls.Add(this.generator2Button, 1, 6);
            this.tableLayoutPanel5.Controls.Add(this.spreadingBar, 1, 4);
            this.tableLayoutPanel5.Controls.Add(this.directionBar, 1, 3);
            this.tableLayoutPanel5.Controls.Add(this.speedBar, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.healthBar, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.radiusLabel, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.healthLabel, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.speedLabel, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.directionLabel, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.spreadingLabel, 0, 4);
            this.tableLayoutPanel5.Controls.Add(this.frequencyLabel, 0, 5);
            this.tableLayoutPanel5.Controls.Add(this.radiusBar, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.frequencyField, 1, 5);
            this.tableLayoutPanel5.Controls.Add(this.generator1Button, 0, 6);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(8, 8);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 10;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.72727F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.27273F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 171F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(339, 694);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // generator6Button
            // 
            this.generator6Button.BackColor = System.Drawing.Color.LightGray;
            this.generator6Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generator6Button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.generator6Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.generator6Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.generator6Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generator6Button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.generator6Button.Location = new System.Drawing.Point(172, 474);
            this.generator6Button.Name = "generator6Button";
            this.generator6Button.Size = new System.Drawing.Size(164, 45);
            this.generator6Button.TabIndex = 29;
            this.generator6Button.Text = "Рот";
            this.generator6Button.UseVisualStyleBackColor = false;
            this.generator6Button.Click += new System.EventHandler(this.generator6Button_Click);
            // 
            // generator5Button
            // 
            this.generator5Button.BackColor = System.Drawing.Color.LightGray;
            this.generator5Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generator5Button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.generator5Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.generator5Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.generator5Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generator5Button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.generator5Button.Location = new System.Drawing.Point(3, 474);
            this.generator5Button.Name = "generator5Button";
            this.generator5Button.Size = new System.Drawing.Size(163, 45);
            this.generator5Button.TabIndex = 28;
            this.generator5Button.Text = "Правый глаз";
            this.generator5Button.UseVisualStyleBackColor = false;
            this.generator5Button.Click += new System.EventHandler(this.generator5Button_Click);
            // 
            // generator4Button
            // 
            this.generator4Button.BackColor = System.Drawing.Color.LightGray;
            this.generator4Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generator4Button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.generator4Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.generator4Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.generator4Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generator4Button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.generator4Button.Location = new System.Drawing.Point(172, 419);
            this.generator4Button.Name = "generator4Button";
            this.generator4Button.Size = new System.Drawing.Size(164, 49);
            this.generator4Button.TabIndex = 27;
            this.generator4Button.Text = "Правое крыло";
            this.generator4Button.UseVisualStyleBackColor = false;
            this.generator4Button.Click += new System.EventHandler(this.generator4Button_Click);
            // 
            // generator3Button
            // 
            this.generator3Button.BackColor = System.Drawing.Color.LightGray;
            this.generator3Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generator3Button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.generator3Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.generator3Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.generator3Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generator3Button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.generator3Button.Location = new System.Drawing.Point(3, 419);
            this.generator3Button.Name = "generator3Button";
            this.generator3Button.Size = new System.Drawing.Size(163, 49);
            this.generator3Button.TabIndex = 26;
            this.generator3Button.Text = "Левое крыло";
            this.generator3Button.UseVisualStyleBackColor = false;
            this.generator3Button.Click += new System.EventHandler(this.generator3Button_Click);
            // 
            // generator2Button
            // 
            this.generator2Button.BackColor = System.Drawing.Color.LightGray;
            this.generator2Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generator2Button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.generator2Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.generator2Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.generator2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generator2Button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.generator2Button.Location = new System.Drawing.Point(172, 365);
            this.generator2Button.Name = "generator2Button";
            this.generator2Button.Size = new System.Drawing.Size(164, 48);
            this.generator2Button.TabIndex = 25;
            this.generator2Button.Text = "Точка";
            this.generator2Button.UseVisualStyleBackColor = false;
            this.generator2Button.Click += new System.EventHandler(this.generator2Button_Click);
            // 
            // spreadingBar
            // 
            this.spreadingBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.spreadingBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spreadingBar.Location = new System.Drawing.Point(172, 267);
            this.spreadingBar.Name = "spreadingBar";
            this.spreadingBar.Size = new System.Drawing.Size(164, 55);
            this.spreadingBar.TabIndex = 22;
            this.spreadingBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.spreadingBar.Scroll += new System.EventHandler(this.spreadingBar_Scroll);
            // 
            // directionBar
            // 
            this.directionBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.directionBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.directionBar.Location = new System.Drawing.Point(172, 199);
            this.directionBar.Name = "directionBar";
            this.directionBar.Size = new System.Drawing.Size(164, 62);
            this.directionBar.TabIndex = 21;
            this.directionBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.directionBar.Scroll += new System.EventHandler(this.directionBar_Scroll);
            // 
            // speedBar
            // 
            this.speedBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.speedBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.speedBar.Location = new System.Drawing.Point(172, 135);
            this.speedBar.Name = "speedBar";
            this.speedBar.Size = new System.Drawing.Size(164, 58);
            this.speedBar.TabIndex = 20;
            this.speedBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.speedBar.Scroll += new System.EventHandler(this.speedBar_Scroll);
            // 
            // healthBar
            // 
            this.healthBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.healthBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.healthBar.Location = new System.Drawing.Point(172, 66);
            this.healthBar.Name = "healthBar";
            this.healthBar.Size = new System.Drawing.Size(164, 63);
            this.healthBar.TabIndex = 19;
            this.healthBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.healthBar.Scroll += new System.EventHandler(this.healthBar_Scroll);
            // 
            // radiusLabel
            // 
            this.radiusLabel.AutoSize = true;
            this.radiusLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radiusLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radiusLabel.Location = new System.Drawing.Point(3, 0);
            this.radiusLabel.Name = "radiusLabel";
            this.radiusLabel.Size = new System.Drawing.Size(163, 63);
            this.radiusLabel.TabIndex = 17;
            this.radiusLabel.Text = "Радиус";
            this.radiusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // healthLabel
            // 
            this.healthLabel.AutoSize = true;
            this.healthLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.healthLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.healthLabel.Location = new System.Drawing.Point(3, 63);
            this.healthLabel.Name = "healthLabel";
            this.healthLabel.Size = new System.Drawing.Size(163, 69);
            this.healthLabel.TabIndex = 17;
            this.healthLabel.Text = "Жизнь";
            this.healthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.speedLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.speedLabel.Location = new System.Drawing.Point(3, 132);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(163, 64);
            this.speedLabel.TabIndex = 17;
            this.speedLabel.Text = "Скорость";
            this.speedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // directionLabel
            // 
            this.directionLabel.AutoSize = true;
            this.directionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.directionLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.directionLabel.Location = new System.Drawing.Point(3, 196);
            this.directionLabel.Name = "directionLabel";
            this.directionLabel.Size = new System.Drawing.Size(163, 68);
            this.directionLabel.TabIndex = 17;
            this.directionLabel.Text = "Направление";
            this.directionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // spreadingLabel
            // 
            this.spreadingLabel.AutoSize = true;
            this.spreadingLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spreadingLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spreadingLabel.Location = new System.Drawing.Point(3, 264);
            this.spreadingLabel.Name = "spreadingLabel";
            this.spreadingLabel.Size = new System.Drawing.Size(163, 61);
            this.spreadingLabel.TabIndex = 17;
            this.spreadingLabel.Text = "Разброс";
            this.spreadingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frequencyLabel
            // 
            this.frequencyLabel.AutoSize = true;
            this.frequencyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frequencyLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.frequencyLabel.Location = new System.Drawing.Point(3, 325);
            this.frequencyLabel.Name = "frequencyLabel";
            this.frequencyLabel.Size = new System.Drawing.Size(163, 37);
            this.frequencyLabel.TabIndex = 17;
            this.frequencyLabel.Text = "Частота";
            this.frequencyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radiusBar
            // 
            this.radiusBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radiusBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radiusBar.Location = new System.Drawing.Point(172, 3);
            this.radiusBar.Name = "radiusBar";
            this.radiusBar.Size = new System.Drawing.Size(164, 57);
            this.radiusBar.TabIndex = 18;
            this.radiusBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.radiusBar.Scroll += new System.EventHandler(this.radiusBar_Scroll);
            // 
            // frequencyField
            // 
            this.frequencyField.BackColor = System.Drawing.Color.LightGray;
            this.frequencyField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frequencyField.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.frequencyField.Location = new System.Drawing.Point(172, 328);
            this.frequencyField.Name = "frequencyField";
            this.frequencyField.Size = new System.Drawing.Size(164, 30);
            this.frequencyField.TabIndex = 23;
            // 
            // generator1Button
            // 
            this.generator1Button.BackColor = System.Drawing.Color.LightGray;
            this.generator1Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generator1Button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.generator1Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.generator1Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.generator1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generator1Button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.generator1Button.Location = new System.Drawing.Point(3, 365);
            this.generator1Button.Name = "generator1Button";
            this.generator1Button.Size = new System.Drawing.Size(163, 48);
            this.generator1Button.TabIndex = 24;
            this.generator1Button.Text = "Окружность";
            this.generator1Button.UseVisualStyleBackColor = false;
            this.generator1Button.Click += new System.EventHandler(this.generator1Button_Click);
            // 
            // time
            // 
            this.time.Enabled = true;
            this.time.Interval = 30;
            this.time.Tick += new System.EventHandler(this.time_Tick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.tableLayoutPanel1);
            this.KeyPreview = true;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Particle System Simulation";
            this.TopMost = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainWindow_KeyDown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewPort)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spreadingBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.directionBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.healthBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiusBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox viewPort;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Timer time;
        private System.Windows.Forms.Label particlesAmountValue;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button blueColorButton;
        private System.Windows.Forms.Button pinkColorButton;
        private System.Windows.Forms.Button greenColorButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button yellowColorButton;
        private System.Windows.Forms.Button orangeColorButton;
        private System.Windows.Forms.Button redColorButton;
        private System.Windows.Forms.Label startColorLabel;
        private System.Windows.Forms.Label endColorLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button generator6Button;
        private System.Windows.Forms.Button generator5Button;
        private System.Windows.Forms.Button generator4Button;
        private System.Windows.Forms.Button generator3Button;
        private System.Windows.Forms.Button generator2Button;
        private System.Windows.Forms.TrackBar spreadingBar;
        private System.Windows.Forms.TrackBar directionBar;
        private System.Windows.Forms.TrackBar speedBar;
        private System.Windows.Forms.TrackBar healthBar;
        private System.Windows.Forms.Label radiusLabel;
        private System.Windows.Forms.Label healthLabel;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.Label directionLabel;
        private System.Windows.Forms.Label spreadingLabel;
        private System.Windows.Forms.Label frequencyLabel;
        private System.Windows.Forms.TrackBar radiusBar;
        private System.Windows.Forms.TextBox frequencyField;
        private System.Windows.Forms.Button generator1Button;
    }
}