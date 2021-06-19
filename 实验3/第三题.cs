using System;
namespace Test6_3
{
    class Person
    {
        public int ID;
        public string Name;
        public virtual void input_ID_Name()
        {
            Console.WriteLine("Input ID & Name like\"1001-Anna\"");
            string temp_string = Console.ReadLine();
            string[] t_s_array = temp_string.Split('-');
            ID = Int32.Parse(t_s_array[0]);
            Name = t_s_array[1];
        }
        public override string ToString()
        {
            return "ID: " + ID + " Name: " + Name;
        }
    }
    class Student : Person
    {
        string class_ID;
        double GPA;
        public override void input_ID_Name()
        {
            Console.WriteLine("Student:\nInput ID, Name, class ID and GPA like\"1001-Anna-1821-6.21\"");
            string temp_string = Console.ReadLine();
            string[] t_s_array = temp_string.Split('-');
            ID = Int32.Parse(t_s_array[0]);
            Name = t_s_array[1];
            class_ID = t_s_array[2];
            GPA = double.Parse(t_s_array[3]);
        }
        public string add_string_Student()
        {
            return "Class ID: " + class_ID + " GPA: " + GPA;
        }
    }
    class Teacher : Person
    {
        string department, professional_title;
        public override void input_ID_Name()
        {
            Console.WriteLine("Teacher:\nInput ID, Name, department and Professional title like\"1002-Elsa-Arendelle-Queen\"");
            string temp_string = Console.ReadLine();
            string[] t_s_array = temp_string.Split('-');
            ID = Int32.Parse(t_s_array[0]);
            Name = t_s_array[1];
            department = t_s_array[2];
            professional_title = t_s_array[3];
        }
        public string add_string_Teacher()
        {
            return "Department: " + department + " Professional title: " + professional_title;
        }
    }
    public class Program
    {
        public static void Main()
        {
            Student s = new Student();
            Teacher t = new Teacher();
            s.input_ID_Name();
            Console.WriteLine(s.ToString() + s.add_string_Student() + "\n");
            t.input_ID_Name();
            Console.WriteLine(t.ToString() + t.add_string_Teacher());
        }
    }
}
