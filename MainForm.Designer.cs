namespace LabaSixThirdSemester
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.CreateWorker = new System.Windows.Forms.Button();
            this.FireWorker = new System.Windows.Forms.Button();
            this.SimulateWork = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtHourlyWorker = new System.Windows.Forms.RadioButton();
            this.rbtCommisionWorker = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.workerListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerListBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateWorker
            // 
            this.CreateWorker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.CreateWorker.Location = new System.Drawing.Point(1, 81);
            this.CreateWorker.Name = "CreateWorker";
            this.CreateWorker.Size = new System.Drawing.Size(186, 39);
            this.CreateWorker.TabIndex = 0;
            this.CreateWorker.Text = "Create worker";
            this.CreateWorker.UseVisualStyleBackColor = true;
            this.CreateWorker.Click += new System.EventHandler(this.CreateWorker_Click);
            // 
            // FireWorker
            // 
            this.FireWorker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FireWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.FireWorker.Location = new System.Drawing.Point(46, 181);
            this.FireWorker.Name = "FireWorker";
            this.FireWorker.Size = new System.Drawing.Size(186, 37);
            this.FireWorker.TabIndex = 5;
            this.FireWorker.Text = "Fire worker";
            this.FireWorker.UseVisualStyleBackColor = true;
            this.FireWorker.Click += new System.EventHandler(this.FireWorker_Click);
            // 
            // SimulateWork
            // 
            this.SimulateWork.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SimulateWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.SimulateWork.Location = new System.Drawing.Point(9, 100);
            this.SimulateWork.Name = "SimulateWork";
            this.SimulateWork.Size = new System.Drawing.Size(201, 103);
            this.SimulateWork.TabIndex = 8;
            this.SimulateWork.Text = "Simulate company working";
            this.SimulateWork.UseVisualStyleBackColor = true;
            this.SimulateWork.Click += new System.EventHandler(this.SimulateWork_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtHourlyWorker);
            this.groupBox1.Controls.Add(this.rbtCommisionWorker);
            this.groupBox1.Controls.Add(this.CreateWorker);
            this.groupBox1.Location = new System.Drawing.Point(12, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 126);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // rbtHourlyWorker
            // 
            this.rbtHourlyWorker.AutoSize = true;
            this.rbtHourlyWorker.Location = new System.Drawing.Point(6, 47);
            this.rbtHourlyWorker.Name = "rbtHourlyWorker";
            this.rbtHourlyWorker.Size = new System.Drawing.Size(146, 20);
            this.rbtHourlyWorker.TabIndex = 15;
            this.rbtHourlyWorker.TabStop = true;
            this.rbtHourlyWorker.Text = "Hourly wage worker";
            this.rbtHourlyWorker.UseVisualStyleBackColor = true;
            // 
            // rbtCommisionWorker
            // 
            this.rbtCommisionWorker.AutoSize = true;
            this.rbtCommisionWorker.Checked = true;
            this.rbtCommisionWorker.Location = new System.Drawing.Point(6, 21);
            this.rbtCommisionWorker.Name = "rbtCommisionWorker";
            this.rbtCommisionWorker.Size = new System.Drawing.Size(181, 20);
            this.rbtCommisionWorker.TabIndex = 16;
            this.rbtCommisionWorker.TabStop = true;
            this.rbtCommisionWorker.Text = "Commission wage worker";
            this.rbtCommisionWorker.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.DataGridView);
            this.groupBox2.Controls.Add(this.FireWorker);
            this.groupBox2.Location = new System.Drawing.Point(239, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(428, 291);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Работники";
            // 
            // DataGridView
            // 
            this.DataGridView.AutoGenerateColumns = false;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fullNameDataGridViewTextBoxColumn});
            this.DataGridView.DataSource = this.workerListBindingSource;
            this.DataGridView.Location = new System.Drawing.Point(46, 25);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersWidth = 51;
            this.DataGridView.RowTemplate.Height = 24;
            this.DataGridView.Size = new System.Drawing.Size(303, 150);
            this.DataGridView.TabIndex = 6;
            // 
            // workerListBindingSource
            // 
            this.workerListBindingSource.DataMember = "WorkerList";
            this.workerListBindingSource.DataSource = this.companyBindingSource;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.SimulateWork);
            this.groupBox3.Location = new System.Drawing.Point(12, 165);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(221, 212);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(201, 22);
            this.textBox1.TabIndex = 10;
            this.textBox1.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 48);
            this.label1.TabIndex = 9;
            this.label1.Text = "Введите количество дней,\r\nв течение которых\r\n будет симулированна работа\r\n";
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.fullNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataSource = typeof(LabaSixThirdSemester.Company);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(800, 703);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Company";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerListBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateWorker;
        private System.Windows.Forms.Button FireWorker;
        private System.Windows.Forms.Button SimulateWork;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtHourlyWorker;
        private System.Windows.Forms.RadioButton rbtCommisionWorker;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.BindingSource workerListBindingSource;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

