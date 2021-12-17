using System;

namespace LengthOfLine
{
    //creating class
    class SolutionOfAss1p2
    {
        //declaring fields
        //x1,y1,x2,y2
        int x1, y1, x2, y2;
        int point1 = 0;
        int point2 = 0;
        double total;
        float Length1 = 0;
        float Length2 = 0;




        public SolutionOfAss1p2(int X1, int Y1, int X2, int Y2)
        {
            this.x1 = X1;
            this.y1 = Y1;

            this.x2 = X2;
            this.y2 = Y2;
        }

        public double CalculateLengthOfLine()
        {
            int point1 = x2 - x1;
            int point2 = y2 - y1;
            Console.WriteLine("cordinates are x1,y1,x2,y2 {0} {1} {2} {3}", x1, y1, x2, y2);
            double total = Math.Pow(point1, 2) + Math.Pow(point2, 2);
            //Console.WriteLine(point1);
            //Console.WriteLine(point2);
            //Console.WriteLine(total);
            return total;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            SolutionOfAss1p2 s1 = new SolutionOfAss1p2(5, 5, 50, 50);
            double final1 = s1.CalculateLengthOfLine();
            double lenght1 = Math.Sqrt(final1);

            SolutionOfAss1p2 s2 = new SolutionOfAss1p2(10, 10, 55, 55);
            double final2 = s2.CalculateLengthOfLine();
            double lenght2 = Math.Sqrt(final2);


            Console.WriteLine("Length of line of given 4 coordinates is  " + lenght1);
            Console.WriteLine("Length of line of given 4 coordinates is  " + lenght2);

            if ( lenght1 == lenght2)
            {
                Console.WriteLine("Both Lines are Equal Length ");

            }
            else
            {
                Console.WriteLine("Both Lines are Not Equal Length");

            }



        }
    }
}