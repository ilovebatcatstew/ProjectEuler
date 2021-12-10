using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int triangleNumberPos = 0;
            int triangleNumber = 0;
            int NumberOfFactors = 0;

            while (NumberOfFactors <= 500) 
            {
                triangleNumberPos++;
                triangleNumber = triangleNumber + triangleNumberPos;
                NumberOfFactors = HowManyFactors(triangleNumber);
                //Console.WriteLine(triangleNumber + " has this many factors: " + NumberOfFactors);
                //Console.WriteLine($"{triangleNumber} has this many factors: {NumberOfFactors}");
               
                if (NumberOfFactors > 500) 
                {
                    Console.WriteLine("The number "+ triangleNumber + " is the "+ triangleNumberPos + " position Triangle number. It has "+ NumberOfFactors + " factors.");
                }

                if (Math.Sqrt(triangleNumberPos) % 10 == 0)
                {
                    Console.WriteLine(triangleNumberPos);
                }

            }


            
        }


        public static int HowManyFactors(int toFindNumOfFactors) 
        {
            int count = 0;
            for (int i = 1; i <= Math.Sqrt(toFindNumOfFactors); i++) 
            {
                if (toFindNumOfFactors%i ==0) 
                {
                    count++;
                }
            }

            
            return count*2;
        }




    }
}
