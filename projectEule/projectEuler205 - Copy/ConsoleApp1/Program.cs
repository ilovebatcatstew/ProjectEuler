using System;
using System.IO;
using System.Numerics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pyramid = new int[9 * 4 - 9 * 1 + 1];

            for (int a = 1; a <=4; a++)
            {
                for (int b = 1; b <=4; b++)
                {
                    for (int c = 1; c <=4; c++)
                    {
                        for (int d = 1; d <=4; d++)
                        {
                            for (int e = 1; e <=4; e++)
                            {
                                for (int f = 1; f <=4; f++)
                                {
                                    for (int g = 1; g <=4; g++)
                                    {
                                        for (int h = 1; h <=4; h++)
                                        {
                                            for (int i = 1; i <=4; i++)
                                            {
                                                int total = a + b + c + d + e + f + g + h + i;
                                                
                                                pyramid[total-(9 * 1)]++;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            int[] cube = new int[36-5];


            for (int a = 1; a <= 6; a++)
            {
                for (int b = 1; b <= 6; b++)
                {
                    for (int c = 1; c <= 6 ; c++)
                    {
                        for (int d = 1; d <= 6; d++)
                        {
                            for (int e = 1; e <= 6; e++)
                            {
                                for (int f = 1; f <=6; f++)
                                {
                                    int total = a + b + c + d + e + f;
                                    cube[total-(6)]++;

                                }
                            }
                        }
                    }
                }
            }


            double[] chanceOfResultP = new double[36 - 8];

            double[] chanceOfResultC = new double[36 - 5];


            for (int i = 0; i < pyramid.Length; i++)
            {
                Console.WriteLine(pyramid[i]);
            }
            Console.WriteLine();

            for (int i = 0; i < cube.Length; i++)
            {
                Console.WriteLine(cube[i]);
            }
            Console.WriteLine();


            int totalPossibleResultsPyr = 0;
            int lowestResult = 9;
            int posInArray = 0;

            for (int i = 0; i < pyramid.Length; i++)
            {
                totalPossibleResultsPyr = totalPossibleResultsPyr + pyramid[i];
            }

            


            for (int i = 0; i < pyramid.Length; i++)
            {
                Console.WriteLine("The Chance of rolling a " + lowestResult+" on 9d4 is:");
                lowestResult++;
                double ratio = (double)pyramid[i] / (double)totalPossibleResultsPyr;
                Console.WriteLine(ratio*100);
                chanceOfResultP[i] = (ratio);
                Console.WriteLine(posInArray);
                posInArray++;

            }

            int totalPossibleResultscube = 0;
            lowestResult = 6;

            for (int i = 0; i < cube.Length; i++)
            {
                totalPossibleResultscube = totalPossibleResultscube + cube[i];
            }

            posInArray = 0;

            for (int i = 0; i < cube.Length; i++)
            {
                Console.WriteLine("The Chance of rolling a " + (lowestResult) + " on 6d6 is:");
                lowestResult++;
                double ratio = (double)cube[i] / (double)totalPossibleResultscube;
                Console.WriteLine(ratio * 100);
                chanceOfResultC[i] = (ratio);
                Console.WriteLine(posInArray);
                posInArray++;

            }

            double chanceOfPbeingHigherThanC = 0;


            for (int cubeResult = 0; cubeResult < chanceOfResultC.Length; cubeResult++) 
            {

                for (int pyrResult = 0; pyrResult < chanceOfResultP.Length; pyrResult++)
                {
                    if ((pyrResult+3)> (cubeResult)) 
                    {
                        chanceOfPbeingHigherThanC = chanceOfPbeingHigherThanC + ((chanceOfResultP[pyrResult]) * (chanceOfResultC[cubeResult]));
                    }
                }
            
            
            
            }

            Console.WriteLine(chanceOfPbeingHigherThanC*100);


        }



    }
}
