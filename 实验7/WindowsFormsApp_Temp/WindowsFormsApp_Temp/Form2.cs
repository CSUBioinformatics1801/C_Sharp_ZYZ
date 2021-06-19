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
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            this.table_scoreTableAdapter.Fill(this.temp_dbDataSet.Table_score);
        }
        private void button_fore_Click(object sender, EventArgs e)
        {
            if (tablescoreBindingSource.Position != 0) tablescoreBindingSource.MovePrevious();
            else MessageBox.Show("It's been the first record!"); 
        }
        private void button_next_Click(object sender, EventArgs e)
        {
            if (tablescoreBindingSource.Position != tablescoreBindingSource.Count-1) tablescoreBindingSource.MoveNext();
            else MessageBox.Show("It's been the last record!");
        }
        private void button_end_Click(object sender, EventArgs e)
        {
            if (tablescoreBindingSource.Position != tablescoreBindingSource.Count - 1) tablescoreBindingSource.MoveLast();
            else MessageBox.Show("It's been the last record!");
        }
        private void button_home_Click(object sender, EventArgs e)
        {
            if (tablescoreBindingSource.Position != 0) tablescoreBindingSource.MoveFirst();
            else MessageBox.Show("It's been the first record!");           
        }
    }
}
