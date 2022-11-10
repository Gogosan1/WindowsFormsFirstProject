using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LabaSixThirdSemester.Worker;

namespace LabaSixThirdSemester
{
    public partial class HourlyWorkerConstructor : Form
    {
        public HourlyWorkerConstructor()
        {
            InitializeComponent();
            CreateWorker.Enabled = false;
        }

        private HourlyWageWorker numUpDownVal;
        public HourlyWageWorker NumUpDown { get { return numUpDownVal; } }
        private void CreateWorker_Click(object sender, EventArgs e)
        {
            var Worker = new HourlyWageWorker(WorkerName.Text, gender, Convert.ToInt32(HourlyWage.Text), Convert.ToInt32(OvertimeHourlyWage.Text), Convert.ToInt32(StandardOfWorkingHours.Text));
            numUpDownVal = Worker;
            this.Hide();
        }

        private void HourlyWorkerConstructor_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void WorkerName_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            if (WorkerName.TextLength == 0)
                MessageBox.Show("Ошибка! Осуществите ввод.");
            else
                e.Cancel = false;
            EnableCreateWorker_Validated();
        }
        private void HourlyWage_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            if (HourlyWage.TextLength == 0)
                MessageBox.Show("Ошибка! Осуществите ввод.");
            else
            {
                if (Int32.TryParse(HourlyWage.Text, out int t))
                {
                    if (t > 0)
                        e.Cancel = false;
                    else
                        MessageBox.Show("Ожидалось положительное значение.");
                }
                else
                    MessageBox.Show("Ошибка! Ожидалось целочисленное значение.");
            }
            EnableCreateWorker_Validated();
        }

        private void OvertimeHourlyWage_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            if (OvertimeHourlyWage.TextLength == 0)
                MessageBox.Show("Ошибка! Осуществите ввод.");
            else
            {
                if (Int32.TryParse(OvertimeHourlyWage.Text, out int t))
                {
                    if (t > 0)
                        e.Cancel = false;
                    else
                        MessageBox.Show("Ожидалось положительное значение.");
                }
                else
                    MessageBox.Show("Ошибка! Ожидалось целочисленное значение.");
            }
            EnableCreateWorker_Validated();
        }

        private void StandardOfWorkingHours_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            if (StandardOfWorkingHours.TextLength == 0)
                MessageBox.Show("Ошибка! Осуществите ввод.");
            else
            {
                if (Int32.TryParse(StandardOfWorkingHours.Text, out int t))
                {
                    if (t > 0 && t < 24)
                        e.Cancel = false;
                    else
                        MessageBox.Show("Ожидалось значение в диапазоне от 1 до 24.");
                }
                else
                    MessageBox.Show("Ошибка! Ожидалось целочисленное значение.");
            }
            EnableCreateWorker_Validated();
        }

        private void EnableCreateWorker_Validated()
        {
            if (WorkerName.Text != "" && HourlyWage.Text != "" && OvertimeHourlyWage.Text != "" && StandardOfWorkingHours.Text != "")
            CreateWorker.Enabled = true;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int firstElement = GetGender.SelectedIndex;
            if (firstElement == 0)
                gender = Gender.Male;
            else
                gender = Gender.Female;
            if (firstElement == -1)
                MessageBox.Show("GG");
        }

        private Gender gender;
    }
}
