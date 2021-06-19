using System;
namespace Test6_1
{
    public class Employee
    {
        public double multiplying = 1, basic_salary = 1000, year, sum_salary;
        public Employee(double year)
        {
            this.year = year;
            this.sum_salary = basic_salary + multiplying * 30 * year;
        }
        public virtual double get_sum_salary()
        {
            return basic_salary + multiplying * 30 * year;
        }
    }
    public class UEmployee : Employee
    {
        new double multiplying = 1.5;
        public UEmployee(double year) : base(year)
        {
            this.year = year;
            this.sum_salary = basic_salary + multiplying * 30 * year;
        }
    }
    public class GEmployee : Employee
    {
        new double multiplying = 1.5;
        public GEmployee(double year) : base(year)
        {
            this.year = year;
        }
        public override double get_sum_salary()
        {
            return basic_salary + multiplying * 30 * year;
        }
    }
    public class Program
    {
        public static void Main()
        {
            int temp_year;
            Console.WriteLine("Input current serving years:");
            temp_year = int.Parse(Console.ReadLine());
            Employee e = new Employee(temp_year);
            UEmployee u = new UEmployee(temp_year);
            GEmployee g = new GEmployee(temp_year);
            g.sum_salary = g.get_sum_salary();
            Console.Write("Your have been employed for {0} years.\nCurrent salary for common employees: {1} yuan/mouth\nCurrent salary for undergraduate employees: {2} yuan/mouth\nCurrent salary for graduate employees: {3} yuan/mouth", temp_year, e.sum_salary, u.sum_salary, g.sum_salary);
        }
    }
}
