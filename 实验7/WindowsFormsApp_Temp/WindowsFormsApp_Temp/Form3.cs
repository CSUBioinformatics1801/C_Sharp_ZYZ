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
        public Form3()
        {
            InitializeComponent();         
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            this.table_scoreTableAdapter.Fill(this.temp_dbDataSet.Table_score);
        }

        private void 保存SToolStripButton_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Sure to store?", "Confirm Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Validate();
                this.bindingSource1.EndEdit();
                this.table_scoreTableAdapter.Update(this.temp_dbDataSet.Table_score);
                this.temp_dbDataSet.AcceptChanges();
                MessageBox.Show("Update successfully!");
            }
        }
    }
}
