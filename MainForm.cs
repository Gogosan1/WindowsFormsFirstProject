using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabaSixThirdSemester
{
    public partial class MainForm : Form
    {
        private readonly Company company;
       // private BindingList<Worker> bindingList;
        public MainForm(Company company)
        {
            this.company = company;
            InitializeComponent();
            SimulateWork.Enabled = false;


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CreateWorker_Click(object sender, EventArgs e)
        {
            if (rbtCommisionWorker.Checked)
            {
                var form = new CommisionWorkerConstructor();
                form.ShowDialog();
                try
                {
                    company.RecruitWorker(form.NumUpDown);
                    var source = new BindingSource(company.WorkerList, null);
                    DataGridView.DataSource = source;
                }
                catch (ArgumentException t)
                {
                    MessageBox.Show(t.Message);
                }     
            }
            if(rbtHourlyWorker.Checked)
            {
                var form = new HourlyWorkerConstructor();
                form.ShowDialog();
                try
                {
                    company.RecruitWorker(form.NumUpDown);
                    var source = new BindingSource(company.WorkerList, null);
                    DataGridView.DataSource = source;
                }
                catch (ArgumentException t)
                {
                    MessageBox.Show(t.Message);
                }
            }
        }

        private void SimulateWork_Click(object sender, EventArgs e)
        {
            int expenses = company.SimulateWork(Convert.ToInt32(textBox1.Text));
            MessageBox.Show($"Затраты на содержание сотрудников в компании: {Convert.ToString(expenses)}\n" +
                            $"количество отработанных дней: {Convert.ToString(company.GetWorkedDaysCount())}");
        }
        private void FireWorker_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DataGridView.SelectedRows)
            {
                DataGridView.Rows.Remove(row); 
            }
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            if (textBox1.TextLength == 0)
                MessageBox.Show("Ошибка! Осуществите ввод.");
            else
            {
                if (Int32.TryParse(textBox1.Text, out int t))
                {
                    if (t > 0)
                        e.Cancel = false;
                    else
                        MessageBox.Show("Ожидалось значение положительное значение.");
                }
                else
                    MessageBox.Show("Ошибка! Ожидалось целочисленное значение.");
            }
            if (textBox1.Text != "")
                SimulateWork.Enabled = true;
        }
    }
}
