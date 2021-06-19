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
    public partial class Form3 : Form
    {
        Random rd1 = new Random(1);
        Random rd2 = new Random(2);
        int []rd1_array = new int[10];
        int []rd2_array = new int[10];
        public int num1=0,num2=0;
        public Form3()
        {
            InitializeComponent();
            for(int i = 0; i < 10; i++)
            {
                rd1_array[i] = rd1.Next(10, 99);
                rd2_array[i] = rd2.Next(10, 99);
            }
            listBox1.DataSource = rd1_array;
            listBox2.DataSource = rd2_array;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            label6.Text = listBox2.Text;
            num2 = Int32.Parse(listBox2.Text);
            count_result();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label5.Text = listBox1.Text;
            num1 = Int32.Parse(listBox1.Text);
            count_result();
        }
        private void count_result()
        {
            listBox3.Items.Add($"{num1}*{num2}={num1*num2}");
        }
    }
}
