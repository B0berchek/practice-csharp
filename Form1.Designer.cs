namespace WinFormGladiator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tableLayoutFooter = new System.Windows.Forms.TableLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tableLayoutHeader = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutGladiator1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxName1 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonReady1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxWeapon1 = new System.Windows.Forms.ComboBox();
            this.comboBoxArmor1 = new System.Windows.Forms.ComboBox();
            this.tableLayoutGladiator2 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxName2 = new System.Windows.Forms.TextBox();
            this.buttonReady2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.comboBoxWeapon2 = new System.Windows.Forms.ComboBox();
            this.comboBoxArmor2 = new System.Windows.Forms.ComboBox();
            this.buttonStartFight = new System.Windows.Forms.Button();
            this.textBoxBattleLog = new System.Windows.Forms.TextBox();
            this.tableLayoutMiddle = new System.Windows.Forms.TableLayoutPanel();
            this.labelCountdown = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutFooter.SuspendLayout();
            this.tableLayoutHeader.SuspendLayout();
            this.tableLayoutMain.SuspendLayout();
            this.tableLayoutGladiator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tableLayoutGladiator2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.tableLayoutMiddle.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(1006, 3);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(246, 81);
            this.buttonExit.TabIndex = 8;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 81);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(242, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(758, 87);
            this.label10.TabIndex = 22;
            this.label10.Text = "Гладиаторский бой";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutFooter
            // 
            this.tableLayoutFooter.ColumnCount = 2;
            this.tableLayoutMain.SetColumnSpan(this.tableLayoutFooter, 3);
            this.tableLayoutFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            this.tableLayoutFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableLayoutFooter.Controls.Add(this.label11, 0, 0);
            this.tableLayoutFooter.Controls.Add(this.label12, 1, 0);
            this.tableLayoutFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutFooter.Location = new System.Drawing.Point(3, 533);
            this.tableLayoutFooter.Name = "tableLayoutFooter";
            this.tableLayoutFooter.RowCount = 1;
            this.tableLayoutFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tableLayoutFooter.Size = new System.Drawing.Size(1255, 89);
            this.tableLayoutFooter.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(40, 0);
            this.label11.Margin = new System.Windows.Forms.Padding(40, 0, 3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(584, 89);
            this.label11.TabIndex = 23;
            this.label11.Text = "Шефов Артём";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(630, 0);
            this.label12.Margin = new System.Windows.Forms.Padding(3, 0, 40, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(585, 89);
            this.label12.TabIndex = 24;
            this.label12.Text = "xzlol12f@gmail.com";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutHeader
            // 
            this.tableLayoutHeader.ColumnCount = 3;
            this.tableLayoutMain.SetColumnSpan(this.tableLayoutHeader, 3);
            this.tableLayoutHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.04383F));
            this.tableLayoutHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.8765F));
            this.tableLayoutHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutHeader.Controls.Add(this.buttonExit, 2, 0);
            this.tableLayoutHeader.Controls.Add(this.label10, 1, 0);
            this.tableLayoutHeader.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutHeader.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutHeader.Name = "tableLayoutHeader";
            this.tableLayoutHeader.RowCount = 1;
            this.tableLayoutHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutHeader.Size = new System.Drawing.Size(1255, 87);
            this.tableLayoutHeader.TabIndex = 27;
            // 
            // tableLayoutMain
            // 
            this.tableLayoutMain.ColumnCount = 3;
            this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.03448F));
            this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.93103F));
            this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.03448F));
            this.tableLayoutMain.Controls.Add(this.tableLayoutGladiator1, 0, 1);
            this.tableLayoutMain.Controls.Add(this.tableLayoutMiddle, 1, 1);
            this.tableLayoutMain.Controls.Add(this.tableLayoutHeader, 0, 0);
            this.tableLayoutMain.Controls.Add(this.tableLayoutGladiator2, 2, 1);
            this.tableLayoutMain.Controls.Add(this.tableLayoutFooter, 0, 2);
            this.tableLayoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutMain.Name = "tableLayoutMain";
            this.tableLayoutMain.RowCount = 3;
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutMain.Size = new System.Drawing.Size(1261, 625);
            this.tableLayoutMain.TabIndex = 30;
            // 
            // tableLayoutGladiator1
            // 
            this.tableLayoutGladiator1.ColumnCount = 2;
            this.tableLayoutGladiator1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutGladiator1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutGladiator1.Controls.Add(this.textBoxName1, 0, 0);
            this.tableLayoutGladiator1.Controls.Add(this.pictureBox2, 0, 1);
            this.tableLayoutGladiator1.Controls.Add(this.buttonReady1, 0, 5);
            this.tableLayoutGladiator1.Controls.Add(this.label4, 1, 1);
            this.tableLayoutGladiator1.Controls.Add(this.label3, 1, 3);
            this.tableLayoutGladiator1.Controls.Add(this.comboBoxWeapon1, 1, 2);
            this.tableLayoutGladiator1.Controls.Add(this.comboBoxArmor1, 1, 4);
            this.tableLayoutGladiator1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutGladiator1.Location = new System.Drawing.Point(3, 96);
            this.tableLayoutGladiator1.Name = "tableLayoutGladiator1";
            this.tableLayoutGladiator1.RowCount = 6;
            this.tableLayoutGladiator1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.27926F));
            this.tableLayoutGladiator1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.01643F));
            this.tableLayoutGladiator1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.01643F));
            this.tableLayoutGladiator1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.77618F));
            this.tableLayoutGladiator1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.73782F));
            this.tableLayoutGladiator1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.16937F));
            this.tableLayoutGladiator1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutGladiator1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutGladiator1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutGladiator1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutGladiator1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutGladiator1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutGladiator1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutGladiator1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutGladiator1.Size = new System.Drawing.Size(385, 431);
            this.tableLayoutGladiator1.TabIndex = 29;
            // 
            // textBoxName1
            // 
            this.tableLayoutGladiator1.SetColumnSpan(this.textBoxName1, 2);
            this.textBoxName1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName1.Location = new System.Drawing.Point(50, 15);
            this.textBoxName1.Margin = new System.Windows.Forms.Padding(50, 15, 50, 15);
            this.textBoxName1.Multiline = true;
            this.textBoxName1.Name = "textBoxName1";
            this.textBoxName1.Size = new System.Drawing.Size(285, 65);
            this.textBoxName1.TabIndex = 23;
            this.textBoxName1.Text = "Первый гладиатор";
            this.textBoxName1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 98);
            this.pictureBox2.Name = "pictureBox2";
            this.tableLayoutGladiator1.SetRowSpan(this.pictureBox2, 4);
            this.pictureBox2.Size = new System.Drawing.Size(186, 255);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // buttonReady1
            // 
            this.tableLayoutGladiator1.SetColumnSpan(this.buttonReady1, 2);
            this.buttonReady1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonReady1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReady1.Location = new System.Drawing.Point(3, 359);
            this.buttonReady1.Name = "buttonReady1";
            this.buttonReady1.Size = new System.Drawing.Size(379, 69);
            this.buttonReady1.TabIndex = 12;
            this.buttonReady1.Text = "К бою готов!";
            this.buttonReady1.UseVisualStyleBackColor = true;
            this.buttonReady1.Click += new System.EventHandler(this.buttonReady1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(195, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 68);
            this.label4.TabIndex = 15;
            this.label4.Text = "Оружие";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(195, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 28);
            this.label3.TabIndex = 17;
            this.label3.Text = "Броня";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // comboBoxWeapon1
            // 
            this.comboBoxWeapon1.FormattingEnabled = true;
            this.comboBoxWeapon1.Items.AddRange(new object[] {
            "Меч",
            "Топор",
            "Копьё"});
            this.comboBoxWeapon1.Location = new System.Drawing.Point(195, 166);
            this.comboBoxWeapon1.Name = "comboBoxWeapon1";
            this.comboBoxWeapon1.Size = new System.Drawing.Size(121, 21);
            this.comboBoxWeapon1.TabIndex = 24;
            this.comboBoxWeapon1.SelectedIndexChanged += new System.EventHandler(this.comboBoxWeapon1_SelectedIndexChanged);
            // 
            // comboBoxArmor1
            // 
            this.comboBoxArmor1.FormattingEnabled = true;
            this.comboBoxArmor1.Items.AddRange(new object[] {
            "Лёгкая броня",
            "Средняя броня",
            "Тяжёлая броня"});
            this.comboBoxArmor1.Location = new System.Drawing.Point(195, 262);
            this.comboBoxArmor1.Name = "comboBoxArmor1";
            this.comboBoxArmor1.Size = new System.Drawing.Size(121, 21);
            this.comboBoxArmor1.TabIndex = 25;
            // 
            // tableLayoutGladiator2
            // 
            this.tableLayoutGladiator2.ColumnCount = 2;
            this.tableLayoutGladiator2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutGladiator2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutGladiator2.Controls.Add(this.buttonReady2, 0, 5);
            this.tableLayoutGladiator2.Controls.Add(this.label7, 0, 3);
            this.tableLayoutGladiator2.Controls.Add(this.label8, 0, 1);
            this.tableLayoutGladiator2.Controls.Add(this.pictureBox4, 1, 1);
            this.tableLayoutGladiator2.Controls.Add(this.textBoxName2, 0, 0);
            this.tableLayoutGladiator2.Controls.Add(this.comboBoxWeapon2, 0, 2);
            this.tableLayoutGladiator2.Controls.Add(this.comboBoxArmor2, 0, 4);
            this.tableLayoutGladiator2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutGladiator2.Location = new System.Drawing.Point(872, 96);
            this.tableLayoutGladiator2.Name = "tableLayoutGladiator2";
            this.tableLayoutGladiator2.RowCount = 6;
            this.tableLayoutGladiator2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.27926F));
            this.tableLayoutGladiator2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.01643F));
            this.tableLayoutGladiator2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.01643F));
            this.tableLayoutGladiator2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.77618F));
            this.tableLayoutGladiator2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.73782F));
            this.tableLayoutGladiator2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.16937F));
            this.tableLayoutGladiator2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutGladiator2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutGladiator2.Size = new System.Drawing.Size(386, 431);
            this.tableLayoutGladiator2.TabIndex = 28;
            this.tableLayoutGladiator2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel4_Paint);
            // 
            // textBoxName2
            // 
            this.tableLayoutGladiator2.SetColumnSpan(this.textBoxName2, 2);
            this.textBoxName2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName2.Location = new System.Drawing.Point(50, 15);
            this.textBoxName2.Margin = new System.Windows.Forms.Padding(50, 15, 50, 15);
            this.textBoxName2.Multiline = true;
            this.textBoxName2.Name = "textBoxName2";
            this.textBoxName2.Size = new System.Drawing.Size(286, 65);
            this.textBoxName2.TabIndex = 22;
            this.textBoxName2.Text = "Второй гладиатор";
            this.textBoxName2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonReady2
            // 
            this.tableLayoutGladiator2.SetColumnSpan(this.buttonReady2, 2);
            this.buttonReady2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonReady2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReady2.Location = new System.Drawing.Point(3, 359);
            this.buttonReady2.Name = "buttonReady2";
            this.buttonReady2.Size = new System.Drawing.Size(380, 69);
            this.buttonReady2.TabIndex = 12;
            this.buttonReady2.Text = "К бою готов!";
            this.buttonReady2.UseVisualStyleBackColor = true;
            this.buttonReady2.Click += new System.EventHandler(this.button5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(3, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 28);
            this.label7.TabIndex = 17;
            this.label7.Text = "Броня";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(3, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 68);
            this.label8.TabIndex = 15;
            this.label8.Text = "Оружие";
            this.label8.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(196, 98);
            this.pictureBox4.Name = "pictureBox4";
            this.tableLayoutGladiator2.SetRowSpan(this.pictureBox4, 4);
            this.pictureBox4.Size = new System.Drawing.Size(187, 255);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // comboBoxWeapon2
            // 
            this.comboBoxWeapon2.FormattingEnabled = true;
            this.comboBoxWeapon2.Items.AddRange(new object[] {
            "Меч",
            "Топор",
            "Копьё"});
            this.comboBoxWeapon2.Location = new System.Drawing.Point(3, 166);
            this.comboBoxWeapon2.Name = "comboBoxWeapon2";
            this.comboBoxWeapon2.Size = new System.Drawing.Size(121, 21);
            this.comboBoxWeapon2.TabIndex = 23;
            // 
            // comboBoxArmor2
            // 
            this.comboBoxArmor2.FormattingEnabled = true;
            this.comboBoxArmor2.Items.AddRange(new object[] {
            "Лёгкая броня",
            "Средняя броня",
            "Тяжёлая броня"});
            this.comboBoxArmor2.Location = new System.Drawing.Point(3, 262);
            this.comboBoxArmor2.Name = "comboBoxArmor2";
            this.comboBoxArmor2.Size = new System.Drawing.Size(121, 21);
            this.comboBoxArmor2.TabIndex = 24;
            // 
            // buttonStartFight
            // 
            this.tableLayoutMiddle.SetColumnSpan(this.buttonStartFight, 2);
            this.buttonStartFight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonStartFight.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStartFight.Location = new System.Drawing.Point(3, 360);
            this.buttonStartFight.Name = "buttonStartFight";
            this.buttonStartFight.Size = new System.Drawing.Size(466, 68);
            this.buttonStartFight.TabIndex = 10;
            this.buttonStartFight.Text = "Начать бой";
            this.buttonStartFight.UseVisualStyleBackColor = true;
            this.buttonStartFight.Click += new System.EventHandler(this.buttonStartFight_Click);
            // 
            // textBoxBattleLog
            // 
            this.tableLayoutMiddle.SetColumnSpan(this.textBoxBattleLog, 2);
            this.textBoxBattleLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxBattleLog.Location = new System.Drawing.Point(3, 72);
            this.textBoxBattleLog.Multiline = true;
            this.textBoxBattleLog.Name = "textBoxBattleLog";
            this.textBoxBattleLog.Size = new System.Drawing.Size(466, 282);
            this.textBoxBattleLog.TabIndex = 11;
            // 
            // tableLayoutMiddle
            // 
            this.tableLayoutMiddle.ColumnCount = 2;
            this.tableLayoutMiddle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutMiddle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutMiddle.Controls.Add(this.textBoxBattleLog, 0, 1);
            this.tableLayoutMiddle.Controls.Add(this.labelCountdown, 0, 0);
            this.tableLayoutMiddle.Controls.Add(this.buttonStartFight, 0, 2);
            this.tableLayoutMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutMiddle.Location = new System.Drawing.Point(394, 96);
            this.tableLayoutMiddle.Name = "tableLayoutMiddle";
            this.tableLayoutMiddle.RowCount = 3;
            this.tableLayoutMiddle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.53728F));
            this.tableLayoutMiddle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.46272F));
            this.tableLayoutMiddle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutMiddle.Size = new System.Drawing.Size(472, 431);
            this.tableLayoutMiddle.TabIndex = 26;
            this.tableLayoutMiddle.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutMiddle_Paint);
            // 
            // labelCountdown
            // 
            this.labelCountdown.AutoSize = true;
            this.labelCountdown.Location = new System.Drawing.Point(3, 0);
            this.labelCountdown.Name = "labelCountdown";
            this.labelCountdown.Size = new System.Drawing.Size(46, 13);
            this.labelCountdown.TabIndex = 12;
            this.labelCountdown.Text = "счетчик";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 625);
            this.Controls.Add(this.tableLayoutMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutFooter.ResumeLayout(false);
            this.tableLayoutFooter.PerformLayout();
            this.tableLayoutHeader.ResumeLayout(false);
            this.tableLayoutHeader.PerformLayout();
            this.tableLayoutMain.ResumeLayout(false);
            this.tableLayoutGladiator1.ResumeLayout(false);
            this.tableLayoutGladiator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tableLayoutGladiator2.ResumeLayout(false);
            this.tableLayoutGladiator2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.tableLayoutMiddle.ResumeLayout(false);
            this.tableLayoutMiddle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutFooter;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TableLayoutPanel tableLayoutHeader;
        private System.Windows.Forms.TableLayoutPanel tableLayoutMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutGladiator1;
        private System.Windows.Forms.Button buttonReady1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBoxName1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutGladiator2;
        private System.Windows.Forms.Button buttonReady2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox textBoxName2;
        private System.Windows.Forms.ComboBox comboBoxWeapon1;
        private System.Windows.Forms.ComboBox comboBoxArmor1;
        private System.Windows.Forms.ComboBox comboBoxWeapon2;
        private System.Windows.Forms.ComboBox comboBoxArmor2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutMiddle;
        private System.Windows.Forms.TextBox textBoxBattleLog;
        private System.Windows.Forms.Button buttonStartFight;
        private System.Windows.Forms.Label labelCountdown;
    }
}

