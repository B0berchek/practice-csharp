using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormGladiator
{
    public partial class Form1 : Form
    {
        // Бой и подготовка
        bool ready1 = false;
        bool ready2 = false;

        bool fightStarted = false;

        bool wPressed = false;
        bool upPressed = false;

        int countdown = 3;

        Random random = new Random();

        System.Windows.Forms.Timer fightTimer = new System.Windows.Forms.Timer();

        // Постоянные данные
        int health1;
        int health2;

        // Характеристики первого гладиатора
        string name1;
        string weapon1;
        string armor1;

        int minDamage1;
        int maxDamage1;
        int durability1;
        int protection1;

        // Характеристики второго гладиатора
        string name2;
        string weapon2;
        string armor2;

        int minDamage2;
        int maxDamage2;
        int durability2;
        int protection2;

        public Form1()
        {
            InitializeComponent();

            this.KeyPreview = true;

            // this.KeyDown += Form1_KeyDown;
            // this.KeyUp += Form1_KeyUp;

            fightTimer.Interval = 1000;

            // fightTimer.Tick += fightTimer.Tick;

            labelCountdown.Visible = false;

            buttonStartFight.Enabled = false;
        }

        private void GetWeapon(int choice, int gladiator)
        {
            if (gladiator == 1)
            {
                if (choice == 0)
                {
                    weapon1 = "Меч";
                    minDamage1 = 25;
                    maxDamage1 = 40;
                }
                else if (choice == 1)
                {
                    weapon1 = "Топор";
                    minDamage1 = 35;
                    maxDamage1 = 55;
                }
                else if (choice == 2)
                {
                    weapon1 = "Копьё";
                    minDamage1 = 15;
                    maxDamage1 = 35;
                }
            }
            else
            {
                if (choice == 0)
                {
                    weapon2 = "Меч";
                    minDamage2 = 25;
                    maxDamage2 = 40;
                }
                else if (choice == 1)
                {
                    weapon2 = "Топор";
                    minDamage2 = 35;
                    maxDamage2 = 55;
                }
                else if (choice == 2)
                {
                    weapon2 = "Копьё";
                    minDamage2 = 15;
                    maxDamage2 = 35;
                }
            }
        }

        private void GetArmor(int choice, int gladiator)
        {
            if (gladiator == 1)
            {
                if (choice == 0)
                {
                    armor1 = "Лёгкая броня";
                    durability1 = 70;
                    protection1 = 15;
                }
                else if (choice == 1)
                {
                    armor1 = "Средняя броня";
                    durability1 = 120;
                    protection1 = 35;
                }
                else if (choice == 2)
                {
                    armor1 = "Тяжёлая броня";
                    durability1 = 180;
                    protection1 = 55;
                }
            }
            else
            {
                if (choice == 0)
                {
                    armor2 = "Лёгкая броня";
                    durability2 = 70;
                    protection2 = 15;
                }
                else if (choice == 1)
                {
                    armor2 = "Средняя броня";
                    durability2 = 120;
                    protection2 = 35;
                }
                else if (choice == 2)
                {
                    armor2 = "Тяжёлая броня";
                    durability2 = 180;
                    protection2 = 55;
                }
            }
        }

        private void CheckReady()
        {
            if (ready1 == true && ready2 == true)
            {
                textBoxBattleLog.Clear();

                textBoxBattleLog.AppendText("========== БОЙ ПРЕДСТОИТ ==========\r\n\r\n");

                textBoxBattleLog.AppendText("ГЛАДИАТОР №1\r\n");
                textBoxBattleLog.AppendText("Имя: " + name1 + "\r\n");
                textBoxBattleLog.AppendText("Оружие: " + weapon1 + "\r\n");
                textBoxBattleLog.AppendText("Урон: " + minDamage1 + "-" + maxDamage1 + "\r\n");
                textBoxBattleLog.AppendText("Броня: " + armor1 + "\r\n");
                textBoxBattleLog.AppendText("Прочность: " + durability1 + "\r\n");
                textBoxBattleLog.AppendText("Защита: " + protection1 + "%\r\n\r\n");

                textBoxBattleLog.AppendText("ГЛАДИАТОР №2\r\n");
                textBoxBattleLog.AppendText("Имя: " + name2 + "\r\n");
                textBoxBattleLog.AppendText("Оружие: " + weapon2 + "\r\n");
                textBoxBattleLog.AppendText("Урон: " + minDamage2 + "-" + maxDamage2 + "\r\n");
                textBoxBattleLog.AppendText("Броня: " + armor2 + "\r\n");
                textBoxBattleLog.AppendText("Прочность: " + durability2 + "\r\n");
                textBoxBattleLog.AppendText("Защита: " + protection2 + "%\r\n\r\n");

                textBoxBattleLog.AppendText("==================================\r\n");
                textBoxBattleLog.AppendText("Оба гладиатора готовы к бою!");

                buttonStartFight.Enabled = true;

                textBoxBattleLog.AppendText("\r\n Начаит бой?");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxWeapon1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonReady1_Click(object sender, EventArgs e)
        {
            if (textBoxName1.Text == "")
            {
                MessageBox.Show("Введите имя гладиатора!");
                return;
            }

            if (comboBoxWeapon1.SelectedIndex == -1 || comboBoxArmor1.SelectedIndex == -1)
            {
                MessageBox.Show("Выбеорите оружие и броню!");
                return;
            }

            name1 = textBoxName1.Text;

            GetWeapon(comboBoxWeapon2.SelectedIndex, 1);
            GetArmor(comboBoxArmor2.SelectedIndex, 1);

            ready1 = true;

            buttonReady1.Enabled = false;

            CheckReady();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBoxName2.Text == "")
            {
                MessageBox.Show("Введите имя гладиатора!");
                return;
            }

            if (comboBoxWeapon2.SelectedIndex == -1 ||
                comboBoxArmor2.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите оружие и броню!");
                return;
            }

            name2 = textBoxName2.Text;

            GetWeapon(comboBoxWeapon2.SelectedIndex, 2);
            GetArmor(comboBoxArmor2.SelectedIndex, 2);

            ready2 = true;

            buttonReady2.Enabled = false;

            CheckReady();
        }

        private void tableLayoutMiddle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonStartFight_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Вы действительно хотите начать бой",
                "Начать бой",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
        }
    }
}
