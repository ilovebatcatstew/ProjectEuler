using System;

namespace Euler587
{
    class Program
    {
        static void Main(string[] args)
        {
            ///number of circles is n. r = 1: these are unit circles.
            ///
            ///therefore area of bottom left is always


            double n = 2;


            //Radius of unit is always 1.
            double r = 1;
            //Therefore length of square around first circle, is 2r. that means area is 2r^2.
            double height = 2 * r;

            //Area of first circle.
            double areaOfUnitCircle = Math.PI * r * r;

            //Area of rect around all circles.
            double areaOfRectAroundCircles = n * (height * height);

            //area of corners in square around first circle.
            double areaOfInsideSquareButNotCircle = (height * height) - areaOfUnitCircle;

            //Area of only the bottom left corner inside square.
            double areaOfBottomLeft = areaOfInsideSquareButNotCircle / 4;

            // for n circles the area of the rectangle is
            double areaOfRectAroundAllCircles = (n * 2 * height);

            //For n circles that makes the triangle have an area of
            double areaOfGreaterRightAngleTriangle = areaOfRectAroundAllCircles / 2;


            //The height of a trangle in the first half of the first circle, given an angle.
            double heightOfTriangeOfLengthR = 1 / n;

            ///therefore area of a triangle at that height. 
            double areaOfTriangeOfLengthR = heightOfTriangeOfLengthR / 2; ///This is possible because the r value is 1.

            //Area of a triangle with the orange areas height and width where x axis ends at center of circle.
            double areaOfOrangeRect = (1 / n * r)/2;

            //Line will equal (x/n)

            //circle equation is (x-h)^2   +   (y-k)^2  = r^2.   simplified (we know the radius is one, and h,k is 1,1  = (x-1)^2+(y-1)^2 = 1) . However, we want to solve for intersection. So,
            //Therefore (x-h)^2   +   ((x/n)-k)^2  = r^2
            //(x-1)^2 + (x/n -1)^2 = 1
            // Therefore: x=(-\sqrt{2}/\sqrt{n}+1/n+1)/(1/n^{2}+1)

            double xOfFirstIntersect = (    (-Math.Sqrt(2)/ Math.Sqrt(n))+(1/n)+(1)          )/(1/(n*n)+1);   //THIS IS THE X VALUE OF THE FIRST INTERSECTION! WOO HOO.

            double yOfFirstIntersect = (xOfFirstIntersect / n);

            

            ///A^2 + b^2 =c^2, PYTHAG.

            double triangleLeftFromIntersectDownArea = (xOfFirstIntersect* yOfFirstIntersect)/2;
            double triangleRightFromIntersectDownArea = (1 - xOfFirstIntersect * yOfFirstIntersect) / 2;
            ///A^2 + b^2 =c^2, PYTHAG.
            

            double lengthOfChord = Math.Sqrt((yOfFirstIntersect* yOfFirstIntersect)+(((1 - xOfFirstIntersect)*(1 - xOfFirstIntersect)))); //NEARLY THERE!

            double areaInsideLengthOfChord = (lengthOfChord * r)/2;

            //THERFORE area of segment is areaOfSector = areaInsideLengthOfChord
            double areaOfSector = 1;

            double bottomOfRightTriangle = 1 - xOfFirstIntersect;

            //y = 1-sqrt(1-(x)*(x))

            //Area ofRightTriangleMinusSector

            double areaOfRightTriangleMinusSector =  -((Math.Asin(bottomOfRightTriangle))/2)  -   ((bottomOfRightTriangle*Math.Sqrt(1-(bottomOfRightTriangle*bottomOfRightTriangle)))/2) + bottomOfRightTriangle + 0;

            double areaOFORANGE = areaOfRightTriangleMinusSector + triangleLeftFromIntersectDownArea;

            Console.WriteLine("what percentage of blue should orange be below?? (enter here. MUST be less than 34% to be accurate.)");
            double percentage = 50;
            while (percentage == 50)
            {
                string input = Console.ReadLine();
                try { percentage = Convert.ToDouble(input);} 
                catch { Console.WriteLine("Sorry, not valid. Try again."); }

            }

            bool solutionFound = false;

            while (!solutionFound) 
            {

                ///number of circles is n. r = 1: these are unit circles.
                ///
                ///therefore area of bottom left is always


                


                //Radius of unit is always 1.
                r = 1;
                //Therefore length of square around first circle, is 2r. that means area is 2r^2.
                height = 2 * r;

                //Area of first circle.
                areaOfUnitCircle = Math.PI * r * r;

                //Area of rect around all circles.
                areaOfRectAroundCircles = n * (height * height);

                //area of corners in square around first circle.
                areaOfInsideSquareButNotCircle = (height * height) - areaOfUnitCircle;

                //Area of only the bottom left corner inside square.
                areaOfBottomLeft = areaOfInsideSquareButNotCircle / 4;

                // for n circles the area of the rectangle is
                areaOfRectAroundAllCircles = (n * 2 * height);

                //For n circles that makes the triangle have an area of
                areaOfGreaterRightAngleTriangle = areaOfRectAroundAllCircles / 2;


                //The height of a trangle in the first half of the first circle, given an angle.
                heightOfTriangeOfLengthR = 1 / n;

                ///therefore area of a triangle at that height. 
                areaOfTriangeOfLengthR = heightOfTriangeOfLengthR / 2; ///This is possible because the r value is 1.

                //Area of a triangle with the orange areas height and width where x axis ends at center of circle.
                areaOfOrangeRect = (1 / n * r) / 2;

                //Line will equal (x/n)

                //circle equation is (x-h)^2   +   (y-k)^2  = r^2.   simplified (we know the radius is one, and h,k is 1,1  = (x-1)^2+(y-1)^2 = 1) . However, we want to solve for intersection. So,
                //Therefore (x-h)^2   +   ((x/n)-k)^2  = r^2
                //(x-1)^2 + (x/n -1)^2 = 1
                // Therefore: x=(-\sqrt{2}/\sqrt{n}+1/n+1)/(1/n^{2}+1)

                xOfFirstIntersect = ((-Math.Sqrt(2) / Math.Sqrt(n)) + (1 / n) + (1)) / (1 / (n * n) + 1);   //THIS IS THE X VALUE OF THE FIRST INTERSECTION! WOO HOO.

                yOfFirstIntersect = (xOfFirstIntersect / n);



                ///A^2 + b^2 =c^2, PYTHAG.

                triangleLeftFromIntersectDownArea = (xOfFirstIntersect * yOfFirstIntersect) / 2;
                triangleRightFromIntersectDownArea = (1 - xOfFirstIntersect * yOfFirstIntersect) / 2;
                ///A^2 + b^2 =c^2, PYTHAG.


                lengthOfChord = Math.Sqrt((yOfFirstIntersect * yOfFirstIntersect) + (((1 - xOfFirstIntersect) * (1 - xOfFirstIntersect)))); //NEARLY THERE!

                areaInsideLengthOfChord = (lengthOfChord * r) / 2;

                //THERFORE area of segment is areaOfSector = areaInsideLengthOfChord
                areaOfSector = 1;

                bottomOfRightTriangle = 1 - xOfFirstIntersect;

                //y = 1-sqrt(1-(x)*(x))

                //Area ofRightTriangleMinusSector

                areaOfRightTriangleMinusSector = -((Math.Asin(bottomOfRightTriangle)) / 2) - ((bottomOfRightTriangle * Math.Sqrt(1 - (bottomOfRightTriangle * bottomOfRightTriangle))) / 2) + bottomOfRightTriangle + 0;

                areaOFORANGE = areaOfRightTriangleMinusSector + triangleLeftFromIntersectDownArea;

                

                double precentage = 100 * (areaOFORANGE / areaOfBottomLeft);

                if (precentage < percentage) 
                {
                    solutionFound = true;

                    Console.WriteLine("Number of circles to drop the percent of blue that orange occupies below "+percentage+" percent = " + n);

                }

                n++;

            }




        }
    }
}
