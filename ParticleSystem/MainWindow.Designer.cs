
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
            this.greenColorButton = new System.Windows.Forms.Button();
            this.pinkColorButton = new System.Windows.Forms.Button();
            this.blueColorButton = new System.Windows.Forms.Button();
            this.yellowColorButton = new System.Windows.Forms.Button();
            this.orangeColorButton = new System.Windows.Forms.Button();
            this.startColorLabel = new System.Windows.Forms.Label();
            this.endColorLabel = new System.Windows.Forms.Label();
            this.redColorButton = new System.Windows.Forms.Button();
            this.time = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewPort)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.2116F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.7884F));
            this.tableLayoutPanel1.Controls.Add(this.viewPort, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.03677F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.96323F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1182, 853);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // viewPort
            // 
            this.viewPort.BackColor = System.Drawing.Color.Black;
            this.viewPort.Location = new System.Drawing.Point(197, 8);
            this.viewPort.Name = "viewPort";
            this.viewPort.Size = new System.Drawing.Size(977, 694);
            this.viewPort.TabIndex = 0;
            this.viewPort.TabStop = false;
            this.viewPort.MouseMove += new System.Windows.Forms.MouseEventHandler(this.viewPort_MouseMove);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.27586F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.72414F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 383F));
            this.tableLayoutPanel2.Controls.Add(this.greenColorButton, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.pinkColorButton, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.blueColorButton, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.yellowColorButton, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.orangeColorButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.startColorLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.endColorLabel, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.redColorButton, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(197, 708);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(977, 137);
            this.tableLayoutPanel2.TabIndex = 1;
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
            this.greenColorButton.Location = new System.Drawing.Point(494, 8);
            this.greenColorButton.Name = "greenColorButton";
            this.greenColorButton.Size = new System.Drawing.Size(91, 63);
            this.greenColorButton.TabIndex = 7;
            this.greenColorButton.UseVisualStyleBackColor = false;
            this.greenColorButton.Click += new System.EventHandler(this.greenColorButton_Click);
            this.greenColorButton.MouseLeave += new System.EventHandler(this.greenColorButton_MouseLeave);
            this.greenColorButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.greenColorButton_MouseMove);
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
            this.pinkColorButton.Location = new System.Drawing.Point(396, 8);
            this.pinkColorButton.Name = "pinkColorButton";
            this.pinkColorButton.Size = new System.Drawing.Size(92, 63);
            this.pinkColorButton.TabIndex = 6;
            this.pinkColorButton.UseVisualStyleBackColor = false;
            this.pinkColorButton.Click += new System.EventHandler(this.pinkColorButton_Click);
            this.pinkColorButton.MouseLeave += new System.EventHandler(this.pinkColorButton_MouseLeave);
            this.pinkColorButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pinkColorButton_MouseMove);
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
            this.blueColorButton.Location = new System.Drawing.Point(302, 8);
            this.blueColorButton.Name = "blueColorButton";
            this.blueColorButton.Size = new System.Drawing.Size(88, 63);
            this.blueColorButton.TabIndex = 5;
            this.blueColorButton.UseVisualStyleBackColor = false;
            this.blueColorButton.Click += new System.EventHandler(this.blueColorButton_Click);
            this.blueColorButton.MouseLeave += new System.EventHandler(this.blueColorButton_MouseLeave);
            this.blueColorButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.blueColorButton_MouseMove);
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
            this.yellowColorButton.Location = new System.Drawing.Point(201, 8);
            this.yellowColorButton.Name = "yellowColorButton";
            this.yellowColorButton.Size = new System.Drawing.Size(95, 63);
            this.yellowColorButton.TabIndex = 4;
            this.yellowColorButton.UseVisualStyleBackColor = false;
            this.yellowColorButton.Click += new System.EventHandler(this.yellowColorButton_Click);
            this.yellowColorButton.MouseLeave += new System.EventHandler(this.yellowColorButton_MouseLeave);
            this.yellowColorButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.yellowColorButton_MouseMove);
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
            this.orangeColorButton.Location = new System.Drawing.Point(101, 8);
            this.orangeColorButton.Name = "orangeColorButton";
            this.orangeColorButton.Size = new System.Drawing.Size(94, 63);
            this.orangeColorButton.TabIndex = 3;
            this.orangeColorButton.UseVisualStyleBackColor = false;
            this.orangeColorButton.Click += new System.EventHandler(this.orangeColorButton_Click);
            this.orangeColorButton.MouseLeave += new System.EventHandler(this.orangeColorButton_MouseLeave);
            this.orangeColorButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.orangeColorButton_MouseMove);
            // 
            // startColorLabel
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.startColorLabel, 3);
            this.startColorLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startColorLabel.Location = new System.Drawing.Point(8, 74);
            this.startColorLabel.Name = "startColorLabel";
            this.startColorLabel.Size = new System.Drawing.Size(288, 58);
            this.startColorLabel.TabIndex = 1;
            this.startColorLabel.Text = "Начальный цвет частиц";
            this.startColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // endColorLabel
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.endColorLabel, 3);
            this.endColorLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endColorLabel.Location = new System.Drawing.Point(302, 74);
            this.endColorLabel.Name = "endColorLabel";
            this.endColorLabel.Size = new System.Drawing.Size(283, 58);
            this.endColorLabel.TabIndex = 1;
            this.endColorLabel.Text = "Конечный цвет частиц";
            this.endColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.redColorButton.Location = new System.Drawing.Point(8, 8);
            this.redColorButton.Name = "redColorButton";
            this.redColorButton.Size = new System.Drawing.Size(87, 63);
            this.redColorButton.TabIndex = 2;
            this.redColorButton.UseVisualStyleBackColor = false;
            this.redColorButton.Click += new System.EventHandler(this.redColorButton_Click);
            this.redColorButton.MouseLeave += new System.EventHandler(this.redColorButton_MouseLeave);
            this.redColorButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.redColorButton_MouseMove);
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
            this.ClientSize = new System.Drawing.Size(1182, 853);
            this.Controls.Add(this.tableLayoutPanel1);
            this.KeyPreview = true;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Particle System Simulation";
            this.TopMost = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainWindow_KeyDown);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.viewPort)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox viewPort;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Timer time;
        private System.Windows.Forms.Button greenColorButton;
        private System.Windows.Forms.Button pinkColorButton;
        private System.Windows.Forms.Button blueColorButton;
        private System.Windows.Forms.Button yellowColorButton;
        private System.Windows.Forms.Button orangeColorButton;
        private System.Windows.Forms.Label startColorLabel;
        private System.Windows.Forms.Label endColorLabel;
        private System.Windows.Forms.Button redColorButton;
    }
}