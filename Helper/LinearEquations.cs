using System;

namespace Helper
{
    public class LinearEquations
    {

        // The user enters the number of hours, output the number of minutes in that number of hours.
        public static int CalculateMinutes(int hours)
        {
            if (hours <= 0)
            {
                throw new ArithmeticException();
            }

            return hours * 60;
        }

        // The user enters 2 numbers (A and B). Print the solution (5*A+B^2)/(B-A) to the console.
        public static double CalculateSolution(int a, int b)
        {
            if (b == a)
            {
                throw new DivideByZeroException();
            }

            return (5 * a + b * b) / (b - a);
        }

        // The user enters 2 string values (A and B). Swap the contents of variables A and B.
        public static (int a, int b) Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;

            return (a, b);
        }

        // The user enters 2 numbers (A and B). Print to the console the result of dividing A by B and the division remainder.
        public static (int result, int divisionRemainder) SomeCalculation(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException();
            }

            int result = a / b;
            int divisionRemainder = a % b;

            return (result, divisionRemainder);
        }

        // The user enters 3 non-zero numbers (A, B and C). Print to the console the solution (X value) of the standard linear equation, where A*X+B=C.
        public static float LinearEquation(int a, int b, int c)
        {
            if (a == 0)
            {
                throw new DivideByZeroException();
            }

            return (float)(c - b) / a;
        }

        // The user enters 4 numbers (X1, Y1, X2, Y2) describing the coordinates of 2 points on the coordinate plane.
        // Output the equation of a straight line in the format Y=AX+B passing through these points.
        public static (double a, double b) EquationOfLine(int x1, int y1, int x2, int y2)
        {
            if (x1 - x2 == 0)
            {
                throw new DivideByZeroException();
            }

            double a = (y1 - y2) / (x1 - x2);
            double b = y2 - a * x2;

            return (a, b);
        }

        // The variable N stores a natural two-digit number (10-99). Write a program that calculates and displays the sum of the digits of n.
        public static int SumOfDigits(int someNumber)
        {
            if (someNumber < 10)
            {
                throw new ArgumentOutOfRangeException();
            }

            return (someNumber % 10) + (someNumber / 10);
        }

    }
}
