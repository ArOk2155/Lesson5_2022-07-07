using System;

namespace Helper
{
    public class CiclesHelper
    {
        //1. The user enters 2 numbers (A and B). Raise the number A to the power of B.
        public static double Degree(double number, double degree)
        {
            double result = 1;

            if (number == 0)
            {
                throw new ArgumentException();
            }

            if (degree > 0)
            {
                for (int i = 1; i <= degree; i++)
                {
                    result *= number;
                }
            }
            else if (degree < 0)
            {
                for (int i = -1; i >= degree; i--)
                {
                    result /= number;
                }
            }

            return result;
        }


        //3. The user enters 1 number (A). Find the number of positive integers whose square is less than A.
        public static int GetCountOfNumbers(int a)
        {
            int i = 0;

            while ((i * i) < a)
            {
                i++;
            }

            return i - 1;
        }


        //4. The user enters 1 number (A). Print the largest divisor (other than A itself) of the number A.
        public static int GetLagestDivisor(int a)
        {
            int i;

            for (i = a - 1; i >= 1; --i)
            {
                if (a % i == 0) return i;
            }

            return 0;
        }


        //6. The user enters 1 number (N). Print the Nth number of the fibonacci series. In the fibonacci series, each next number is the sum of the previous two.
        //The first and second are considered equal to 1.
        public static int GetNthNumberFibSeries(int a)
        {
            int first = 0;
            int second = 1;

            for (int i = 0; i < a; i++)
            {
                int temp = first;
                first = second;
                second += temp;
            }

            return first;
        }


        //7. The user enters 2 numbers. Find their greatest common divisor using Euclid's algorithm.
        public static int GetGDC(int a, int b)
        {
            int min = Math.Min(a, b);

            if (a % min == 0 && b % min == 0)
            {
                return min;
            }

            for (int i = min / 2; i >= 2; i--)
            {
                if (a % i == 0 && b % i == 0)
                {
                    return i;
                }
            }

            return 0;
        }


        //9. The user enters number.Find the number of odd digits of this number.
        public static int GetNumberOfOdd(int a)
        {
            int result = 0;

            do
            {
                if (((a % 10) % 2) != 0)
                {
                    result++;
                }

            } while ((a /= 10) != 0);

            return result;
        }


        //10. The user enters number. Find a number that is a mirror image of the sequence of digits of a given number, for example, given the number 123, output 321.
        public static int ReverseNumber(int a)
        {
            int result = 0;

            while (a != 0)
            {
                int temp = a % 10;
                result = result * 10 + temp;
                a /= 10;
            }

            return result;
        }


        //12. The user enters 2 numbers.Tell me if there are the same digits in the spelling of two numbers.
        //For example, for a pair of 123 and 3456789, the answer would be “YES”, and for a pair of 500 and 99, “NO”.
        public static bool CheckDigits(int a, int b)
        {
            bool result = false;

            int temp = b;

            while (a != 0)
            {
                int tempA = a % 10;

                while (b != 0)
                {
                    int tempB = b % 10;

                    if (tempA == tempB)
                    {
                        return true;
                    }

                    b /= 10;
                }

                b = temp;
                a /= 10;
            }

            return result;
        }

    }
}
