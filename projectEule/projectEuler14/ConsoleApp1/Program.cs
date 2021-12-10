using System;
using System.IO;
using System.Numerics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            long numThatMadeMostTerms = 0;
            long highestTerms = 0;
            long terms = 0;
            for (int i = 1; i < 1000000; i++) 
            {
                terms = 1;
                long num = i;
                while (num != 1) 
                {
                    terms++;
                    num = CollatzTheNum(num);
                }
                if (terms> highestTerms)
                {
                    highestTerms = terms;
                    numThatMadeMostTerms = i;
                    Console.WriteLine("The highest number of terms is so far "+ highestTerms + " from the number "+numThatMadeMostTerms);
                }
            }
            Console.WriteLine("end");


        }



        public static long CollatzTheNum(long numbToCollatz) 
        {
            if (numbToCollatz % 2 == 0)
            {
                return (numbToCollatz/2);
            }
            else 
            {
                return ((numbToCollatz*3)+1);
            }
        }


    }
}
