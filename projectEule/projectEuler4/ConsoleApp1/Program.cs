using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool palindromeFound = false;
            int largestPal = 0;


            while (!palindromeFound)
            {
                for (int a = 999; a > 0; a--) 
                {
                    
                    for (int b = 999; b > 0; b--) 
                    {
                        if (IsThisAPalindrome(a * b)) 
                        {
                            Console.WriteLine("The largest palindrome from 2 three digit numbers is while one is "+a+": " +(a*b));
                            if (a*b>largestPal) 
                            {
                                largestPal = a * b;
                                Console.WriteLine("The largest palindrome currently found is: "+largestPal);
                            }

                        }
                    }
                }
                Console.WriteLine("The largest palindrome for the multiple of 2 3 digit numbers is: " + largestPal);
                palindromeFound = true;
            }
        }


        static public bool IsThisAPalindrome(int toTest) 
        {
            string palToTestString = Convert.ToString(toTest);
            char[] charArray = palToTestString.ToCharArray();

            for (int i = 0; i< charArray.Length; i++) 
            {
                if (charArray[i] != charArray[charArray.Length - i - 1])
                {
                    return false;
                }
            }
            return true;            
        }

    }
}
