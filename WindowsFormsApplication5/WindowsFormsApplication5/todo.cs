using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show(ofd.FileName);
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "CSV Files (*.csv)|*.csv";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                DataTable table = CSVReader.ReadCSVFile(DialogResult, FileName, true);
                dataGridView1.DataSource = table;
                {
                    MessageBox.Show(ofd.FileName);

                }
            }
        }
    }
}