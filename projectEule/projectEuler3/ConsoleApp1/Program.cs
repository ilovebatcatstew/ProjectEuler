using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool solutionFound = false;
            long findTheFactors = 600851475143;
            
            long factorToTest = 0;

            while (!solutionFound) 
            {

                for (int i = 1; i <= findTheFactors; i++) 
                {
                    if (findTheFactors % i == 0) 
                    {
                        findTheFactors = findTheFactors / i;
                    }

                    if (i == 1)
                    { 
                        solutionFound = true;
                        Console.WriteLine("The last number was the answer!");
                    
                    }
                    else 
                    { Console.WriteLine("the current number testing to be factor calculated is... "+ i); }
    
                     
                        
                    



                }


                
            }

        }
    }
}
