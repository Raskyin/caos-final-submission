using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace CAOS__Memory
{
    public partial class Form1 : Form
    {


        int[] blockSize = { };
        int[] processSize = { };
        int total = 0;


        List<int> memory = new List<int>();
        List<int> process = new List<int>();

        public Form1()
        {
            InitializeComponent();



        }

        protected void btnAddProcess_Click(object sender, EventArgs e)
        {
            total = Int32.Parse(txtProcess.Text);
            process.Add(total);
            txtProcess.Clear();

            listBox2.Items.Add(total);


        }

        protected void btnAddBlock_Click(object sender, EventArgs e)
        {
            total = Int32.Parse(txtBlock.Text);
            memory.Add(total);
            txtBlock.Clear();

            listBox1.Items.Add(total);

        }

        private void btnBestFit_Click(object sender, EventArgs e)
        {


            processSize = process.ToArray();
            blockSize = memory.ToArray();


            memory.Clear();
            process.Clear();
           

            int n = processSize.Length;
            int m = blockSize.Length;

            int[] allocation = new int[n];

            for (int i = 0; i < allocation.Length; i++)
            {
                allocation[i] = -1;
            }

            for (int i = 0; i < n; i++)
            {
                int bestIdx = -1;

                for (int j = 0; j < m; j++)
                {
                    if (blockSize[j] >= processSize[i])
                    {
                        if (bestIdx == -1)
                        {
                            bestIdx = j;
                        }
                        else if (blockSize[bestIdx] > blockSize[j])
                        {
                            bestIdx = j;
                        }
                    }

                }
                if (bestIdx != -1)
                {
                    allocation[i] = bestIdx;
                    blockSize[bestIdx] -= processSize[i];
                  //  checker[i] = 1;

                }
            }


          /*  for (int p = 0; p < checker.Length; p++)
            {
                if (checker[p] == 1)
                {
                    frag = intFrag += checker[p];

                }
            }
            */

            for (int i = 0; i < n; i++)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView3.Rows[0].Clone();

                row.Cells[0].Value = (i + 1);
                row.Cells[1].Value = (processSize[i]);
               // row.Cells[3].Value = frag;


                if (allocation[i] != -1)
                {
                    row.Cells[2].Value = (allocation[i] + 1);

                }
                else
                {
                    row.Cells[2].Value = ("Not Allocated");

                }

                dataGridView3.Rows.Add(row);
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            dataGridView3.Rows.Clear();
            Array.Clear(processSize, 0, processSize.Length);
            Array.Clear(blockSize, 0, blockSize.Length);
           // Array.Clear(checker, 0, blockSize.Length);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            processSize = process.ToArray();
            blockSize = memory.ToArray();

            memory.Clear();
            process.Clear();

            int n = processSize.Length;
            int m = blockSize.Length;

            int[] allocation = new int[n];

            for (int i = 0; i < allocation.Length; i++)
            {
                allocation[i] = -1;
            }

            for (int i = 0; i < n; i++)
            {
                int bestIdx = -1;

                for (int j = 0; j < m; j++)
                {
                    if (blockSize[j] >= processSize[i])
                    {
                        if (bestIdx == -1)
                        {
                            bestIdx = j;
                        }
                        else if (blockSize[bestIdx] < blockSize[j])
                        {
                            bestIdx = j;
                        }
                    }

                }
                if (bestIdx != -1)
                {
                    allocation[i] = bestIdx;
                    blockSize[bestIdx] -= processSize[i];
                }
            }


            for (int i = 0; i < n; i++)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView3.Rows[0].Clone();

                row.Cells[0].Value = (i + 1);
                row.Cells[1].Value = (processSize[i]);


                if (allocation[i] != -1)
                {
                    row.Cells[2].Value = (allocation[i] + 1);

                }
                else
                {
                    row.Cells[2].Value = ("Not Allocated");

                }

                dataGridView3.Rows.Add(row);
            }
        }

        private void firstFit_Click(object sender, EventArgs e)
        {
            processSize = process.ToArray();
            blockSize = memory.ToArray();

            memory.Clear();
            process.Clear();

            int n = processSize.Length;
            int m = blockSize.Length;

            for (int i = 0; i < n; i++)
            {
                for (int y = 0; y < m; y++)
                {
                    if (blockSize[y] >= processSize[i])
                    {
                        memory[y] -= processSize[i];

                        break;


                    }


                }
            }


        }
    }
}
