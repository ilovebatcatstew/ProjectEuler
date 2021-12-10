using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            int c = 0;
            int total = 2;
            int lastC = c;

            while (c<4000000) 
            {
                c = a + b;
                a = b;
                b = c;
                
                if (c%1==0) 
                {
                    Console.WriteLine(c);
                }


            }
            
            //Not sure why but couldnt get the result to generate naturally. This just does viable fibbonaci numbers. Add the evens and its fine.

        }
    }
}
