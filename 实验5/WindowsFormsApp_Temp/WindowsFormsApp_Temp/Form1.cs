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
        public int F_size = 9;
        public string F_font = "宋体";
        public Form1()
        {
            InitializeComponent();
            foreach (ToolStripItem fontitem in fontToolStripMenuItem.DropDownItems) fontitem.Click += change_F_font; 
            foreach (ToolStripItem fontitem in sizeToolStripMenuItem.DropDownItems) fontitem.Click += change_F_size;
        }
        public void change_F_font(object sender, EventArgs e)
        {
            ToolStripItem selected = (ToolStripItem)sender;
            if (selected.Text != "") F_font = selected.Text;
           // textBox1.Text = F_font;
            change_label();
        }
        public void change_F_size(object sender, EventArgs e)
        {
            ToolStripItem selected = (ToolStripItem)sender;
            if (selected.Text != "") F_size = int.Parse(selected.Text);
            //textBox1.Text = F_size.ToString();
            change_label();
        }
        public void change_label()
        {
            label1.Font = new Font(F_font, F_size);
        }
    }
}
