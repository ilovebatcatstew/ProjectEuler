using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("How many prime numbers would you like?");
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
                    Console.WriteLine("Not a valid number of primes. Please try again.");
                }
                
            }
                
            int count = 0;

            while (count <= intN) 
            {
                for(int i = 2; count<intN; i++)
                {
                    
                    if (IsPrime(i)) 
                    {
                        count++;
                        Console.WriteLine("The Prime number of position "+count+" is: "+i);

                    }


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
