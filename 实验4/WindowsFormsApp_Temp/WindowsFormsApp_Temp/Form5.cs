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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            List<Student> students = new List<Student>(3);
            students.Add(new Student(1, "Aragorn", 0, 1001, "3019-03-01"));
            students.Add(new Student(2, "Arwen", 1, 1002, "241-01-01"));
            students.Add(new Student(3, "Gandalf", 0, 1003, "1000-01-01"));
            comboBox1.DataSource = students;
            comboBox1.DisplayMember = "Student_ID";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Student seleted = (Student)comboBox1.SelectedItem;
            textBox_ID.Text = seleted.Student_ID.ToString();
            textBox_Name.Text = seleted.Student_name;
            textBox_sex.Text = seleted.sex;
            textBox_class.Text = seleted.St_Class.ToString();
            textBox_birthdate.Text = seleted.Birthdate.ToString("d");
        }
    }
    class Student
    {
        public int Student_ID { get; set; }
        public string Student_name { set; get; }
        public string sex { get; set; }
        public int St_Class { get; set; }
        public DateTime Birthdate { get; set; }//"2000-01-01"
        public Student(int St_ID, string St_name,int sex,int st_class,string birthdate) 
        {
            this.Student_ID = St_ID;
            this.Student_name = St_name;
            if (sex == 0) this.sex = "Male";
            else if (sex == 1) this.sex = "Female";
            else this.sex = "other";
            this.St_Class = st_class;
            Birthdate = Convert.ToDateTime(birthdate);
        }
    }
}
