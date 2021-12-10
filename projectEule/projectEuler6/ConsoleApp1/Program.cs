using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int squareOfSum = 0;
            int sumOfSquares = 0;
            int sum = 0;

            for (int number = 1; number<101; number++) 
            {
                sumOfSquares = sumOfSquares + (number * number);
            }
            Console.WriteLine("The sum of squares of all numbers up to 100 is: "+sumOfSquares);

            for (int number = 1; number < 101; number++) 
            {
                sum = sum + number;
                squareOfSum = (sum * sum);

            }
            Console.WriteLine("The square of the sum of all numbers up to 100 is: " + squareOfSum);

            Console.WriteLine("The difference between the two is: "+ (squareOfSum-sumOfSquares));


        }

    }
}
