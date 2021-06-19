using System;
namespace Test5_2{
    public delegate double this_is_a_delegate(double x,double y);
    class time_to_test_the_delegate{
        public double test_1(double x,double y){
            return System.Math.Pow(x,2)+System.Math.Pow(y,2);
        }
        public double test_2(double x,double y){
            return System.Math.Pow(x,2)-System.Math.Pow(y,2);
        }
    }
    class test3_1{
        static void Main(string[] args){
            time_to_test_the_delegate t=new time_to_test_the_delegate();
            Console.WriteLine("If x=3,y=4, then x^2+y^2 equals to {0} while x^2-y^2 is {1}",t.test_1(3,4),t.test_2(3,4));
            Console.ReadLine();
        }
    }
}
