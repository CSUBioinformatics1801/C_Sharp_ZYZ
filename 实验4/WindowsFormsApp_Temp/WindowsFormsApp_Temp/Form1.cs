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
        public int Log_times = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("No Empty Text", "Tips");
            }
            else //not null
            {
                if (textBox1.Text != "1234" && textBox2.Text != "1234")
                {
                    if (Log_times < 3)
                    {
                        Log_times++;
                        MessageBox.Show("You can try {0} times","Tips");
                        if (Log_times == 1)
                        {
                            label3.Visible = true;
                            label3.Text = $"{3 - Log_times} times remain";
                        }
                    }
                    else
                    {
                        MessageBox.Show("No More Guessing", "Tips");
                        button1.ForeColor = Color.FromArgb(255, 255, 0, 0);
                        button1.Enabled = false;    
                    }
                }
                else
                {
                    MessageBox.Show("Log in successfully!", "Tips");
                }
            }
        }
    }
}
