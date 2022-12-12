using System;

namespace AccessModifiers
{
    class Student
    {
        public string name = "Public";

        public void Display()
        {
            Console.WriteLine("Hello student");
        }
    }

    class Student2
    {
        private string name = "Private";

        private void Display()
        {
            Console.WriteLine("Hello student");
        }
    }

    class Student3
    {
        protected string name = "Protected";

        protected void Display()
        {
            Console.WriteLine("Hello student");
        }
    }

    class Program
    {
        public static void Main()
        {
            Student std1 = new Student();
            Console.WriteLine("Name : " + std1.name);
            std1.Display();

            // privarte (error)

            //Student2 std2 = new Student2();
            //Console.WriteLine("Name : " + std2.name);
            //std2.Display();


            //protected (error)

            //Student3 std3 = new Student3();
            //Console.WriteLine("Name : " + std3.name);
            //std3.Display();



        }
    }
}