using System;
using System.IO;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader numberReader = new StreamReader("number.txt");

            string oneThousDigNum = numberReader.ReadLine();

            char[] numbers = oneThousDigNum.ToCharArray();
            long largestProductSoFar = 0;
            long placeholder = 1;

            for (int i = 0; i < numbers.Length - 12; i++) 
            {
                placeholder = 1;
                for (int index=0; index <13 ; index++) 
                {
                    int pointInArray = i + index;
                    placeholder = placeholder * Convert.ToInt32(numbers[pointInArray].ToString());
                    if (index==12&& placeholder>largestProductSoFar) 
                    { 
                        largestProductSoFar = placeholder;
                        Console.WriteLine("The largest product so far is: "+largestProductSoFar);
                    }
                
                }
                
            }
            Console.WriteLine("The largest product is: " + largestProductSoFar);

        }

        



    }
}
