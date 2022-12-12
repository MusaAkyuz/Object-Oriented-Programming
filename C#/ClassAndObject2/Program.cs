using System;

namespace ClassAndObject2
{
    class Employee
    {
        public string name;

        public void work(string work)
        {
            Console.WriteLine("Work : " + work);
        }

        //Method Overloading
        public void work(string work, string time)
        {
            Console.WriteLine("Work : " + work + " Time : " + time);
        }
    }

    class EmployeeMain
    {
        public static void Main()
        {
            Employee e1 = new Employee();
            e1.name = "Ali";

            Console.WriteLine(e1.name);
            e1.work("System Administrator");
            e1.work("Tester", "12-12-2022");
        }
        

    }
}