using System;
namespace t2
{
    class Pascal_triangle
    {
        public int tri_order = 1, limit_num = 12;
        public void Input_datetime()
        {
            Console.Write("Input a integer as the order of pascal triangle less than {0}.", limit_num);
            tri_order = int.Parse(Console.ReadLine());
            if (tri_order > limit_num)
            {
                Console.WriteLine("The integer must be less than {0}.", limit_num);
                Environment.Exit(0);
            }
        }
        public void Fill_in_array()
        {
            int[,] pascal_array = new int[tri_order, tri_order];
            for (int i = 0; i < tri_order; i++)
            {
                for (int print_blank = 0; print_blank < tri_order - i; print_blank++)
                {
                    Console.Write("    ");
                }
                //print a row
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || i == j)
                    {
                        //the first column and the last
                        pascal_array[i, j] = 1;
                    }
                    else
                    {
                        pascal_array[i, j] = pascal_array[i - 1, j - 1] + pascal_array[i - 1, j];
                    }
                    Console.Write(string.Format("{0,4}", pascal_array[i, j])+"    ");
                }
                Console.WriteLine();
            }
        }
    }

    class test3_1
    {
        static void Main(string[] args)
        {
            Pascal_triangle r = new Pascal_triangle();
            r.Input_datetime();
            r.Fill_in_array();
            Console.ReadLine();
        }
    }
}