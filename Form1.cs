using System.Diagnostics;
using System.Linq;

namespace WinFormBank
{
    public partial class WinFormBank : Form
    {
        public WinFormBank()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        const double BANKTHREEMONTH = 11.50;   // 3 месяца
        const double BANKSIXMONTH = 11.75;     // 6 месяцев
        const double BANKYEAR = 12.50;         // год

        /// <summary>
        /// Обработчик на простой клик для запуска расчёта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCalc_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "";


            // Блок объяления локальных величин
            double bonusMonth, bonusInPeriod;
            int countMonth;

            int period;
            double summa;

            // Обработчик ошибок
            try
            {
                summa = Convert.ToDouble(textBoxSumma.Text.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show(
                "Сумма должна быть числом",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
                return;
            }
            try
            {
                period = Convert.ToInt32(comboBox1.Text.ToString()[0..3].Trim());
            }
            catch (Exception)
            {
                MessageBox.Show(
                "Вы не выбрали срок",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
                return;
            }

            double percentBank = 0;


            switch (period)
            {
                case 91: percentBank = BANKTHREEMONTH; break;
                case 181: percentBank = BANKSIXMONTH; break;
                case 365: percentBank = BANKYEAR; break;
            }

            // Расчётный блок
            countMonth = period / 30;
            bonusInPeriod = 0;

            for (int month = 1; month <= countMonth; month++)
            {
                bonusMonth = percentBank / 100 / 12 * summa;

                summa += bonusMonth;
                bonusInPeriod += bonusMonth;


                textBoxResult.AppendText($"Ваш ежемесячный доход в {month} месяц " + bonusMonth.ToString("N2") + " в рублях\r\n");
                textBoxResult.AppendText($"Ваша сумма на счету в {month} месяц " + summa.ToString("N2") + " в рублях \r\n");
            }

            // Результат
            textBoxResult.AppendText($"\r\nВаша общая банковская надбавка за весь период = " + $"{bonusInPeriod:N2} в рублях\r\n");
            textBoxResult.AppendText($"Ваша сумма на счету в конце периода = " + $"{summa:N2} в рублях\r\n");
        }

        private void textBoxSumma_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void WinFormBank_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result =
            MessageBox.Show(
                "Вы действительно хотите закрыть окно?",
                "Подтверждение закрытия",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (result == DialogResult.Yes)
            {
                e.Cancel = false;                    // Разрешить открыть окно
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}