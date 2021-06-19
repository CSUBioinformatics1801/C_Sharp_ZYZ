using System;
namespace t2
{
    class Stud
    {
        DateTime student_Liming, student_WangLi;

        public void Input_datetime()
        {
            Console.WriteLine("Input Student Liming's birth datetime like \"2020-2-26\".");
            student_Liming = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Input Student WangLi's birth datetime like \"2020-2-26\".");
            student_WangLi = DateTime.Parse(Console.ReadLine());
        }
        public void Display()
        {
            Console.WriteLine("Liming was born on " + student_Liming.GetDateTimeFormats('r')[0].ToString());
            Console.WriteLine("WangLi was born on " + student_WangLi.GetDateTimeFormats('r')[0].ToString());
            TimeSpan span_of_2Students = student_WangLi.Subtract(student_Liming).Duration();
            Console.Write("Birthtime span of WangLi & Liming: " + span_of_2Students.ToString() + " days.");
        }
    }

    class test3_1
    {
        static void Main(string[] args)
        {
            Stud r = new Stud();
            r.Input_datetime();
            r.Display();
            Console.ReadLine();
        }
    }
}