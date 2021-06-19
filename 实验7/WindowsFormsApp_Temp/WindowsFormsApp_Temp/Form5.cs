using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp_Temp
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            if(pre_load())default_set();//ensure default_set() is executed after pre_load();
            this.table_scoreTableAdapter.Fill(this.temp_dbDataSet.Table_score);
        }
        public bool pre_load()
        {
            //fill the combobox_sub
            comboBox_sub.Items.Add("All");
            SqlConnection sqlcon = new SqlConnection();
            sqlcon.ConnectionString = "integrated security=sspi; server =localhost; database = Temp_db";
            SqlCommand sqlcmd_fill_combo_sub = new SqlCommand();
            sqlcmd_fill_combo_sub.Connection = sqlcon;
            sqlcmd_fill_combo_sub.CommandType = CommandType.Text;
            sqlcmd_fill_combo_sub.CommandText = "select distinct Subject_name from dbo.Table_score";
            sqlcon.Open();
            SqlDataReader dataReader_sub = sqlcmd_fill_combo_sub.ExecuteReader();
            while (dataReader_sub.Read())
            {
                comboBox_sub.Items.Add(dataReader_sub["Subject_name"].ToString().Trim());
            }
            dataReader_sub.Close();
            sqlcon.Close();
            //fill the combobox_column
            for (int i=0;i<temp_dbDataSet.Tables[0].Columns.Count;i++)
            {
                comboBox_column.Items.Add(temp_dbDataSet.Tables[0].Columns[i].ColumnName);
            }
            return true;
        }
        public void default_set()
        {
            comboBox_sub.SelectedIndex = 0;
            comboBox_column.SelectedIndex = 0;
            radioButton_ASC.Checked = true;
            textBox_id_search.Text = "";
        }
        private void button_reset_Click(object sender, EventArgs e)
        {
            default_set();//return default
            dataGridView1.DataSource = tablescoreBindingSource;
        }
        private void button_sort_Click(object sender, EventArgs e)
        {
            if (radioButton_ASC.Checked == false) dataGridView1.Sort(dataGridView1.Columns[comboBox_column.SelectedIndex], ListSortDirection.Descending);
            else dataGridView1.Sort(dataGridView1.Columns[comboBox_column.SelectedIndex], ListSortDirection.Ascending);
        }
        private void button_search_Click(object sender, EventArgs e)
        {
            if (textBox_id_search.Text.Trim() == "")//avoid null
            {
                MessageBox.Show("Come on! You gonna type in something!");
                return;
            }
            string selected_cb = comboBox_sub.SelectedItem.ToString().Trim();
            if (comboBox_sub.SelectedIndex != 0)//all
            {
                DataView dv1 = new DataView(this.temp_dbDataSet.Table_score, $"St_ID='{textBox_id_search.Text}'", "St_ID ASC", DataViewRowState.CurrentRows);
                dataGridView1.DataSource = dv1;
            }
            else
            {
                DataView dv2 = new DataView(this.temp_dbDataSet.Table_score, $"Subject_name='{selected_cb}' AND St_ID='{textBox_id_search.Text}'", "St_ID ASC", DataViewRowState.CurrentRows);
                dataGridView1.DataSource = dv2;
            }
        }
    }
}
