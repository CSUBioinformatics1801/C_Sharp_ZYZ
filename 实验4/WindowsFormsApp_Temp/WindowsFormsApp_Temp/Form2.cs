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
    public partial class Form2 : Form
    {//default
        public string txt_Font = "宋体";
        public int txt_Size=9;
        public FontStyle Bold_or_not = FontStyle.Regular;

        public Form2()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txt_Font = radioButton1.Text;
            set_textbox();
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txt_Font = radioButton2.Text;
            set_textbox();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) Bold_or_not = FontStyle.Bold;
            else Bold_or_not = FontStyle.Regular;
            set_textbox();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            txt_Size = Int32.Parse(radioButton3.Text);
            set_textbox();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            txt_Size = Int32.Parse(radioButton4.Text);
            set_textbox();
        }
        public void set_textbox()
        {
            textBox1.Font = new Font(txt_Font, txt_Size, Bold_or_not);
        }
    }
}
