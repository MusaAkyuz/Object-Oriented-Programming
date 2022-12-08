using System;
using System.Globalization;

namespace Arrays
{
    class Arrays
    {
        public static void Main()
        {
            // declare an array
            int[] age;

            // allocate memory for array
            age = new int[5];

            age[0] = 45;
            age[1] = 34;

            int[] number = { 1, 2, 3, 4, 5 };

            Console.WriteLine("number[2] : " + number[2]);

            number[2] = 100;

            Console.WriteLine("number[2] : " + number[2]);

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("number[" + i + "] : " + number[i]);
            }

            foreach(int num in number)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("min : " + number.Min());
            Console.WriteLine("max : " + number.Max());
            Console.WriteLine("sum : " + number.Sum());
            Console.WriteLine("count : " + number.Count());
            Console.WriteLine("avarage : " + number.Average());

            int[,] x = { { 1, 2, 3 }, { 4, 5, 6 } };
            Console.WriteLine("x[0, 1] : " + x[0, 1]);
        }
    }
}