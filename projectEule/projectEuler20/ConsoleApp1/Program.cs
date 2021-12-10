using System;
using System.IO;
using System.Numerics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger n = calculateFactorialNonRecursive(100);


            Console.WriteLine(n);

            int ans = 9 + 3 + 3 + 2 + 6 + 2 + 1 + 5 + 4 + 4 + 3 + 9 + 4 + 4 + 1 + 5 + 2 + 6 + 8 + 1 + 6 + 9 + 9 + 2 + 3 + 8 + 8 + 5 + 6 + 2 + 6 + 6 + 7 + 4 + 9 + 7 + 1 + 5 + 9 + 6 + 8 + 2 + 6 + 4 + 3 + 8 + 1 + 6 + 2 + 1 + 4 + 6 + 8 + 5 + 9 + 2 + 9 + 6 + 3 + 8 + 9 + 5 + 2 + 1 + 7 + 5 + 9 + 9 + 9 + 9 + 3 + 2 + 2 + 9 + 9 + 1 + 5 + 6 + 0 + 8 + 9 + 4 + 1 + 4 + 6 + 3 + 9 + 7 + 6 + 1 + 5 + 6 + 5 + 1 + 8 + 2 + 8+6+2+5+3+6+9+7+9+2+0+8+2+7+2+2+3+7+5+8+2+5+1+1+8+5+2+1+0+9+1+6+8+6 + 4;

            Console.WriteLine(ans);

        }

        public static BigInteger calculateFactorialNonRecursive(BigInteger number)
        {
            BigInteger answer = 1;
            while (number != 0)
            {
                answer *= number;
                number--;
            }
            return answer;
        }



    }
}
