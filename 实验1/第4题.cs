using System;
namespace RectangleApplication
{
    class inputs
    {
        public int num_i = 0, sum_odd = 0, sum_even = 0;
        public void readin_num()
        {
            int i = 0;
            while (i < 20)
            {
                Console.WriteLine("Input a integer, current：{0}", i);
                int temp = Convert.ToInt32(Console.ReadLine());
                if (temp == 0) break;
                else
                {
                    if (System.Math.Abs((double)temp % 2.0) < 0.0001)
                    {
                        // which means temp is a sum_even
                        sum_even += temp;
                    }
                    else sum_odd += temp;
                }
                i++;
            }
        }
        public void Display()
        {
            Console.WriteLine(" Odd summary: {0}", sum_odd);
            Console.WriteLine("Even summary: {0}", sum_even);
        }
    }

    class test3_1
    {
        static void Main(string[] args)
        {
            inputs r = new inputs();
            r.readin_num();
            r.Display();
            Console.ReadLine();
        }
    }
}