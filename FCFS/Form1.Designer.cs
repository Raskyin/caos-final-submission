namespace CAOS__Memory
{
    partial class Form1
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblBlockSize = new System.Windows.Forms.Label();
            this.lblProcessSize = new System.Windows.Forms.Label();
            this.txtBlock = new System.Windows.Forms.TextBox();
            this.txtProcess = new System.Windows.Forms.TextBox();
            this.btnAddProcess = new System.Windows.Forms.Button();
            this.btnAddBlock = new System.Windows.Forms.Button();
            this.btnBestFit = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblArray = new System.Windows.Forms.Label();
            this.lblBlkSize = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.firstFit = new System.Windows.Forms.Button();
            this.Column51 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(13, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(189, 16);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Creation of  Memory Block";
            // 
            // lblBlockSize
            // 
            this.lblBlockSize.AutoSize = true;
            this.lblBlockSize.Location = new System.Drawing.Point(12, 35);
            this.lblBlockSize.Name = "lblBlockSize";
            this.lblBlockSize.Size = new System.Drawing.Size(57, 13);
            this.lblBlockSize.TabIndex = 1;
            this.lblBlockSize.Text = "Block Size";
            // 
            // lblProcessSize
            // 
            this.lblProcessSize.AutoSize = true;
            this.lblProcessSize.Location = new System.Drawing.Point(15, 199);
            this.lblProcessSize.Name = "lblProcessSize";
            this.lblProcessSize.Size = new System.Drawing.Size(68, 13);
            this.lblProcessSize.TabIndex = 1;
            this.lblProcessSize.Text = "Process Size";
            // 
            // txtBlock
            // 
            this.txtBlock.Location = new System.Drawing.Point(15, 51);
            this.txtBlock.Name = "txtBlock";
            this.txtBlock.Size = new System.Drawing.Size(183, 20);
            this.txtBlock.TabIndex = 2;
            // 
            // txtProcess
            // 
            this.txtProcess.Location = new System.Drawing.Point(15, 215);
            this.txtProcess.Name = "txtProcess";
            this.txtProcess.Size = new System.Drawing.Size(183, 20);
            this.txtProcess.TabIndex = 2;
            // 
            // btnAddProcess
            // 
            this.btnAddProcess.Location = new System.Drawing.Point(16, 329);
            this.btnAddProcess.Name = "btnAddProcess";
            this.btnAddProcess.Size = new System.Drawing.Size(182, 23);
            this.btnAddProcess.TabIndex = 4;
            this.btnAddProcess.Text = "Add Process";
            this.btnAddProcess.UseVisualStyleBackColor = true;
            this.btnAddProcess.Click += new System.EventHandler(this.btnAddProcess_Click);
            // 
            // btnAddBlock
            // 
            this.btnAddBlock.Location = new System.Drawing.Point(18, 152);
            this.btnAddBlock.Name = "btnAddBlock";
            this.btnAddBlock.Size = new System.Drawing.Size(180, 23);
            this.btnAddBlock.TabIndex = 3;
            this.btnAddBlock.Text = "Add Block";
            this.btnAddBlock.UseVisualStyleBackColor = true;
            this.btnAddBlock.Click += new System.EventHandler(this.btnAddBlock_Click);
            // 
            // btnBestFit
            // 
            this.btnBestFit.Location = new System.Drawing.Point(215, 329);
            this.btnBestFit.Name = "btnBestFit";
            this.btnBestFit.Size = new System.Drawing.Size(75, 23);
            this.btnBestFit.TabIndex = 7;
            this.btnBestFit.Text = "Best Fit";
            this.btnBestFit.UseVisualStyleBackColor = true;
            this.btnBestFit.Click += new System.EventHandler(this.btnBestFit_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column51,
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView3.Location = new System.Drawing.Point(215, 57);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(443, 261);
            this.dataGridView3.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Best Fit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Output:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(596, 324);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblArray
            // 
            this.lblArray.AutoSize = true;
            this.lblArray.Location = new System.Drawing.Point(198, 309);
            this.lblArray.Name = "lblArray";
            this.lblArray.Size = new System.Drawing.Size(0, 13);
            this.lblArray.TabIndex = 14;
            // 
            // lblBlkSize
            // 
            this.lblBlkSize.AutoSize = true;
            this.lblBlkSize.Location = new System.Drawing.Point(15, 93);
            this.lblBlkSize.Name = "lblBlkSize";
            this.lblBlkSize.Size = new System.Drawing.Size(0, 13);
            this.lblBlkSize.TabIndex = 16;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(18, 77);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(180, 69);
            this.listBox1.TabIndex = 17;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(18, 241);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(180, 82);
            this.listBox2.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(308, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Worst Fit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // firstFit
            // 
            this.firstFit.Location = new System.Drawing.Point(408, 327);
            this.firstFit.Name = "firstFit";
            this.firstFit.Size = new System.Drawing.Size(75, 23);
            this.firstFit.TabIndex = 20;
            this.firstFit.Text = "First Fit";
            this.firstFit.UseVisualStyleBackColor = true;
            this.firstFit.Click += new System.EventHandler(this.firstFit_Click);
            // 
            // Column51
            // 
            this.Column51.HeaderText = "Process No.";
            this.Column51.Name = "Column51";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Process Size";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Block No.";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Internal Fragmentation";
            this.Column3.Name = "Column3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 359);
            this.Controls.Add(this.firstFit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblBlkSize);
            this.Controls.Add(this.lblArray);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.btnBestFit);
            this.Controls.Add(this.btnAddProcess);
            this.Controls.Add(this.btnAddBlock);
            this.Controls.Add(this.txtProcess);
            this.Controls.Add(this.txtBlock);
            this.Controls.Add(this.lblProcessSize);
            this.Controls.Add(this.lblBlockSize);
            this.Controls.Add(this.lblHeader);
            this.Name = "Form1";
            this.Text = "Memory";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblBlockSize;
        private System.Windows.Forms.Label lblProcessSize;
        private System.Windows.Forms.TextBox txtBlock;
        private System.Windows.Forms.TextBox txtProcess;
        private System.Windows.Forms.Button btnAddProcess;
        private System.Windows.Forms.Button btnAddBlock;
        private System.Windows.Forms.Button btnBestFit;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblArray;
        private System.Windows.Forms.Label lblBlkSize;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button firstFit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column51;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}

