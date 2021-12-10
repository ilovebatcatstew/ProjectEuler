using System;
using System.IO;
using System.Numerics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger start = 2;
            BigInteger power = 1000;
            BigInteger answer = 1;

            for (int i = 0; i < power; i++) 
            {
                answer = answer * start;
            }
            Console.WriteLine(answer);

            string answerString = answer.ToString();

            int answerAdded = 0;
            foreach (char i in answerString) 
            {
                int toAdd = Convert.ToInt32(i.ToString());
                answerAdded = answerAdded + toAdd;
            }
            Console.WriteLine(answerAdded);


        }





    }
}
