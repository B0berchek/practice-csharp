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

        const double BANKTHREEMONTH = 11.50; // 3 мес€ца
        const double BANKSIXMONTH = 11.75; // 6 мес€цев
        const double BANKYEAR = 12.50; // год

        /// <summary>
        /// ќбработчик на простой клик дл€ запуска расчЄта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCalc_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "";


            // Ѕлок объ€лени€ локальных величин
            double bonusMonth, bonusInPeriod;
            int countMonth;

            int period;
            double summa;
            try
            {
                summa = Convert.ToDouble(textBoxSumma.Text.ToString());
                period = Convert.ToInt32(comboBox1.Text.ToString()[0..3].Trim());
            }
            catch (Exception)
            {
                textBoxResult.Text = "ќЎ»Ѕ ј: ¬ведены некорректные данные";
                return;
            }

            double percentBank = 0;
            switch (period)
            {
                case 91: percentBank = BANKTHREEMONTH; break;
                case 181: percentBank = BANKSIXMONTH; break;
                case 365: percentBank = BANKYEAR; break;
            }

            // –асчЄтный блок
            countMonth = period / 30;
            bonusInPeriod = 0;

            for (int month = 1; month <= countMonth; month++)
            {
                bonusMonth = percentBank / 100 / 12 * summa;

                summa += bonusMonth;
                bonusInPeriod += bonusMonth;


                textBoxResult.AppendText($"¬аш ежемес€чный доход в {month} мес€ц " + bonusMonth.ToString("N2") + " в рубл€х\r\n");
                textBoxResult.AppendText($"¬аша сумма на счету в {month} мес€ц " + summa.ToString("N2") + " в рубл€х \r\n");
            }

            // –езультат
            textBoxResult.AppendText($"\r\n¬аша обща€ банковска€ надбавка за весь период = " + $"{bonusInPeriod:N2} в рубл€х\r\n");
            textBoxResult.AppendText($"¬аша сумма на счету в конце периода = " + $"{summa:N2} в рубл€х\r\n");
        }

        private void textBoxSumma_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}