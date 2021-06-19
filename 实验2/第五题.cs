using System;
using System.Collections.Generic;
namespace Test5_4
{
    public class Course : IEquatable<Course>// for example: corese_ID=1, credit=2,score=90
    {
        public int credit { get; set; }
        public int Subject_ID { get; set; }
        public int score { get; set; }
        public override string ToString()
        {
            return Subject_ID + "\t" + credit + "\t" + score;
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Course objAsPart = obj as Course;
            if (objAsPart == null) return false;
            else return Equals(objAsPart);
        }
        public override int GetHashCode()
        {
            return Subject_ID;
        }
        public bool Equals(Course other)
        {
            if (other == null) return false;
            return (this.Subject_ID.Equals(other.Subject_ID));
        }
        // Should also override == and != operators.
    }

    public class Student
    {// for example: Student=Bjorn: Subject_ID=1, score=80...
        public string St_Name;
        public Student(string St_Name)
        {
            this.St_Name = St_Name;
        }
        public List<Course> courses = new List<Course>(10);
        public double Common_GPA = 0, Standard_GPA = 0;
        public void input_Course_info()
        {
            Console.WriteLine("Input course info of the student like this: Subject_ID-credit-score");
            string temp_string = Console.ReadLine();
            while (temp_string != "")
            {
                string[] t_s_array = temp_string.Split('-');
                courses.Add(new Course() { Subject_ID = int.Parse(t_s_array[0]), credit = int.Parse(t_s_array[1]), score = int.Parse(t_s_array[2]) });
                temp_string = Console.ReadLine();
            }// Add courses to the list of a student.
            Console.WriteLine("Sub_ID\tcredit\tscore");
            foreach (Course i in courses)
            {
                Console.WriteLine(i);
            }
        }
        public void Get_Both_GPA(List<Course> courses)
        {
            int sum_credit = 0;
            foreach (Course i in courses)
            {
                if (i.score > 60)
                {
                    Common_GPA += (int)((i.score - 50) / 10) * i.credit;
                    Standard_GPA += ((double)(i.score - 60) / 10.00) * i.credit;
                    sum_credit += i.credit;
                }
                else
                {
                    sum_credit += i.credit;
                }
            }
            Common_GPA /= sum_credit;
            Standard_GPA /= sum_credit;
        }
    }
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Input a student's name:");
            string temp_st_name = Console.ReadLine();
            Student st1 = new Student(temp_st_name);//only one student for the test
            st1.input_Course_info();
            st1.Get_Both_GPA(st1.courses);
            Console.WriteLine("Student Name: {0}\tCommon GPA: {1:N2}, Standard GPA: {2:N2}", st1.St_Name, st1.Common_GPA, st1.Standard_GPA);
        }

    }
}
