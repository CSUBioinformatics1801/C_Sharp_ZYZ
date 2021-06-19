using System;
//using System.Timers;
namespace Test6_1{
    public class Employee{
        public double basic_salary = 1000, year, sum_salary;
        public Employee(double year){
            this.year = year;
            this.sum_salary = basic_salary + 30 * year;
        }
    }
    public class UEmployee : Employee{
        double multiplying = 1.5;
        public UEmployee(double year) : base(year){
            this.year = year;
            this.sum_salary = basic_salary + multiplying * 30 * year;
        }
    }
    public class Program{
        public static void Main(){
            int temp_year;
            integratedTerminal.WriteLine("Input current serving years:");
            temp_year = int.Parse(integratedTerminal.ReadLine());
            Employee e = new Employee(temp_year);
            UEmployee u = new UEmployee(temp_year);
            Console.Write("Your have been employed for {0} years.\nCurrent salary for common employees: {1} yuan/mouth\nCurrent salary for undergraduate employees: {2}yuan/mouth", temp_year, e.sum_salary, u.sum_salary);
        }
    }
}
