using System;

namespace Euler371
{
    class Program
    {
        static void Main(string[] args)
        {

            bool solutionFound = false;
            int count = 1;

            while (!solutionFound) 
            {
                int firstNum = RandomNumber(0,999);
                int secondNum = RandomNumber(0, 999);


                if (firstNum+secondNum == 1000) 
                {
                    Console.WriteLine("");
                }
                count++;
            }



        }
        public static int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

    }
}
