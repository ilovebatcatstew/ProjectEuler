using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What number would you like your greatest prime to be less than?");
            int intN = 0;
            while (intN == 0)
            {
                string stringN = Console.ReadLine();
                try 
                { 
                    intN = Convert.ToInt32(stringN); 
                } 
                catch 
                {
                    Console.WriteLine("Not a valid number. Please try again.");
                }
                
            }
                
            int count = 0;
            long total = 0;

            for (int i = 2; i < intN; i++)
            {

                if (IsPrime(i))
                {
                    count++;
                    Console.WriteLine("The Prime number of position " + count + " is: " + i);
                    total = total + i;
                    Console.WriteLine("The total of all prime numbers so far is: " +total);

                }


            }



        }


        static public bool IsPrime(int toTest)
        {
            for (int divisor = (int)Math.Sqrt(toTest); divisor > 1; divisor--) 
            {
                if (toTest% divisor ==0) 
                {
                    return false;
                }
            
            }
            return true;
        
        }

    }
}
