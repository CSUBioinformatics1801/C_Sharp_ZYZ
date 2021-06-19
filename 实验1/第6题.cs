using System;
namespace Test4_2
{
    class student_grades
    {
        double[,] grade_array = new double[5, 5];
        string[] student_names = { "Soren", "Peter", "Kaul", "Gerda", "Tuva" };
        public void Input_datetime()
        {
            for (int i = 0; i < 5; i++)
            {
                grade_array[i, 4] = 0;// 4 is average
                Console.Write("Input " + student_names[i] + "'s grades of subjects split by \"-\": ");
                string temp_str = Console.ReadLine();
                string[] temp_str_split = temp_str.Split('-');
                for (int j = 0; j < 4; j++)
                {
                    //fill in a row
                    grade_array[i, j] = Convert.ToUInt32(temp_str_split[j]);
                    grade_array[i, 4] += grade_array[i, j] / 4;
                }
                Console.WriteLine();
            }
        }
        public void Display()
        {
             Console.WriteLine("Name\tSub1\tSub2\tSub3\tSub4\tAverage");
            for (int print_count = 0; print_count < 5; print_count++)
            {
                Console.Write(student_names[print_count] + ":\t");
                for (int print_count_column = 0; print_count_column < 5; print_count_column++)
                {
                    Console.Write(string.Format("{0:f}", grade_array[print_count, print_count_column]) + "\t");
                }
                Console.WriteLine();
            }
        }
        public void print_equals()
        {
            for(int print_q = 0; print_q < 8 * 6; print_q++)
            {
                Console.Write("=");
            }
            Console.WriteLine();
        }
    }

    class test3_1
    {
        static void Main(string[] args)
        {
            student_grades r = new student_grades();
            r.Input_datetime();
            r.print_equals();
            r.Display();
            r.print_equals();
            Console.ReadLine();
        }
    }
}