using System;
//using System.Timers;
namespace Test5_4
{
    public class teacher
    {
        public string teacher_name;
        public teacher(string name)
        {
            this.teacher_name = name;
        }
        public delegate void Exam_Handler();
        public event Exam_Handler start_exam;
        public void exam_begin()
        {
            if (start_exam != null)
            {
                Console.WriteLine($"Exam begins hold by {this.teacher_name}.");
                start_exam();
            }
        }
        public void exam_teacher_end(string student_name)
        {
            Console.WriteLine($"{this.teacher_name} has get {student_name}'s paper.");
        }
    }
    class student
    {
        public string student_name;
        public student(string name)
        {
            this.student_name = name;
        }
        public void student_exam_start()
        {
            Console.WriteLine($"Student {this.student_name}\t starts by {DateTime.Now}");
        }
        public void start_exam_end()
        {
            Console.WriteLine("After a while...");
            Console.WriteLine($"\tStudent {this.student_name}\t finishes the exam at {DateTime.Now}");
        }
    }
    public class Program
    {
        public static void Main()
        {
            Random rd = new Random();
            int[] Random_i = new int[4];
            foreach (int i in Random_i)
            {
                Random_i[i] = rd.Next(4000, 5000);
                //Console.WriteLine(Random_i[i]);
            }
            teacher t1 = new teacher("Professor Lee");
            student[] students = new student[]{
                new student("Ian"),new student("Barley"),
                new student("Laurel"),new student("Colt")
            };
            int Random_count = 0;//active time count
            foreach (var s in students)
            {
                t1.start_exam += new teacher.Exam_Handler(s.student_exam_start);
                // time_counter = new Timer();
                // time_counter.Interval=Random_i[Random_count]+1;
                // time_counter.Elapsed+=s.start_exam_end;
                // time_counter.AutoReset=true;
                // time_counter.Enabled=true;
                // time_counter.Start();
            }
            t1.exam_begin();
            foreach (var s in students)
            {
                System.Threading.Thread.Sleep(Random_i[Random_count] + 1000);
                Random_count++;
                s.start_exam_end();
            }
        }
        //private static Timer time_counter;
    }
}
