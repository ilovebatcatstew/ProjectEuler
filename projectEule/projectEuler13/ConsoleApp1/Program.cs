using System;
using System.IO;
using System.Numerics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader numberReader = new StreamReader("number.txt");

            BigInteger[] arrayOfNums = new BigInteger[100];
            for (int i=0; i < arrayOfNums.Length;i++) 
            {
                arrayOfNums[i] = BigInteger.Parse(numberReader.ReadLine());
            }
            BigInteger total = 0;


            for (int i =0; i< arrayOfNums.Length; i++) 
            {
                total = total + arrayOfNums[i];
                Console.WriteLine(i);
                //Console.WriteLine(arrayOfNums[i]);
                
                Console.WriteLine("Current total is: " +total);
            
            }


            Console.WriteLine("End total is: "+total);

        }

    }
}
