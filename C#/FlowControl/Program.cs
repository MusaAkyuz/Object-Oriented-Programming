using System;

namespace FlowControl
{
    class FlowControl
    {
        public static void Main()
        {
            // single if
            int num1 = 5;
            if(num1 > 10)
            {
                Console.WriteLine("Num1 bigger than 10");
            }

            // if else
            if(num1 > 10)
            {
                Console.WriteLine("Num1 bigger than 10");
            }
            else
            {
                Console.WriteLine("Num1 less than 10 or equal");
            }

            // if else if else if else
            if(num1 < 3)
            {
                Console.WriteLine("Num1 less than 3");
            }
            else if(num1 < 6)
            {
                Console.WriteLine("Num 1 less than 6 but bigger than 3 or queal");
            }
            else
            {
                Console.WriteLine("Num1 bigger than 6 or equal");
            }

            // nested if else
            if(num1 < 10)
            {
                if(num1 == 2)
                {
                    Console.WriteLine("Num1 = 2");
                }
                Console.WriteLine("Num1 less than 10");
            }

            // switch 
            switch(num1)
            {
                case 1:
                    Console.WriteLine("Num1 = 1");
                    break;
                case 2:
                    Console.WriteLine("Num1 = 2");
                    break;
                case 3:
                    Console.WriteLine("Num1 = 3");
                    break;
                case 4:
                    Console.WriteLine("Num1 = 4");
                    break;
                case 5:
                    Console.WriteLine("Num1 = 5");
                    break;
                case 6:
                    Console.WriteLine("Num1 = 6");
                    break;
                default:
                    Console.WriteLine("Nothing");
                    break;
            }

            // ternary
            Console.WriteLine((num1 % 2 == 0) ? true : false);

            Console.WriteLine((num1 < 3) ? "num1 less than 3" : (num1 < 6) ? "num1 less than 6 but bigger than 3 or equal" : "num1 bigger than 6");

            // for loop
            int i;

            for(i = 1; i <= 5; i++)
            {
                Console.WriteLine("Loop for " + i);
            }

            // while loop
            i = 1;

            while(i <= 5)
            {
                Console.WriteLine("While loop " + i);
                i++;
            }

            // do-while
            i = 1;
            int n = 5, product;

            do
            {
                product = n * i;
                Console.WriteLine("{0} * {1} = {2}", n, i, product);
                i++;
            } while (i <= 10);

            // break
            // continue

        }
    }
}