namespace WindowsFormsApplication1
{
    partial class Priority
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
            this.btnClear = new System.Windows.Forms.Button();
            this.alertLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.avgWT = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.avgT = new System.Windows.Forms.Label();
            this.lblBT = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblAvgT = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblAT = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.process = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priorityLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.burstTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turnaroundTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waitingTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.idleT = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(951, 396);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(103, 43);
            this.btnClear.TabIndex = 30;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // alertLbl
            // 
            this.alertLbl.AutoSize = true;
            this.alertLbl.ForeColor = System.Drawing.Color.Red;
            this.alertLbl.Location = new System.Drawing.Point(21, 242);
            this.alertLbl.Name = "alertLbl";
            this.alertLbl.Size = new System.Drawing.Size(0, 20);
            this.alertLbl.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 63);
            this.label2.TabIndex = 28;
            this.label2.Text = "Priority";
            // 
            // avgWT
            // 
            this.avgWT.AutoSize = true;
            this.avgWT.Location = new System.Drawing.Point(656, 396);
            this.avgWT.Name = "avgWT";
            this.avgWT.Size = new System.Drawing.Size(18, 20);
            this.avgWT.TabIndex = 27;
            this.avgWT.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(473, 396);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Average Waiting Time:";
            // 
            // avgT
            // 
            this.avgT.AutoSize = true;
            this.avgT.Location = new System.Drawing.Point(391, 396);
            this.avgT.Name = "avgT";
            this.avgT.Size = new System.Drawing.Size(18, 20);
            this.avgT.TabIndex = 25;
            this.avgT.Text = "0";
            // 
            // lblBT
            // 
            this.lblBT.AutoSize = true;
            this.lblBT.Location = new System.Drawing.Point(12, 197);
            this.lblBT.Name = "lblBT";
            this.lblBT.Size = new System.Drawing.Size(85, 20);
            this.lblBT.TabIndex = 24;
            this.lblBT.Text = "Burst Time";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(129, 194);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(48, 26);
            this.textBox3.TabIndex = 23;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(107, 333);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(93, 37);
            this.btnCalculate.TabIndex = 22;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(124, 293);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(76, 34);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblAvgT
            // 
            this.lblAvgT.AutoSize = true;
            this.lblAvgT.Location = new System.Drawing.Point(231, 396);
            this.lblAvgT.Name = "lblAvgT";
            this.lblAvgT.Size = new System.Drawing.Size(154, 20);
            this.lblAvgT.TabIndex = 20;
            this.lblAvgT.Text = "Average turnaround:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(129, 152);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(48, 26);
            this.textBox2.TabIndex = 19;
            // 
            // lblAT
            // 
            this.lblAT.AutoSize = true;
            this.lblAT.Location = new System.Drawing.Point(12, 158);
            this.lblAT.Name = "lblAT";
            this.lblAT.Size = new System.Drawing.Size(90, 20);
            this.lblAT.TabIndex = 18;
            this.lblAT.Text = "Arrival Time";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.process,
            this.priorityLevel,
            this.arrivalTime,
            this.burstTime,
            this.turnaroundTime,
            this.waitingTime});
            this.dataGridView1.Location = new System.Drawing.Point(235, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(819, 341);
            this.dataGridView1.TabIndex = 17;
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
            // priorityLevel
            // 
            this.priorityLevel.HeaderText = "Priority";
            this.priorityLevel.Name = "priorityLevel";
            this.priorityLevel.ReadOnly = true;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Priority";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(129, 111);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(48, 26);
            this.textBox1.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(727, 396);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Total idle time:";
            // 
            // idleT
            // 
            this.idleT.AutoSize = true;
            this.idleT.Location = new System.Drawing.Point(862, 396);
            this.idleT.Name = "idleT";
            this.idleT.Size = new System.Drawing.Size(18, 20);
            this.idleT.TabIndex = 34;
            this.idleT.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 417);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 36);
            this.button1.TabIndex = 35;
            this.button1.Text = "Go back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Priority
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 465);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.idleT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
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
            this.Name = "Priority";
            this.Text = "Priority";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label alertLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label avgWT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label avgT;
        private System.Windows.Forms.Label lblBT;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblAvgT;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblAT;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn process;
        private System.Windows.Forms.DataGridViewTextBoxColumn priorityLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn burstTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn turnaroundTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn waitingTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label idleT;
        private System.Windows.Forms.Button button1;
    }
}

