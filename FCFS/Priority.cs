using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Priority : Form
    {
        int processCount = 1;
        int totalTime;
        int idle;
        bool status;
        int priority;
        int[] temp ={0,0,0,0};
        bool chck;
        
        public Priority()
        {
            InitializeComponent();
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text))
            {
                alertLbl.Text = "Please fill in the blanks.";
            }
            else
            {
                int row = 0;
                dataGridView1.Rows.Add();
                row = dataGridView1.Rows.Count - 2;

                dataGridView1["process", row].Value = Convert.ToString(processCount++);
                dataGridView1["arrivalTime", row].Value = textBox2.Text;
                dataGridView1["burstTime", row].Value = textBox3.Text;
                dataGridView1["priorityLevel", row].Value = Convert.ToString(textBox1.Text);
                textBox2.Clear();
                textBox3.Clear();
                textBox1.Clear();
                alertLbl.Text = "";
            }
            status = true;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (status == true)
            {
                double sum = 0.0;
                double sum2 = 0.0;
                this.dataGridView1.Sort(dataGridView1.Columns["arrivalTime"], ListSortDirection.Ascending);
                for (int y = 0; y < dataGridView1.Rows.Count - 1; y++)//priority
                {
                    int x=y;
                    if (Convert.ToInt32(dataGridView1.Rows[y].Cells[2].Value) > totalTime) // if arrivaltime>totalTime
                    {
                        idle += Convert.ToInt32(dataGridView1.Rows[y].Cells[2].Value) - totalTime;
                        totalTime = Convert.ToInt32(dataGridView1.Rows[y].Cells[2].Value);

                    }

                    for(x=y;x<dataGridView1.Rows.Count-1;x++)//check and sort until all correct

                    {
                        if(Convert.ToInt32(dataGridView1.Rows[x].Cells[2].Value)<=totalTime && Convert.ToInt32(dataGridView1.Rows[x+1].Cells[2].Value)<=totalTime && Convert.ToInt32(dataGridView1.Rows[x].Cells[1].Value)<Convert.ToInt32(dataGridView1.Rows[x+1].Cells[1].Value))
                        {
                            chck = true;
                            for(int z=0;z<4;z++){
                                temp[z]=Convert.ToInt32(dataGridView1.Rows[x].Cells[z].Value);
                            }
                            for(int z=0;z<4;z++){
                                dataGridView1.Rows[x].Cells[z].Value=dataGridView1.Rows[x+1].Cells[z].Value;
                            }
                            for(int z=0;z<4;z++){
                                dataGridView1.Rows[x+1].Cells[z].Value=temp[z];
                            }
                        }
                        else if(Convert.ToInt32(dataGridView1.Rows[x+1].Cells[2].Value)>totalTime)
                        {
                            if (chck==true)
                            {
                                chck = false;
                                x=y;
                            }
                            else
                            {break;}
                        }
                    }
                    totalTime += Convert.ToInt32(dataGridView1.Rows[y].Cells[3].Value);

                    dataGridView1["turnaroundTime", y].Value = Convert.ToString(totalTime - (Convert.ToInt32(dataGridView1.Rows[y].Cells[2].Value)));
                    dataGridView1["waitingTime", y].Value = Convert.ToString(((Convert.ToInt32(dataGridView1.Rows[y].Cells[4].Value)) - (Convert.ToInt32(dataGridView1.Rows[y].Cells[3].Value))));
                    sum += Convert.ToInt32(dataGridView1.Rows[y].Cells[4].Value);
                    sum2 += Convert.ToInt32(dataGridView1.Rows[y].Cells[5].Value);

                }
                avgT.Text = Convert.ToString(Convert.ToDecimal(sum / (dataGridView1.RowCount - 1)));
                avgWT.Text = Convert.ToString(Convert.ToDouble(sum2 / (dataGridView1.RowCount - 1)));
                idleT.Text = Convert.ToString(idle);
                if (sum == 0.0 && sum2 == 0.0)
                {
                    avgT.Text = "0";
                    avgWT.Text = "0";
                }
                status = false;
            }
            else
                alertLbl.Text = "Please fill in the blanks.";
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            processCount = 1;
            totalTime = 0;
            idle = 0;
            alertLbl.Text = "";
            avgT.Text = "0";
            avgWT.Text = "0";
            textBox2.Clear();
            textBox1.Clear();
            textBox3.Clear();
            idleT.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home f4 = new Home();
            f4.ShowDialog();
            this.Close();
        }
    }
}

              /* // priority
                double sum = 0.0;
                double sum2 = 0.0;
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                
                    if (Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value) > totalTime) // if arrivaltime>totalTime
                    {
                        idle += Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value) - totalTime;
                        totalTime = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);

                    }
                    for (int x=0; x < dataGridView1.Rows.Count - 1; x++)
                    {
                        if(x==i)
                    }
                }
                    totalTime += Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);

                    dataGridView1["turnaroundTime", i].Value = Convert.ToString(totalTime - (Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value)));
                    dataGridView1["waitingTime", i].Value = Convert.ToString((totalTime - (Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value)) - (Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value))));
                    sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
                    sum2 += Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);
                }

                avgT.Text = Convert.ToString(sum / (dataGridView1.RowCount - 1));
                avgWT.Text = Convert.ToString(Convert.ToDouble(sum2 / (dataGridView1.RowCount - 1)));
                idleT.Text = Convert.ToString(idle);
                if (sum == 0.0 && sum2 == 0.0)
                {
                    avgT.Text = "0";
                    avgWT.Text = "0";
                }
            }
            else
                alertLbl.Text = "Please fill in the blanks.";
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            processCount = 1;
            totalTime = 0;
            idle = 0;
            alertLbl.Text = "";
            avgT.Text = "0";
            avgWT.Text = "0";
            textBox2.Clear();
            textBox1.Clear();
            textBox3.Clear();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FCFS_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home f4 = new Home();
            f4.ShowDialog();
            this.Close();
        }

    }
}
*/