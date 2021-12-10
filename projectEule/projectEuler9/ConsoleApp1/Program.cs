using System;
using System.IO;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            bool tripletFound = false;

            for (int a = 1; !tripletFound; a++) 
            {
                for (int b = a + 1; !tripletFound && b < 1000; b++) 
                {
                    for (int c = b + 1; !tripletFound && c <1000; c++)
                    {
                        if (a+b+c == 1000) 
                        {
                            if ((a*a)+(b*b)==(c*c)) 
                            {
                                Console.WriteLine("A is: "+a);
                                Console.WriteLine("B is: " + b);
                                Console.WriteLine("C is: " + c);

                                Console.WriteLine("A^2 (" + (a*a)+") + B^2 ("+(b*b)+") = C^2 ("+(c*c)+").");

                                Console.WriteLine("A ("+a+") + B ("+b+") + C ("+c+") = "+(a+b+c));
                                Console.WriteLine("A*B*C = " + (a * b * c));
                                tripletFound = true;

                            }
                        
                        }
                    }
                
                
                }
            
            }

        }
    }
}
