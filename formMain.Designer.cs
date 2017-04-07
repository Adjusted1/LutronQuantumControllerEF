namespace SkyWallGUI
{
    partial class formMain
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabBatleth = new System.Windows.Forms.TabPage();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnCollection = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridViewReadings = new System.Windows.Forms.DataGridView();
            this.sensorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.readingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sensorReadingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnMove = new System.Windows.Forms.Button();
            this.aGauge1 = new System.Windows.Forms.AGauge();
            this.tabSkyWall = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar5 = new System.Windows.Forms.TrackBar();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.btnDemo3 = new System.Windows.Forms.Button();
            this.btnDemo2 = new System.Windows.Forms.Button();
            this.btnWallOn = new System.Windows.Forms.Button();
            this.btnWallOff = new System.Windows.Forms.Button();
            this.btnFlash = new System.Windows.Forms.Button();
            this.cboFixture = new System.Windows.Forms.ComboBox();
            this.btnDemo = new System.Windows.Forms.Button();
            this.timerSensors = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabBatleth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReadings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensorReadingBindingSource)).BeginInit();
            this.tabSkyWall.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabBatleth);
            this.tabControl.Controls.Add(this.tabSkyWall);
            this.tabControl.Location = new System.Drawing.Point(16, 15);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1101, 398);
            this.tabControl.TabIndex = 0;
            // 
            // tabBatleth
            // 
            this.tabBatleth.Controls.Add(this.btnExport);
            this.tabBatleth.Controls.Add(this.btnPause);
            this.tabBatleth.Controls.Add(this.btnCollection);
            this.tabBatleth.Controls.Add(this.textBox1);
            this.tabBatleth.Controls.Add(this.dataGridViewReadings);
            this.tabBatleth.Controls.Add(this.btnMove);
            this.tabBatleth.Controls.Add(this.aGauge1);
            this.tabBatleth.Location = new System.Drawing.Point(4, 25);
            this.tabBatleth.Margin = new System.Windows.Forms.Padding(4);
            this.tabBatleth.Name = "tabBatleth";
            this.tabBatleth.Padding = new System.Windows.Forms.Padding(4);
            this.tabBatleth.Size = new System.Drawing.Size(1093, 369);
            this.tabBatleth.TabIndex = 0;
            this.tabBatleth.Text = "Batleth";
            this.tabBatleth.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(720, 417);
            this.btnExport.Margin = new System.Windows.Forms.Padding(4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(219, 28);
            this.btnExport.TabIndex = 6;
            this.btnExport.Text = "Export Data";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(392, 7);
            this.btnPause.Margin = new System.Windows.Forms.Padding(4);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(100, 28);
            this.btnPause.TabIndex = 5;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnCollection
            // 
            this.btnCollection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCollection.Location = new System.Drawing.Point(805, 294);
            this.btnCollection.Margin = new System.Windows.Forms.Padding(4);
            this.btnCollection.Name = "btnCollection";
            this.btnCollection.Size = new System.Drawing.Size(219, 28);
            this.btnCollection.TabIndex = 4;
            this.btnCollection.Text = "Collect Data";
            this.btnCollection.UseVisualStyleBackColor = true;
            this.btnCollection.Click += new System.EventHandler(this.btnCollection_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(764, 158);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 3;
            // 
            // dataGridViewReadings
            // 
            this.dataGridViewReadings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewReadings.AutoGenerateColumns = false;
            this.dataGridViewReadings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReadings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sensorDataGridViewTextBoxColumn,
            this.readingDataGridViewTextBoxColumn});
            this.dataGridViewReadings.DataSource = this.sensorReadingBindingSource;
            this.dataGridViewReadings.Location = new System.Drawing.Point(8, 7);
            this.dataGridViewReadings.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewReadings.Name = "dataGridViewReadings";
            this.dataGridViewReadings.Size = new System.Drawing.Size(461, 351);
            this.dataGridViewReadings.TabIndex = 2;
            // 
            // sensorDataGridViewTextBoxColumn
            // 
            this.sensorDataGridViewTextBoxColumn.DataPropertyName = "sensor";
            this.sensorDataGridViewTextBoxColumn.HeaderText = "Sensor";
            this.sensorDataGridViewTextBoxColumn.Name = "sensorDataGridViewTextBoxColumn";
            this.sensorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // readingDataGridViewTextBoxColumn
            // 
            this.readingDataGridViewTextBoxColumn.DataPropertyName = "reading";
            this.readingDataGridViewTextBoxColumn.HeaderText = "Reading (V)";
            this.readingDataGridViewTextBoxColumn.Name = "readingDataGridViewTextBoxColumn";
            this.readingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sensorReadingBindingSource
            // 
            this.sensorReadingBindingSource.DataSource = typeof(LutronControl.Models.SensorReading);
            // 
            // btnMove
            // 
            this.btnMove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMove.Location = new System.Drawing.Point(924, 155);
            this.btnMove.Margin = new System.Windows.Forms.Padding(4);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(100, 28);
            this.btnMove.TabIndex = 1;
            this.btnMove.Text = "Move";
            this.btnMove.UseVisualStyleBackColor = true;
            // 
            // aGauge1
            // 
            this.aGauge1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aGauge1.BackColor = System.Drawing.Color.White;
            this.aGauge1.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge1.BaseArcRadius = 80;
            this.aGauge1.BaseArcStart = 180;
            this.aGauge1.BaseArcSweep = 180;
            this.aGauge1.BaseArcWidth = 2;
            this.aGauge1.Center = new System.Drawing.Point(100, 100);
            this.aGauge1.Location = new System.Drawing.Point(751, 7);
            this.aGauge1.Margin = new System.Windows.Forms.Padding(4);
            this.aGauge1.MaxValue = 180F;
            this.aGauge1.MinValue = 0F;
            this.aGauge1.Name = "aGauge1";
            this.aGauge1.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Gray;
            this.aGauge1.NeedleColor2 = System.Drawing.Color.DimGray;
            this.aGauge1.NeedleRadius = 80;
            this.aGauge1.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.aGauge1.NeedleWidth = 2;
            this.aGauge1.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleLinesInterInnerRadius = 73;
            this.aGauge1.ScaleLinesInterOuterRadius = 80;
            this.aGauge1.ScaleLinesInterWidth = 1;
            this.aGauge1.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleLinesMajorInnerRadius = 70;
            this.aGauge1.ScaleLinesMajorOuterRadius = 80;
            this.aGauge1.ScaleLinesMajorStepValue = 15F;
            this.aGauge1.ScaleLinesMajorWidth = 2;
            this.aGauge1.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGauge1.ScaleLinesMinorInnerRadius = 75;
            this.aGauge1.ScaleLinesMinorOuterRadius = 80;
            this.aGauge1.ScaleLinesMinorTicks = 4;
            this.aGauge1.ScaleLinesMinorWidth = 1;
            this.aGauge1.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleNumbersFormat = null;
            this.aGauge1.ScaleNumbersRadius = 95;
            this.aGauge1.ScaleNumbersRotation = 0;
            this.aGauge1.ScaleNumbersStartScaleLine = 0;
            this.aGauge1.ScaleNumbersStepScaleLines = 1;
            this.aGauge1.Size = new System.Drawing.Size(273, 140);
            this.aGauge1.TabIndex = 0;
            this.aGauge1.Text = "aGauge1";
            this.aGauge1.Value = 0F;
            // 
            // tabSkyWall
            // 
            this.tabSkyWall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabSkyWall.Controls.Add(this.button2);
            this.tabSkyWall.Controls.Add(this.label9);
            this.tabSkyWall.Controls.Add(this.textBox7);
            this.tabSkyWall.Controls.Add(this.textBox6);
            this.tabSkyWall.Controls.Add(this.textBox5);
            this.tabSkyWall.Controls.Add(this.textBox4);
            this.tabSkyWall.Controls.Add(this.textBox3);
            this.tabSkyWall.Controls.Add(this.label6);
            this.tabSkyWall.Controls.Add(this.label8);
            this.tabSkyWall.Controls.Add(this.textBox2);
            this.tabSkyWall.Controls.Add(this.button1);
            this.tabSkyWall.Controls.Add(this.label7);
            this.tabSkyWall.Controls.Add(this.label5);
            this.tabSkyWall.Controls.Add(this.label4);
            this.tabSkyWall.Controls.Add(this.label3);
            this.tabSkyWall.Controls.Add(this.label2);
            this.tabSkyWall.Controls.Add(this.label1);
            this.tabSkyWall.Controls.Add(this.trackBar5);
            this.tabSkyWall.Controls.Add(this.trackBar4);
            this.tabSkyWall.Controls.Add(this.trackBar3);
            this.tabSkyWall.Controls.Add(this.trackBar2);
            this.tabSkyWall.Controls.Add(this.trackBar1);
            this.tabSkyWall.Controls.Add(this.btnDemo3);
            this.tabSkyWall.Controls.Add(this.btnDemo2);
            this.tabSkyWall.Controls.Add(this.btnWallOn);
            this.tabSkyWall.Controls.Add(this.btnWallOff);
            this.tabSkyWall.Controls.Add(this.btnFlash);
            this.tabSkyWall.Controls.Add(this.cboFixture);
            this.tabSkyWall.Controls.Add(this.btnDemo);
            this.tabSkyWall.Location = new System.Drawing.Point(4, 25);
            this.tabSkyWall.Margin = new System.Windows.Forms.Padding(4);
            this.tabSkyWall.Name = "tabSkyWall";
            this.tabSkyWall.Padding = new System.Windows.Forms.Padding(4);
            this.tabSkyWall.Size = new System.Drawing.Size(1093, 369);
            this.tabSkyWall.TabIndex = 1;
            this.tabSkyWall.Text = "SkyWall";
            this.tabSkyWall.UseVisualStyleBackColor = true;
            this.tabSkyWall.Click += new System.EventHandler(this.tabSkyWall_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(931, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 17);
            this.label9.TabIndex = 28;
            this.label9.Text = "ms delay:";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(229, 241);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(39, 22);
            this.textBox7.TabIndex = 27;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(172, 241);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(39, 22);
            this.textBox6.TabIndex = 26;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(116, 241);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(39, 22);
            this.textBox5.TabIndex = 25;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(61, 241);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(39, 22);
            this.textBox4.TabIndex = 24;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(8, 241);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(39, 22);
            this.textBox3.TabIndex = 23;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Set Panel Levels";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(931, 209);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "20ms ~ 60s ramp";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(932, 168);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(151, 22);
            this.textBox2.TabIndex = 20;
            this.textBox2.Text = "20";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(932, 90);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 28);
            this.button1.TabIndex = 19;
            this.button1.Text = "Cloudy";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(644, 18);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 31);
            this.label7.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(240, 273);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "0%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(183, 273);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "0%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 273);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "0%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 273);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "0%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 273);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "0%";
            // 
            // trackBar5
            // 
            this.trackBar5.BackColor = System.Drawing.Color.Khaki;
            this.trackBar5.LargeChange = 0;
            this.trackBar5.Location = new System.Drawing.Point(280, 90);
            this.trackBar5.Margin = new System.Windows.Forms.Padding(4);
            this.trackBar5.Maximum = 100;
            this.trackBar5.Name = "trackBar5";
            this.trackBar5.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar5.Size = new System.Drawing.Size(56, 10);
            this.trackBar5.TabIndex = 11;
            this.trackBar5.TickFrequency = 10;
            this.trackBar5.Scroll += new System.EventHandler(this.trackBar5_Scroll);
            // 
            // trackBar4
            // 
            this.trackBar4.BackColor = System.Drawing.Color.Khaki;
            this.trackBar4.LargeChange = 0;
            this.trackBar4.Location = new System.Drawing.Point(212, 90);
            this.trackBar4.Margin = new System.Windows.Forms.Padding(4);
            this.trackBar4.Maximum = 100;
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar4.Size = new System.Drawing.Size(56, 10);
            this.trackBar4.TabIndex = 10;
            this.trackBar4.TickFrequency = 10;
            this.trackBar4.Scroll += new System.EventHandler(this.trackBar4_Scroll);
            // 
            // trackBar3
            // 
            this.trackBar3.BackColor = System.Drawing.Color.Khaki;
            this.trackBar3.LargeChange = 0;
            this.trackBar3.Location = new System.Drawing.Point(144, 90);
            this.trackBar3.Margin = new System.Windows.Forms.Padding(4);
            this.trackBar3.Maximum = 100;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar3.Size = new System.Drawing.Size(56, 10);
            this.trackBar3.TabIndex = 9;
            this.trackBar3.TickFrequency = 10;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.BackColor = System.Drawing.Color.Khaki;
            this.trackBar2.LargeChange = 0;
            this.trackBar2.Location = new System.Drawing.Point(76, 90);
            this.trackBar2.Margin = new System.Windows.Forms.Padding(4);
            this.trackBar2.Maximum = 100;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar2.Size = new System.Drawing.Size(56, 10);
            this.trackBar2.TabIndex = 8;
            this.trackBar2.TickFrequency = 10;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.Khaki;
            this.trackBar1.LargeChange = 0;
            this.trackBar1.Location = new System.Drawing.Point(8, 90);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(4);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(56, 10);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.TickFrequency = 10;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // btnDemo3
            // 
            this.btnDemo3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDemo3.Enabled = false;
            this.btnDemo3.Location = new System.Drawing.Point(771, 0);
            this.btnDemo3.Margin = new System.Windows.Forms.Padding(4);
            this.btnDemo3.Name = "btnDemo3";
            this.btnDemo3.Size = new System.Drawing.Size(13, 28);
            this.btnDemo3.TabIndex = 6;
            this.btnDemo3.Text = "do not use";
            this.btnDemo3.UseVisualStyleBackColor = false;
            this.btnDemo3.Visible = false;
            this.btnDemo3.Click += new System.EventHandler(this.btnDemo3_Click);
            // 
            // btnDemo2
            // 
            this.btnDemo2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDemo2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDemo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDemo2.ForeColor = System.Drawing.Color.Black;
            this.btnDemo2.Location = new System.Drawing.Point(932, 18);
            this.btnDemo2.Margin = new System.Windows.Forms.Padding(4);
            this.btnDemo2.Name = "btnDemo2";
            this.btnDemo2.Size = new System.Drawing.Size(151, 28);
            this.btnDemo2.TabIndex = 5;
            this.btnDemo2.Text = "Sunsrise";
            this.btnDemo2.UseVisualStyleBackColor = false;
            this.btnDemo2.Click += new System.EventHandler(this.btnDemo2_Click);
            // 
            // btnWallOn
            // 
            this.btnWallOn.BackColor = System.Drawing.Color.Transparent;
            this.btnWallOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWallOn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnWallOn.Location = new System.Drawing.Point(8, 18);
            this.btnWallOn.Margin = new System.Windows.Forms.Padding(4);
            this.btnWallOn.Name = "btnWallOn";
            this.btnWallOn.Size = new System.Drawing.Size(260, 28);
            this.btnWallOn.TabIndex = 4;
            this.btnWallOn.Text = "Wall On";
            this.btnWallOn.UseVisualStyleBackColor = false;
            this.btnWallOn.Click += new System.EventHandler(this.btnWallOn_Click);
            // 
            // btnWallOff
            // 
            this.btnWallOff.BackColor = System.Drawing.Color.Transparent;
            this.btnWallOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWallOff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnWallOff.Location = new System.Drawing.Point(8, 54);
            this.btnWallOff.Margin = new System.Windows.Forms.Padding(4);
            this.btnWallOff.Name = "btnWallOff";
            this.btnWallOff.Size = new System.Drawing.Size(260, 28);
            this.btnWallOff.TabIndex = 3;
            this.btnWallOff.Text = "Wall Off";
            this.btnWallOff.UseVisualStyleBackColor = false;
            this.btnWallOff.Click += new System.EventHandler(this.btnWallOff_Click);
            // 
            // btnFlash
            // 
            this.btnFlash.BackColor = System.Drawing.Color.Gainsboro;
            this.btnFlash.Enabled = false;
            this.btnFlash.Location = new System.Drawing.Point(728, 0);
            this.btnFlash.Margin = new System.Windows.Forms.Padding(4);
            this.btnFlash.Name = "btnFlash";
            this.btnFlash.Size = new System.Drawing.Size(13, 28);
            this.btnFlash.TabIndex = 2;
            this.btnFlash.Text = "do not use";
            this.btnFlash.UseVisualStyleBackColor = false;
            this.btnFlash.Visible = false;
            this.btnFlash.Click += new System.EventHandler(this.btnFlash_Click);
            // 
            // cboFixture
            // 
            this.cboFixture.FormattingEnabled = true;
            this.cboFixture.Location = new System.Drawing.Point(749, 0);
            this.cboFixture.Margin = new System.Windows.Forms.Padding(4);
            this.cboFixture.Name = "cboFixture";
            this.cboFixture.Size = new System.Drawing.Size(12, 24);
            this.cboFixture.TabIndex = 1;
            this.cboFixture.Visible = false;
            // 
            // btnDemo
            // 
            this.btnDemo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDemo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDemo.FlatAppearance.BorderSize = 0;
            this.btnDemo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDemo.ForeColor = System.Drawing.Color.Black;
            this.btnDemo.Location = new System.Drawing.Point(932, 54);
            this.btnDemo.Margin = new System.Windows.Forms.Padding(4);
            this.btnDemo.Name = "btnDemo";
            this.btnDemo.Size = new System.Drawing.Size(151, 28);
            this.btnDemo.TabIndex = 0;
            this.btnDemo.Text = "Sunset";
            this.btnDemo.UseVisualStyleBackColor = false;
            this.btnDemo.Click += new System.EventHandler(this.btnDemo_Click);
            // 
            // timerSensors
            // 
            this.timerSensors.Interval = 1000;
            this.timerSensors.Tick += new System.EventHandler(this.timerSensors_Tick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button2.Location = new System.Drawing.Point(848, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 100);
            this.button2.TabIndex = 29;
            this.button2.Text = "Toggle On/Off";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 427);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formMain";
            this.Text = "SkyWall GUI";
            this.tabControl.ResumeLayout(false);
            this.tabBatleth.ResumeLayout(false);
            this.tabBatleth.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReadings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensorReadingBindingSource)).EndInit();
            this.tabSkyWall.ResumeLayout(false);
            this.tabSkyWall.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabBatleth;
        private System.Windows.Forms.DataGridView dataGridViewReadings;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.AGauge aGauge1;
        private System.Windows.Forms.TabPage tabSkyWall;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnDemo;
        private System.Windows.Forms.Button btnFlash;
        private System.Windows.Forms.ComboBox cboFixture;
        private System.Windows.Forms.Button btnWallOn;
        private System.Windows.Forms.Button btnWallOff;
        private System.Windows.Forms.Button btnCollection;
        private System.Windows.Forms.Button btnDemo2;
        private System.Windows.Forms.Button btnDemo3;
        private System.Windows.Forms.Timer timerSensors;
        private System.Windows.Forms.BindingSource sensorReadingBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn sensorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn readingDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.TrackBar trackBar5;
        private System.Windows.Forms.TrackBar trackBar4;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
    }
}

