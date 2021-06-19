using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Temp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           this.table_scoreTableAdapter.Fill(this.temp_dbDataSet.Table_score);
            listBox1.Items.Clear();
            listBox1.Items.Add("St_ID\tSt_Name\t\tSubject\t\t\tScore");
            listBox1.Items.Add("===================================================");
            foreach(DataRow i in temp_dbDataSet.Table_score.Rows)
            {
                listBox1.Items.Add(string.Join("\t",i.ItemArray));
            }
        }
    }
}
