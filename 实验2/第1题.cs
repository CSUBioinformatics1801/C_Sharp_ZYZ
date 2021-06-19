using System;
namespace Test5_1{
    class Animal{
        public int legs;
        protected int weight;
        public int getweight{
            get{
                return weight;
            }
            set{
                weight=value;
            }
        }
    }

class Person: Animal{

}
    class test3_1
    {
        static void Main(string[] args)
        {
            Animal a = new Animal();
            Person p=new Person();
            a.getweight=500;a.legs=4;
            p.getweight=60;p.legs=2;
            Console.WriteLine("The weight of an animal is {0} with {1} legs.",a.getweight,a.legs);
            Console.WriteLine("The weight of an person is {0} with {1} legs.",p.getweight,p.legs);
            Console.ReadLine();
        }
    }
}
