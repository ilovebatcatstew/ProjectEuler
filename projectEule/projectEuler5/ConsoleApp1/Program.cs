using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool numberFound = false;
            int thenumberis = 0;
            while (!numberFound) 
            {
                for (int i = 1; !numberFound; i++) 
                {

                    for (int divisor = 20; divisor > 0; divisor--)
                    {
                        if (i % divisor != 0)
                        {
                            break;
                        }
                        if (divisor == 1) 
                        {
                            thenumberis = i;
                            numberFound = true;
                        }
                    }
                
                }
                Console.WriteLine("The smallest possible number evenly divisible by all numbers 1 through 20 is: "+thenumberis);
            }
            

        }

    }
}
