using System;

namespace Operators
{
    class AssignmentOperator
    {
        public static void Main(string[] args)
        {
            int num1, num2;
            // Assigning a constant to variable
            num1 = 10;
            Console.WriteLine("First Number = {0}", num1);

            // Assigning a variable to another variable
            num2 = num1;
            Console.WriteLine("Second Number = {0}", num2);

            Console.WriteLine("Sum : {0}", num1 + num2);
            Console.WriteLine("Diff : {0}", num1 - num2);
            Console.WriteLine("Multiple : {0}", num1 * num2);
            Console.WriteLine("Divide : {0}", num1 / num2);

            bool result;
            int firstNumber = 10, secondNumber = 20;

            result = (firstNumber == secondNumber);
            Console.WriteLine("{0} == {1} returns {2}", firstNumber, secondNumber, result);

            result = (firstNumber > secondNumber);
            Console.WriteLine("{0} > {1} returns {2}", firstNumber, secondNumber, result);

            result = (firstNumber < secondNumber);
            Console.WriteLine("{0} < {1} returns {2}", firstNumber, secondNumber, result);

            result = (firstNumber >= secondNumber);
            Console.WriteLine("{0} >= {1} returns {2}", firstNumber, secondNumber, result);

            result = (firstNumber <= secondNumber);
            Console.WriteLine("{0} <= {1} returns {2}", firstNumber, secondNumber, result);

            result = (firstNumber != secondNumber);
            Console.WriteLine("{0} != {1} returns {2}", firstNumber, secondNumber, result);

            // OR operator
            result = (firstNumber == secondNumber) || (firstNumber > 5);
            Console.WriteLine(result);

            // AND operator
            result = (firstNumber == secondNumber) && (firstNumber > 5);
            Console.WriteLine(result);

            int result1;

            result1 = ~firstNumber;
            Console.WriteLine("~{0} = {1}", firstNumber, result1);

            result1 = firstNumber & secondNumber;
            Console.WriteLine("{0} & {1} = {2}", firstNumber, secondNumber, result1);

            result1 = firstNumber | secondNumber;
            Console.WriteLine("{0} | {1} = {2}", firstNumber, secondNumber, result1);

            result1 = firstNumber ^ secondNumber;
            Console.WriteLine("{0} ^ {1} = {2}", firstNumber, secondNumber, result1);

            result1 = firstNumber << 2;
            Console.WriteLine("{0} << 2 = {1}", firstNumber, result1);

            result1 = firstNumber >> 2;
            Console.WriteLine("{0} >> 2 = {1}", firstNumber, result1);

            int number = 10;
            number += 5;
            Console.WriteLine(number);

            number -= 3;
            Console.WriteLine(number);

            number *= 2;
            Console.WriteLine(number);

            number /= 3;
            Console.WriteLine(number);

            number %= 3;
            Console.WriteLine(number);

            number &= 10;
            Console.WriteLine(number);

            number |= 14;
            Console.WriteLine(number);

            number ^= 12;
            Console.WriteLine(number);

            number <<= 2;
            Console.WriteLine(number);

            number >>= 3;
            Console.WriteLine(number);
        }
    }
}
