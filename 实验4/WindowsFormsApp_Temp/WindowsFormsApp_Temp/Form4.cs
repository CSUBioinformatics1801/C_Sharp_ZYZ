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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            comboBox1.Items.Add(new string[] {"Geiraner", "Balestrand", "L.A."});
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (comboBox1.Text.Trim() == "" && Keys.Enter==e.KeyCode)
            {// check empty
                MessageBox.Show("No Empty Input!","Oops!",MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation);
            }
            else if(Keys.Enter == e.KeyCode)
            {//check exist
                if (comboBox1.Items.Contains(comboBox1.Text))
                {
                    label2.Visible = true;
                    label3.Visible = false;
                }
                else
                {
                    label2.Visible = false;
                    label3.Visible = true;
                    comboBox1.Items.Add(comboBox1.Text);
                }
            }
        }
    }
}
