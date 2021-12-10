using System;
using System.IO;
using System.Numerics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // one, two, three, four, five, six, seven, eight, nine, =36

            
            // twenty = 6
            // thirty = 6
            // fourty = 6
            // fifty  = 5
            // sixty  = 5
            // seventy= 7
            // eighty = 6
            // ninety = 6
            // hundred= 7

            //specials
            // ten = 3
            // eleven = 6
            // twelve = 6
            //thirteen= 8
            //fourteen= 8
            //fifteen = 7
            //sixteen = 7
            //seventeen=9
            //eighteen= 8
            //nineteen= 8

            int lastDigit = (36 * 9 * 10); //ignores 11-20, and each modulo 10. these are used once for every 10; *9 for each usage every 100, *10 for each usage every 1000, 
            int specials = ((3+6+6+8+8+7+7+9+8+8)*10);//these are used once ever 100, *10 for each use every 1000
            int multiplesOfTen = ((6+6+6+5+5+7+6+6)*10*10);//these are each used 10 times for each 100. *10 for each 1000
            int hundred = (900); //used once for every number over 99, and less than 1000. so 1000 - 100
            int oneThousand = 11; //used once.
            int and = (((3)*1000)-10-99); /// used for every number above 100, not including 200 300, 400 hundred ect. not used for 1000. so 1000 - 10; -99;

            int digits = lastDigit + specials + multiplesOfTen + hundred + oneThousand + and;
            Console.Write(digits);

        }





    }
}
