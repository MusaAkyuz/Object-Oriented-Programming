using System;
using System.Xml;

namespace ClassAndObject
{
    class Dog
    {
        string name;

        public void bark()
        {
            Console.WriteLine(name + " HavHav");
        }
        public static void Main()
        {
            Dog bulldog = new Dog();
            bulldog.name = "Cup";
            Console.WriteLine(bulldog.name);
            bulldog.bark();

            Dog miniDog = new Dog();
            miniDog.name = "Ghost";
            Console.WriteLine(miniDog.name);
            miniDog.bark();
        }
    }
}
