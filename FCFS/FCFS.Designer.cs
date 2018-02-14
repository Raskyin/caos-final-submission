namespace WindowsFormsApplication1
{
    partial class FCFS
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.process = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.burstTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turnaroundTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waitingTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblAT = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblAvgT = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblBT = new System.Windows.Forms.Label();
            this.avgT = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.avgWT = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.alertLbl = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.idleT = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.process,
            this.arrivalTime,
            this.burstTime,
            this.turnaroundTime,
            this.waitingTime});
            this.dataGridView1.Location = new System.Drawing.Point(224, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(819, 341);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // process
            // 
            this.process.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.process.HeaderText = "Process";
            this.process.MinimumWidth = 8;
            this.process.Name = "process";
            this.process.ReadOnly = true;
            this.process.Width = 102;
            // 
            // arrivalTime
            // 
            this.arrivalTime.HeaderText = "Arrival Time";
            this.arrivalTime.MinimumWidth = 10;
            this.arrivalTime.Name = "arrivalTime";
            this.arrivalTime.ReadOnly = true;
            // 
            // burstTime
            // 
            this.burstTime.HeaderText = "Burst Time";
            this.burstTime.MinimumWidth = 10;
            this.burstTime.Name = "burstTime";
            this.burstTime.ReadOnly = true;
            // 
            // turnaroundTime
            // 
            this.turnaroundTime.HeaderText = "Turnaround Time";
            this.turnaroundTime.MinimumWidth = 10;
            this.turnaroundTime.Name = "turnaroundTime";
            this.turnaroundTime.ReadOnly = true;
            // 
            // waitingTime
            // 
            this.waitingTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.waitingTime.HeaderText = "Waiting Time";
            this.waitingTime.MinimumWidth = 8;
            this.waitingTime.Name = "waitingTime";
            this.waitingTime.ReadOnly = true;
            this.waitingTime.Width = 125;
            // 
            // lblAT
            // 
            this.lblAT.AutoSize = true;
            this.lblAT.Location = new System.Drawing.Point(8, 96);
            this.lblAT.Name = "lblAT";
            this.lblAT.Size = new System.Drawing.Size(90, 20);
            this.lblAT.TabIndex = 2;
            this.lblAT.Text = "Arrival Time";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(118, 90);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(48, 26);
            this.textBox2.TabIndex = 4;
            // 
            // lblAvgT
            // 
            this.lblAvgT.AutoSize = true;
            this.lblAvgT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgT.Location = new System.Drawing.Point(220, 388);
            this.lblAvgT.Name = "lblAvgT";
            this.lblAvgT.Size = new System.Drawing.Size(154, 20);
            this.lblAvgT.TabIndex = 5;
            this.lblAvgT.Text = "Average turnaround:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(90, 218);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(76, 34);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(73, 258);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(93, 37);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(118, 137);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(48, 26);
            this.textBox3.TabIndex = 9;
            // 
            // lblBT
            // 
            this.lblBT.AutoSize = true;
            this.lblBT.Location = new System.Drawing.Point(8, 140);
            this.lblBT.Name = "lblBT";
            this.lblBT.Size = new System.Drawing.Size(85, 20);
            this.lblBT.TabIndex = 10;
            this.lblBT.Text = "Burst Time";
            // 
            // avgT
            // 
            this.avgT.AutoSize = true;
            this.avgT.Location = new System.Drawing.Point(392, 388);
            this.avgT.Name = "avgT";
            this.avgT.Size = new System.Drawing.Size(18, 20);
            this.avgT.TabIndex = 11;
            this.avgT.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(490, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Average Waiting Time:";
            // 
            // avgWT
            // 
            this.avgWT.AutoSize = true;
            this.avgWT.Location = new System.Drawing.Point(672, 388);
            this.avgWT.Name = "avgWT";
            this.avgWT.Size = new System.Drawing.Size(18, 20);
            this.avgWT.TabIndex = 13;
            this.avgWT.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 56);
            this.label2.TabIndex = 14;
            this.label2.Text = "FCFS";
            // 
            // alertLbl
            // 
            this.alertLbl.AutoSize = true;
            this.alertLbl.ForeColor = System.Drawing.Color.Red;
            this.alertLbl.Location = new System.Drawing.Point(16, 177);
            this.alertLbl.Name = "alertLbl";
            this.alertLbl.Size = new System.Drawing.Size(0, 20);
            this.alertLbl.TabIndex = 15;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(940, 388);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(103, 43);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(717, 387);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Total idle time:";
            // 
            // idleT
            // 
            this.idleT.AutoSize = true;
            this.idleT.Location = new System.Drawing.Point(834, 387);
            this.idleT.Name = "idleT";
            this.idleT.Size = new System.Drawing.Size(18, 20);
            this.idleT.TabIndex = 18;
            this.idleT.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 42);
            this.button1.TabIndex = 19;
            this.button1.Text = "Go back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FCFS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 443);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.idleT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.alertLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.avgWT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.avgT);
            this.Controls.Add(this.lblBT);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblAvgT);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblAT);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FCFS";
            this.Text = "First Come First Served";
            this.Load += new System.EventHandler(this.FCFS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblAT;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblAvgT;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblBT;
        private System.Windows.Forms.Label avgT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label avgWT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn process;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn burstTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn turnaroundTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn waitingTime;
        private System.Windows.Forms.Label alertLbl;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label idleT;
        private System.Windows.Forms.Button button1;
    }
}

