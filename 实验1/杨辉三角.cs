using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace experiment111
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入一个整数");
            int length = int.Parse(Console.ReadLine());  //输入一个数据，并且将字符串转换为整数
            Console.WriteLine();

            int[,] array = new int[length, length];    //初始化一个长宽都为所求长度的二维数组
            for (int i = 0; i < length; i++)
            { 
                for (int k = 0; k < length - i; k++)  //打印一定数量的空格用于对齐，数据越靠后理应空格数越少
                {
                    Console.Write("   ");              //空格数量自己试出来的
                }
                for (int j = 0; j <= i; j++)    //每一行都有等于行数的数据个数
                {
                    if (j == 0 || i == j)   //若为每行的第一个数或最后一个数则为1
                    {
                        array[i, j] = 1;
                    }
                    else
                    {
                        array[i, j] = array[i - 1, j - 1] + array[i - 1, j];  //否则就项上一行对应相邻的两个数相加
                    }
                    Console.Write(String.Format("{0,5}", array[i, j]) + " ");  //打印数据并控制宽度，类似于c语言里的思维
                }
                Console.WriteLine();  //换行
            }
            Console.ReadKey(); //停留界面
        }
    }
}
