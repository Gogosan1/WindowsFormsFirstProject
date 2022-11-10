namespace LabaSixThirdSemester
{
    partial class CommisionWorkerConstructor
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CreateWorker = new System.Windows.Forms.Button();
            this.Percentage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Salary = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GetGender = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.WorkerName = new System.Windows.Forms.TextBox();
            this.text1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CreateWorker);
            this.groupBox1.Controls.Add(this.Percentage);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Salary);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.GetGender);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.WorkerName);
            this.groupBox1.Controls.Add(this.text1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 400);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // CreateWorker
            // 
            this.CreateWorker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateWorker.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CreateWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.CreateWorker.Location = new System.Drawing.Point(3, 358);
            this.CreateWorker.Name = "CreateWorker";
            this.CreateWorker.Size = new System.Drawing.Size(376, 39);
            this.CreateWorker.TabIndex = 8;
            this.CreateWorker.Text = "Нанять сотрудника";
            this.CreateWorker.UseVisualStyleBackColor = true;
            this.CreateWorker.Click += new System.EventHandler(this.CreateWorker_Click);
            // 
            // Percentage
            // 
            this.Percentage.Location = new System.Drawing.Point(207, 216);
            this.Percentage.Name = "Percentage";
            this.Percentage.Size = new System.Drawing.Size(123, 22);
            this.Percentage.TabIndex = 7;
            this.Percentage.Validating += new System.ComponentModel.CancelEventHandler(this.Percentage_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Процент с продаж";
            // 
            // Salary
            // 
            this.Salary.Location = new System.Drawing.Point(207, 171);
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(123, 22);
            this.Salary.TabIndex = 5;
            this.Salary.Validating += new System.ComponentModel.CancelEventHandler(this.Salary_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Оклад";
            // 
            // GetGender
            // 
            this.GetGender.FormattingEnabled = true;
            this.GetGender.HorizontalScrollbar = true;
            this.GetGender.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.GetGender.ItemHeight = 16;
            this.GetGender.Items.AddRange(new object[] {
            "Мужчина",
            "Женщина"});
            this.GetGender.Location = new System.Drawing.Point(207, 124);
            this.GetGender.Name = "GetGender";
            this.GetGender.Size = new System.Drawing.Size(120, 20);
            this.GetGender.TabIndex = 3;
            this.GetGender.SelectedIndexChanged += new System.EventHandler(this.GetGender_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите пол";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WorkerName
            // 
            this.WorkerName.Location = new System.Drawing.Point(207, 66);
            this.WorkerName.Name = "WorkerName";
            this.WorkerName.Size = new System.Drawing.Size(123, 22);
            this.WorkerName.TabIndex = 1;
            this.WorkerName.Validating += new System.ComponentModel.CancelEventHandler(this.WorkerName_Validating);
            // 
            // text1
            // 
            this.text1.AutoSize = true;
            this.text1.Location = new System.Drawing.Point(6, 66);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(113, 16);
            this.text1.TabIndex = 0;
            this.text1.Text = "Имя сотрудника";
            // 
            // CommisionWorkerConstructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 453);
            this.Controls.Add(this.groupBox1);
            this.Name = "CommisionWorkerConstructor";
            this.Text = "Create commision wage worker";
            this.Load += new System.EventHandler(this.CommisionWorkerConstructor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox WorkerName;
        private System.Windows.Forms.Label text1;
        private System.Windows.Forms.ListBox GetGender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Percentage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Salary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CreateWorker;
    }
}