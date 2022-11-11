using System;
using System.ComponentModel;
using System.Windows.Forms;
using static LabaSixThirdSemester.Worker;

namespace LabaSixThirdSemester
{
    public partial class CommisionWorkerConstructor : Form
    {
        public CommisionWorkerConstructor()
        {
            InitializeComponent();
            CreateWorker.Enabled = false;
        }

        private CommissionWageWorker numUpDownVal;
        public CommissionWageWorker NumUpDown { get { return numUpDownVal; } }

        private void CreateWorker_Click(object sender, EventArgs e)
        {
            var Worker = new CommissionWageWorker(WorkerName.Text, gender, Convert.ToInt32(Salary.Text), Convert.ToInt32(Percentage.Text));
            numUpDownVal = Worker;
            this.Close();
        }

        private void CommisionWorkerConstructor_Load(object sender, EventArgs e)
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
        private void Salary_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            if (Salary.TextLength == 0)
                MessageBox.Show("Ошибка! Осуществите ввод.");
            else
            {
                if (Int32.TryParse(Salary.Text, out int t))
                {
                    if (t > 0)
                        e.Cancel = false;
                    else
                        MessageBox.Show("Оклад должен быть положительным.");
                }
                else
                    MessageBox.Show("Ошибка! Ожидалось целочисленное значение.");
            }
            EnableCreateWorker_Validated();
        }
    

        private void Percentage_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            if (Percentage.TextLength == 0)
                MessageBox.Show("Ошибка! Осуществите ввод.");
            else
            {
                if (Int32.TryParse(Percentage.Text, out int t))
                {
                    if (t > 0 && t < 100)
                        e.Cancel = false;
                    else
                        MessageBox.Show("Ожидалось значение в диапазоне от 1 до 100");
                }
                else
                    MessageBox.Show("Ошибка! Ожидалось целочисленное значение.");
            }
            EnableCreateWorker_Validated();
        }

        private void EnableCreateWorker_Validated()
        {
            if (WorkerName.Text != "" && Percentage.Text != "" && Salary.Text != "")
                CreateWorker.Enabled = true;
        }

        private void GetGender_SelectedIndexChanged(object sender, EventArgs e)
        {
         
            int firstElement = GetGender.SelectedIndex;
            if (firstElement == 0)
                 gender = Gender.Male;
            else
                gender = Gender.Female;
        }
        private Gender gender;


    }
}
