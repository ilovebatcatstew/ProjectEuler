using System;
using System.Collections.Generic;

namespace euler52
{
    class Program
    {
        static void Main(string[] args)
        {
            ////It can be seen that the number, 125874, and its double, 251748, contain exactly the same digits, but in a different order.

            /// Find the smallest positive integer, x, such that 2x, 3x, 4x, 5x, and 6x, contain the same digits.

            ///for a given number
            ///

            int numberTest = 1;
            
            bool numberFound = false;
            while (!numberFound)
            {
                

                int numberX2 = numberTest * 2;


                int numberX3 = numberTest * 3;
                
                
                int numberX4 = numberTest * 4;
                
                
                int numberX5 = numberTest * 5;
                
                
                int numberX6 = numberTest * 6;

                int[] firstArray = convertIntToIntArray(numberTest);
                int[] secondArray = convertIntToIntArray(numberX2);
                int[] thirdArray = convertIntToIntArray(numberX3);
                int[] fourthArray = convertIntToIntArray(numberX4);
                int[] fifthArray = convertIntToIntArray(numberX5);
                int[] sixthArray = convertIntToIntArray(numberX6);

                if (numberTest!=0) 
                {
                    if (DoTheseArraysContainTheSameNumbers(firstArray, secondArray))
                    {
                        if (DoTheseArraysContainTheSameNumbers(firstArray, thirdArray))
                        {
                            if (DoTheseArraysContainTheSameNumbers(firstArray, fourthArray))
                            {
                                if (DoTheseArraysContainTheSameNumbers(firstArray, fifthArray))
                                {
                                    if (DoTheseArraysContainTheSameNumbers(firstArray, sixthArray))
                                    {
                                        numberFound = true;
                                        Console.WriteLine(numberTest + " Contains the same numbers when multiplied by 2: " + numberX2);
                                        Console.WriteLine(numberTest + " Contains the same numbers when multiplied by 3: " + numberX3);
                                        Console.WriteLine(numberTest + " Contains the same numbers when multiplied by 4: " + numberX4);
                                        Console.WriteLine(numberTest + " Contains the same numbers when multiplied by 5: " + numberX5);
                                        Console.WriteLine(numberTest + " Contains the same numbers when multiplied by 6: " + numberX6);
                                    }
                                }
                            }
                        }
                    }
                }
              
                

                numberTest++;
            }
        }



        public static int[] convertIntToIntArray(int numberToBreak) 
        {
            string numberString = Convert.ToString(numberToBreak);
            string[] digitArrayStrings = new string[numberString.Length];

            for (int i = 0; i < numberString.Length; i++)
            {
                //turn strin numberString >>> digitArrayStrings
                digitArrayStrings[i] = numberString[i].ToString();
            }


            int[] digitArrayInts = new int[numberString.Length];
            for (int i =0; i< numberString.Length; i++) 
            {
                string toConvertToInt = digitArrayStrings[i];
                digitArrayInts[i] = Convert.ToInt32(toConvertToInt);


            }
            return digitArrayInts;

        }



        public static bool IsNumberInArray(int number, int[] array) 
        {
            foreach(int i in array) 
            {
                if (number == i)
                {
                    return true;
                }
            
            }
            return false;
        }


        public static bool DoesFirstArraysNumbersExistInTestArray(int[] numbers, int[] testArray) 
        {
            
            foreach (int i in numbers) 
            {
                bool test = IsNumberInArray(i,testArray);
                if (!test) 
                {
                    return false;
                }
            }
            return true;
        }

        public static bool DoTheseArraysContainTheSameNumbers(int[] array1, int[] array2) 
        {
            bool firstTest = DoesFirstArraysNumbersExistInTestArray(array1, array2);
            bool secondTest = DoesFirstArraysNumbersExistInTestArray(array2, array1);
            bool thirdTest = (array1.Length == array2.Length);

            if (firstTest && secondTest && thirdTest)
            { return true; }
            else { return false; }
        }




    }

}
