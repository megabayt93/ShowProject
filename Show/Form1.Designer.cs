namespace Show
{
    partial class ShowMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowMain));
            this.pharmaPic = new System.Windows.Forms.PictureBox();
            this.Cpu = new System.Windows.Forms.GroupBox();
            this.cpuUsageInfo = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cpuTemperatureInfo = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cpuGhzInfo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cpuModelInfo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cpuManufacturerInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hdd = new System.Windows.Forms.GroupBox();
            this.hddUsageInfo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hddTemperatureInfo = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.hddSizeInfo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.hddManufacturerInfo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ram = new System.Windows.Forms.GroupBox();
            this.ramUsageInfo = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ramTemperatureInfo = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ramSizeInfo = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.graphic = new System.Windows.Forms.GroupBox();
            this.gpuTemperatureInfo = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.gpuFamilyInfo = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.gpuVramInfo = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.gpuManufacturerInfo = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mainBoardTemperatureInfo = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.mainboardInfo = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.tmrInfo = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pharmaPic)).BeginInit();
            this.Cpu.SuspendLayout();
            this.hdd.SuspendLayout();
            this.ram.SuspendLayout();
            this.graphic.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pharmaPic
            // 
            this.pharmaPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pharmaPic.Image = global::Show.Properties.Resources.yatech;
            this.pharmaPic.Location = new System.Drawing.Point(588, 18);
            this.pharmaPic.Name = "pharmaPic";
            this.pharmaPic.Size = new System.Drawing.Size(63, 64);
            this.pharmaPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pharmaPic.TabIndex = 0;
            this.pharmaPic.TabStop = false;
            this.pharmaPic.Click += new System.EventHandler(this.pharmaPic_Click);
            // 
            // Cpu
            // 
            this.Cpu.Controls.Add(this.cpuUsageInfo);
            this.Cpu.Controls.Add(this.label14);
            this.Cpu.Controls.Add(this.cpuTemperatureInfo);
            this.Cpu.Controls.Add(this.label8);
            this.Cpu.Controls.Add(this.cpuGhzInfo);
            this.Cpu.Controls.Add(this.label4);
            this.Cpu.Controls.Add(this.cpuModelInfo);
            this.Cpu.Controls.Add(this.label3);
            this.Cpu.Controls.Add(this.cpuManufacturerInfo);
            this.Cpu.Controls.Add(this.label1);
            this.Cpu.Location = new System.Drawing.Point(12, 12);
            this.Cpu.Name = "Cpu";
            this.Cpu.Size = new System.Drawing.Size(311, 176);
            this.Cpu.TabIndex = 2;
            this.Cpu.TabStop = false;
            this.Cpu.Text = "CPU";
            // 
            // cpuUsageInfo
            // 
            this.cpuUsageInfo.AutoSize = true;
            this.cpuUsageInfo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuUsageInfo.Location = new System.Drawing.Point(112, 145);
            this.cpuUsageInfo.Name = "cpuUsageInfo";
            this.cpuUsageInfo.Size = new System.Drawing.Size(97, 17);
            this.cpuUsageInfo.TabIndex = 14;
            this.cpuUsageInfo.Text = "cpuUsageInfo";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(7, 145);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 17);
            this.label14.TabIndex = 13;
            this.label14.Text = "Usage:";
            // 
            // cpuTemperatureInfo
            // 
            this.cpuTemperatureInfo.AutoSize = true;
            this.cpuTemperatureInfo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuTemperatureInfo.Location = new System.Drawing.Point(112, 115);
            this.cpuTemperatureInfo.Name = "cpuTemperatureInfo";
            this.cpuTemperatureInfo.Size = new System.Drawing.Size(137, 17);
            this.cpuTemperatureInfo.TabIndex = 12;
            this.cpuTemperatureInfo.Text = "cpuTemperatureInfo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(0, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Temperature:";
            // 
            // cpuGhzInfo
            // 
            this.cpuGhzInfo.AutoSize = true;
            this.cpuGhzInfo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuGhzInfo.Location = new System.Drawing.Point(112, 88);
            this.cpuGhzInfo.Name = "cpuGhzInfo";
            this.cpuGhzInfo.Size = new System.Drawing.Size(82, 17);
            this.cpuGhzInfo.TabIndex = 8;
            this.cpuGhzInfo.Text = "cpuGhzInfo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ghz:";
            // 
            // cpuModelInfo
            // 
            this.cpuModelInfo.AutoSize = true;
            this.cpuModelInfo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuModelInfo.Location = new System.Drawing.Point(112, 59);
            this.cpuModelInfo.Name = "cpuModelInfo";
            this.cpuModelInfo.Size = new System.Drawing.Size(93, 17);
            this.cpuModelInfo.TabIndex = 6;
            this.cpuModelInfo.Text = "cpuModelInfo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Model:";
            // 
            // cpuManufacturerInfo
            // 
            this.cpuManufacturerInfo.AutoSize = true;
            this.cpuManufacturerInfo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuManufacturerInfo.Location = new System.Drawing.Point(112, 27);
            this.cpuManufacturerInfo.Name = "cpuManufacturerInfo";
            this.cpuManufacturerInfo.Size = new System.Drawing.Size(140, 17);
            this.cpuManufacturerInfo.TabIndex = 4;
            this.cpuManufacturerInfo.Text = "cpuManufacturerInfo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Manufacturer:";
            // 
            // hdd
            // 
            this.hdd.Controls.Add(this.hddUsageInfo);
            this.hdd.Controls.Add(this.label2);
            this.hdd.Controls.Add(this.hddTemperatureInfo);
            this.hdd.Controls.Add(this.label7);
            this.hdd.Controls.Add(this.hddSizeInfo);
            this.hdd.Controls.Add(this.label6);
            this.hdd.Controls.Add(this.hddManufacturerInfo);
            this.hdd.Controls.Add(this.label5);
            this.hdd.Location = new System.Drawing.Point(13, 210);
            this.hdd.Name = "hdd";
            this.hdd.Size = new System.Drawing.Size(310, 132);
            this.hdd.TabIndex = 3;
            this.hdd.TabStop = false;
            this.hdd.Text = "HDD";
            // 
            // hddUsageInfo
            // 
            this.hddUsageInfo.AutoSize = true;
            this.hddUsageInfo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hddUsageInfo.Location = new System.Drawing.Point(109, 106);
            this.hddUsageInfo.Name = "hddUsageInfo";
            this.hddUsageInfo.Size = new System.Drawing.Size(97, 17);
            this.hddUsageInfo.TabIndex = 12;
            this.hddUsageInfo.Text = "hddUsageInfo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Usage:";
            // 
            // hddTemperatureInfo
            // 
            this.hddTemperatureInfo.AutoSize = true;
            this.hddTemperatureInfo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hddTemperatureInfo.Location = new System.Drawing.Point(109, 81);
            this.hddTemperatureInfo.Name = "hddTemperatureInfo";
            this.hddTemperatureInfo.Size = new System.Drawing.Size(137, 17);
            this.hddTemperatureInfo.TabIndex = 10;
            this.hddTemperatureInfo.Text = "hddTemperatureInfo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Temperature:";
            // 
            // hddSizeInfo
            // 
            this.hddSizeInfo.AutoSize = true;
            this.hddSizeInfo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hddSizeInfo.Location = new System.Drawing.Point(108, 53);
            this.hddSizeInfo.Name = "hddSizeInfo";
            this.hddSizeInfo.Size = new System.Drawing.Size(84, 17);
            this.hddSizeInfo.TabIndex = 8;
            this.hddSizeInfo.Text = "hddSizeInfo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Size:";
            // 
            // hddManufacturerInfo
            // 
            this.hddManufacturerInfo.AutoSize = true;
            this.hddManufacturerInfo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hddManufacturerInfo.Location = new System.Drawing.Point(108, 27);
            this.hddManufacturerInfo.Name = "hddManufacturerInfo";
            this.hddManufacturerInfo.Size = new System.Drawing.Size(140, 17);
            this.hddManufacturerInfo.TabIndex = 6;
            this.hddManufacturerInfo.Text = "hddManufacturerInfo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Manufacturer:";
            // 
            // ram
            // 
            this.ram.Controls.Add(this.ramUsageInfo);
            this.ram.Controls.Add(this.label13);
            this.ram.Controls.Add(this.ramTemperatureInfo);
            this.ram.Controls.Add(this.label9);
            this.ram.Controls.Add(this.ramSizeInfo);
            this.ram.Controls.Add(this.label11);
            this.ram.Location = new System.Drawing.Point(329, 12);
            this.ram.Name = "ram";
            this.ram.Size = new System.Drawing.Size(253, 114);
            this.ram.TabIndex = 4;
            this.ram.TabStop = false;
            this.ram.Text = "RAM";
            // 
            // ramUsageInfo
            // 
            this.ramUsageInfo.AutoSize = true;
            this.ramUsageInfo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ramUsageInfo.Location = new System.Drawing.Point(65, 27);
            this.ramUsageInfo.Name = "ramUsageInfo";
            this.ramUsageInfo.Size = new System.Drawing.Size(99, 17);
            this.ramUsageInfo.TabIndex = 12;
            this.ramUsageInfo.Text = "ramUsageInfo";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 17);
            this.label13.TabIndex = 11;
            this.label13.Text = "Usage:";
            // 
            // ramTemperatureInfo
            // 
            this.ramTemperatureInfo.AutoSize = true;
            this.ramTemperatureInfo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ramTemperatureInfo.Location = new System.Drawing.Point(109, 81);
            this.ramTemperatureInfo.Name = "ramTemperatureInfo";
            this.ramTemperatureInfo.Size = new System.Drawing.Size(139, 17);
            this.ramTemperatureInfo.TabIndex = 10;
            this.ramTemperatureInfo.Text = "ramTemperatureInfo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "Temperature:";
            // 
            // ramSizeInfo
            // 
            this.ramSizeInfo.AutoSize = true;
            this.ramSizeInfo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ramSizeInfo.Location = new System.Drawing.Point(108, 53);
            this.ramSizeInfo.Name = "ramSizeInfo";
            this.ramSizeInfo.Size = new System.Drawing.Size(86, 17);
            this.ramSizeInfo.TabIndex = 8;
            this.ramSizeInfo.Text = "ramSizeInfo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(5, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 17);
            this.label11.TabIndex = 7;
            this.label11.Text = "Size:";
            // 
            // graphic
            // 
            this.graphic.Controls.Add(this.gpuTemperatureInfo);
            this.graphic.Controls.Add(this.label18);
            this.graphic.Controls.Add(this.gpuFamilyInfo);
            this.graphic.Controls.Add(this.label20);
            this.graphic.Controls.Add(this.gpuVramInfo);
            this.graphic.Controls.Add(this.label22);
            this.graphic.Controls.Add(this.gpuManufacturerInfo);
            this.graphic.Controls.Add(this.label24);
            this.graphic.Location = new System.Drawing.Point(329, 147);
            this.graphic.Name = "graphic";
            this.graphic.Size = new System.Drawing.Size(322, 195);
            this.graphic.TabIndex = 5;
            this.graphic.TabStop = false;
            this.graphic.Text = "GPU";
            // 
            // gpuTemperatureInfo
            // 
            this.gpuTemperatureInfo.AutoSize = true;
            this.gpuTemperatureInfo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpuTemperatureInfo.Location = new System.Drawing.Point(102, 115);
            this.gpuTemperatureInfo.Name = "gpuTemperatureInfo";
            this.gpuTemperatureInfo.Size = new System.Drawing.Size(137, 17);
            this.gpuTemperatureInfo.TabIndex = 12;
            this.gpuTemperatureInfo.Text = "gpuTemperatureInfo";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(6, 115);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(94, 17);
            this.label18.TabIndex = 11;
            this.label18.Text = "Temperature:";
            // 
            // gpuFamilyInfo
            // 
            this.gpuFamilyInfo.AutoSize = true;
            this.gpuFamilyInfo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpuFamilyInfo.Location = new System.Drawing.Point(103, 88);
            this.gpuFamilyInfo.Name = "gpuFamilyInfo";
            this.gpuFamilyInfo.Size = new System.Drawing.Size(98, 17);
            this.gpuFamilyInfo.TabIndex = 8;
            this.gpuFamilyInfo.Text = "gpuFamilyInfo";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(6, 88);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(55, 17);
            this.label20.TabIndex = 7;
            this.label20.Text = "Family:";
            // 
            // gpuVramInfo
            // 
            this.gpuVramInfo.AutoSize = true;
            this.gpuVramInfo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpuVramInfo.Location = new System.Drawing.Point(102, 59);
            this.gpuVramInfo.Name = "gpuVramInfo";
            this.gpuVramInfo.Size = new System.Drawing.Size(89, 17);
            this.gpuVramInfo.TabIndex = 6;
            this.gpuVramInfo.Text = "gpuVramInfo";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(6, 59);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(52, 17);
            this.label22.TabIndex = 5;
            this.label22.Text = "VRAM:";
            // 
            // gpuManufacturerInfo
            // 
            this.gpuManufacturerInfo.AutoSize = true;
            this.gpuManufacturerInfo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpuManufacturerInfo.Location = new System.Drawing.Point(102, 27);
            this.gpuManufacturerInfo.Name = "gpuManufacturerInfo";
            this.gpuManufacturerInfo.Size = new System.Drawing.Size(140, 17);
            this.gpuManufacturerInfo.TabIndex = 4;
            this.gpuManufacturerInfo.Text = "gpuManufacturerInfo";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(6, 27);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(97, 17);
            this.label24.TabIndex = 3;
            this.label24.Text = "Manufacturer:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mainBoardTemperatureInfo);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.mainboardInfo);
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Location = new System.Drawing.Point(13, 348);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(638, 47);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MAINBOARD";
            // 
            // mainBoardTemperatureInfo
            // 
            this.mainBoardTemperatureInfo.AutoSize = true;
            this.mainBoardTemperatureInfo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainBoardTemperatureInfo.Location = new System.Drawing.Point(567, 21);
            this.mainBoardTemperatureInfo.Name = "mainBoardTemperatureInfo";
            this.mainBoardTemperatureInfo.Size = new System.Drawing.Size(41, 17);
            this.mainBoardTemperatureInfo.TabIndex = 10;
            this.mainBoardTemperatureInfo.Text = "MBTI";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(394, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(167, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "MainBoard Temperature:";
            // 
            // mainboardInfo
            // 
            this.mainboardInfo.AutoSize = true;
            this.mainboardInfo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainboardInfo.Location = new System.Drawing.Point(108, 21);
            this.mainboardInfo.Name = "mainboardInfo";
            this.mainboardInfo.Size = new System.Drawing.Size(100, 17);
            this.mainboardInfo.TabIndex = 8;
            this.mainboardInfo.Text = "mainboardInfo";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(5, 21);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(97, 17);
            this.label26.TabIndex = 7;
            this.label26.Text = "Manufacturer:";
            // 
            // tmrInfo
            // 
            this.tmrInfo.Enabled = true;
            this.tmrInfo.Interval = 800;
            this.tmrInfo.Tick += new System.EventHandler(this.tmrInfo_Tick);
            // 
            // ShowMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(663, 400);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.graphic);
            this.Controls.Add(this.ram);
            this.Controls.Add(this.hdd);
            this.Controls.Add(this.Cpu);
            this.Controls.Add(this.pharmaPic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ShowMain";
            this.Text = "SHOW";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ShowMain_FormClosing);
            this.Load += new System.EventHandler(this.ShowMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pharmaPic)).EndInit();
            this.Cpu.ResumeLayout(false);
            this.Cpu.PerformLayout();
            this.hdd.ResumeLayout(false);
            this.hdd.PerformLayout();
            this.ram.ResumeLayout(false);
            this.ram.PerformLayout();
            this.graphic.ResumeLayout(false);
            this.graphic.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pharmaPic;
        private System.Windows.Forms.GroupBox Cpu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cpuGhzInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label cpuModelInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label cpuManufacturerInfo;
        private System.Windows.Forms.GroupBox hdd;
        private System.Windows.Forms.Label hddManufacturerInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label cpuTemperatureInfo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label hddTemperatureInfo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label hddSizeInfo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label cpuUsageInfo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox ram;
        private System.Windows.Forms.Label ramUsageInfo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label ramTemperatureInfo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label ramSizeInfo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox graphic;
        private System.Windows.Forms.Label gpuTemperatureInfo;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label gpuFamilyInfo;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label gpuVramInfo;
        private System.Windows.Forms.Label gpuManufacturerInfo;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label mainboardInfo;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Timer tmrInfo;
        private System.Windows.Forms.Label hddUsageInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label mainBoardTemperatureInfo;
        private System.Windows.Forms.Label label10;
    }
}

