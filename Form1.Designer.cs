namespace WinFormBank
{
    partial class WinFormBank
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinFormBank));
            tableLayoutLeft = new TableLayoutPanel();
            label3 = new Label();
            textBoxSumma = new TextBox();
            buttonCalc = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            tableLayoutRight = new TableLayoutPanel();
            label4 = new Label();
            textBoxResult = new TextBox();
            tableLayoutMain = new TableLayoutPanel();
            tableLayoutHeader = new TableLayoutPanel();
            label7 = new Label();
            buttonExit = new Button();
            pictureBox1 = new PictureBox();
            tableLayoutFooter = new TableLayoutPanel();
            label5 = new Label();
            label6 = new Label();
            tableLayoutLeft.SuspendLayout();
            tableLayoutRight.SuspendLayout();
            tableLayoutMain.SuspendLayout();
            tableLayoutHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutFooter.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutLeft
            // 
            tableLayoutLeft.ColumnCount = 2;
            tableLayoutLeft.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.08757F));
            tableLayoutLeft.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.9124336F));
            tableLayoutLeft.Controls.Add(label3, 0, 2);
            tableLayoutLeft.Controls.Add(textBoxSumma, 1, 1);
            tableLayoutLeft.Controls.Add(buttonCalc, 0, 3);
            tableLayoutLeft.Controls.Add(comboBox1, 1, 2);
            tableLayoutLeft.Controls.Add(label1, 0, 0);
            tableLayoutLeft.Controls.Add(label2, 0, 1);
            tableLayoutLeft.Dock = DockStyle.Fill;
            tableLayoutLeft.Location = new Point(3, 87);
            tableLayoutLeft.Name = "tableLayoutLeft";
            tableLayoutLeft.RowCount = 4;
            tableLayoutLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutLeft.Size = new Size(425, 386);
            tableLayoutLeft.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Yu Gothic UI Semibold", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(3, 192);
            label3.Name = "label3";
            label3.Size = new Size(206, 135);
            label3.TabIndex = 2;
            label3.Text = "Срок вклада";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxSumma
            // 
            textBoxSumma.BackColor = Color.FromArgb(255, 252, 161);
            textBoxSumma.Dock = DockStyle.Fill;
            textBoxSumma.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSumma.ForeColor = SystemColors.WindowText;
            textBoxSumma.Location = new Point(222, 102);
            textBoxSumma.Margin = new Padding(10, 45, 10, 45);
            textBoxSumma.Multiline = true;
            textBoxSumma.Name = "textBoxSumma";
            textBoxSumma.Size = new Size(193, 45);
            textBoxSumma.TabIndex = 4;
            textBoxSumma.Text = "Введите сумму";
            textBoxSumma.TextAlign = HorizontalAlignment.Center;
            textBoxSumma.TextChanged += textBoxSumma_TextChanged;
            // 
            // buttonCalc
            // 
            buttonCalc.BackColor = Color.FromArgb(255, 238, 161);
            tableLayoutLeft.SetColumnSpan(buttonCalc, 2);
            buttonCalc.Dock = DockStyle.Fill;
            buttonCalc.Font = new Font("Yu Gothic UI Semibold", 20F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCalc.Location = new Point(20, 330);
            buttonCalc.Margin = new Padding(20, 3, 20, 3);
            buttonCalc.Name = "buttonCalc";
            buttonCalc.Size = new Size(385, 53);
            buttonCalc.TabIndex = 3;
            buttonCalc.Text = "Рассчитать";
            buttonCalc.UseVisualStyleBackColor = false;
            buttonCalc.Click += buttonCalc_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(255, 252, 161);
            comboBox1.Dock = DockStyle.Top;
            comboBox1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "91 день", "181 день", "365 дней" });
            comboBox1.Location = new Point(222, 237);
            comboBox1.Margin = new Padding(10, 45, 10, 20);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(193, 36);
            comboBox1.TabIndex = 5;
            comboBox1.Text = "Выберете срок";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            tableLayoutLeft.SetColumnSpan(label1, 2);
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Yu Gothic UI Semibold", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(419, 57);
            label1.TabIndex = 0;
            label1.Text = "Входная информация";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Yu Gothic UI Semibold", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 57);
            label2.Name = "label2";
            label2.Size = new Size(206, 135);
            label2.TabIndex = 1;
            label2.Text = "Сумма вклада";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // tableLayoutRight
            // 
            tableLayoutRight.ColumnCount = 1;
            tableLayoutRight.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutRight.Controls.Add(label4, 0, 0);
            tableLayoutRight.Controls.Add(textBoxResult, 0, 1);
            tableLayoutRight.Dock = DockStyle.Fill;
            tableLayoutRight.Location = new Point(434, 87);
            tableLayoutRight.Name = "tableLayoutRight";
            tableLayoutRight.RowCount = 2;
            tableLayoutRight.RowStyles.Add(new RowStyle(SizeType.Percent, 15.0528164F));
            tableLayoutRight.RowStyles.Add(new RowStyle(SizeType.Percent, 84.94718F));
            tableLayoutRight.Size = new Size(426, 386);
            tableLayoutRight.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            tableLayoutRight.SetColumnSpan(label4, 2);
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Yu Gothic UI Semibold", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(420, 58);
            label4.TabIndex = 1;
            label4.Text = "Результаты рассчётов";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxResult
            // 
            textBoxResult.BackColor = Color.FromArgb(255, 252, 161);
            textBoxResult.Dock = DockStyle.Fill;
            textBoxResult.Location = new Point(40, 68);
            textBoxResult.Margin = new Padding(40, 10, 40, 10);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.ScrollBars = ScrollBars.Both;
            textBoxResult.Size = new Size(346, 308);
            textBoxResult.TabIndex = 2;
            textBoxResult.TextChanged += textBoxResult_TextChanged;
            // 
            // tableLayoutMain
            // 
            tableLayoutMain.BackColor = Color.FromArgb(240, 250, 253);
            tableLayoutMain.ColumnCount = 2;
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutMain.Controls.Add(tableLayoutRight, 1, 1);
            tableLayoutMain.Controls.Add(tableLayoutLeft, 0, 1);
            tableLayoutMain.Controls.Add(tableLayoutHeader, 0, 0);
            tableLayoutMain.Controls.Add(tableLayoutFooter, 0, 2);
            tableLayoutMain.Dock = DockStyle.Fill;
            tableLayoutMain.Location = new Point(0, 0);
            tableLayoutMain.Name = "tableLayoutMain";
            tableLayoutMain.RowCount = 3;
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutMain.Size = new Size(863, 560);
            tableLayoutMain.TabIndex = 2;
            // 
            // tableLayoutHeader
            // 
            tableLayoutHeader.BackColor = Color.FromArgb(240, 250, 253);
            tableLayoutHeader.ColumnCount = 3;
            tableLayoutMain.SetColumnSpan(tableLayoutHeader, 2);
            tableLayoutHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutHeader.Controls.Add(label7, 1, 0);
            tableLayoutHeader.Controls.Add(buttonExit, 2, 0);
            tableLayoutHeader.Controls.Add(pictureBox1, 0, 0);
            tableLayoutHeader.Dock = DockStyle.Fill;
            tableLayoutHeader.Location = new Point(3, 3);
            tableLayoutHeader.Name = "tableLayoutHeader";
            tableLayoutHeader.RowCount = 1;
            tableLayoutHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutHeader.Size = new Size(857, 78);
            tableLayoutHeader.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Yu Gothic UI Semibold", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(88, 0);
            label7.Name = "label7";
            label7.Size = new Size(593, 78);
            label7.TabIndex = 0;
            label7.Text = "Выполнение банковских рассчётов";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.FromArgb(255, 238, 161);
            buttonExit.Dock = DockStyle.Fill;
            buttonExit.Font = new Font("Yu Gothic UI Semibold", 30F, FontStyle.Regular, GraphicsUnit.Point);
            buttonExit.Location = new Point(687, 3);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(167, 72);
            buttonExit.TabIndex = 1;
            buttonExit.Text = "Выход";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(79, 72);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutFooter
            // 
            tableLayoutFooter.BackColor = Color.FromArgb(240, 250, 253);
            tableLayoutFooter.ColumnCount = 2;
            tableLayoutMain.SetColumnSpan(tableLayoutFooter, 2);
            tableLayoutFooter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutFooter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutFooter.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutFooter.Controls.Add(label5, 0, 0);
            tableLayoutFooter.Controls.Add(label6, 1, 0);
            tableLayoutFooter.Dock = DockStyle.Fill;
            tableLayoutFooter.Location = new Point(3, 479);
            tableLayoutFooter.Name = "tableLayoutFooter";
            tableLayoutFooter.RowCount = 1;
            tableLayoutFooter.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutFooter.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutFooter.Size = new Size(857, 78);
            tableLayoutFooter.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Yu Gothic UI Semibold", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(20, 0);
            label5.Margin = new Padding(20, 0, 3, 0);
            label5.Name = "label5";
            label5.Size = new Size(405, 78);
            label5.TabIndex = 0;
            label5.Text = "Шефов Артём";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Yu Gothic UI Semibold", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(431, 0);
            label6.Margin = new Padding(3, 0, 20, 0);
            label6.Name = "label6";
            label6.Size = new Size(406, 78);
            label6.TabIndex = 1;
            label6.Text = "xzlol12f@gmail.com";
            label6.TextAlign = ContentAlignment.MiddleRight;
            label6.Click += label6_Click;
            // 
            // WinFormBank
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 250, 253);
            ClientSize = new Size(863, 560);
            Controls.Add(tableLayoutMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(879, 599);
            Name = "WinFormBank";
            Text = "Банковский калькулятор";
            FormClosing += WinFormBank_FormClosing;
            Load += WinFormBank_Load;
            tableLayoutLeft.ResumeLayout(false);
            tableLayoutLeft.PerformLayout();
            tableLayoutRight.ResumeLayout(false);
            tableLayoutRight.PerformLayout();
            tableLayoutMain.ResumeLayout(false);
            tableLayoutHeader.ResumeLayout(false);
            tableLayoutHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutFooter.ResumeLayout(false);
            tableLayoutFooter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutLeft;
        private Label label1;
        private Label label3;
        private TextBox textBoxSumma;
        private Button buttonCalc;
        private Label label2;
        private ComboBox comboBox1;
        private TableLayoutPanel tableLayoutRight;
        private Label label4;
        private TextBox textBoxResult;
        private TableLayoutPanel tableLayoutMain;
        private TableLayoutPanel tableLayoutFooter;
        private Label label5;
        private Label label6;
        private TableLayoutPanel tableLayoutHeader;
        private Label label7;
        private Button buttonExit;
        private PictureBox pictureBox1;
    }
}