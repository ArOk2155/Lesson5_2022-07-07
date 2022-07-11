using System;

namespace Helper
{
    public class IfElseHelper
    {
        //1.	The user enters 2 numbers (A and B). If A > B, result is A+B, if A=B, result is A * B, if A < B, result is A-B.
        public static int Condition1(int a, int b)
        {
            int result;

            if (a > b)
            {
                result = a + b;
            }
            else if (a == b)
            {
                result = a * b;
            }
            else
            {
                result = a - b;
            }

            return result;
        }


        //2.	The user enters 2 numbers (X and Y). Determine which quarter the point with coordinates (X, Y) belongs to.
        public static int GetCoordinateQuater(int x, int y)
        {
            int result = 0;
            if (x > 0 && y > 0)
            {
                result = 1;
            }
            else if (x > 0 && y < 0)
            {
                result = 2;
            }
            else if (x < 0 && y < 0)
            {
                result = 3;
            }
            else if (x < 0 && y > 0)
            {
                result = 4;
            }

            return result;
        }

        //3.	The user enters 3 numbers (A, B and C). Print them to the console in ascending order.
        public static (int a, int b, int c) SelectFromLowToHigh(int a, int b, int c)
        {
            if (a > b)
            {
                Helper.LinearEquations.Swap(ref a, ref b);
            }
            else if (a > c)
            {
                Helper.LinearEquations.Swap(ref a, ref c);
            }
            else if (b > c)
            {
                Helper.LinearEquations.Swap(ref b, ref c);
            }
            return (a, b, c);
        }

        //4.	The user enters 3 numbers (A, B and C). Print to the console the solution(X-values) of the standard form quadratic equation, where AX^2+BX+C=0.
        public static (double x1, double x2) GetRootOfQuadraticEquation(double a, double b, double c)
        {
            double x1 = double.NaN;
            double x2 = double.NaN;
            double d = b * b - 4 * a * c;

            if (a == 0 || d < 0)
            {
                throw new DivideByZeroException();
            }

            if (d > 0)
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
            }
            else if (d == 0)
            {
                x1 = -b / (2.0 * a);
                x2 = x1;
            }

            return (x1, x2);
        }

        //5.	The user enters a two-digit number. Print the capitalization of this number to the console. For example, typing "25" will print "twenty-five" to the console.
        public static string GetCapitalizationOfNumber(int a)
        {
            if (a < 10 || a > 99)
            {
                throw new ArgumentOutOfRangeException();
            }
            
            string firstNum = string.Empty;
            string secondNum = string.Empty;
            string result = string.Empty;

            int intNum = a / 10;
            int divisionRemainder = a % 10;

            if (intNum == 1)
            {
                switch (divisionRemainder)
                {
                    case 0:
                        firstNum = "ten";
                        break;
                    case 1:
                        firstNum = "eleven";
                        break;
                    case 2:
                        firstNum = "twelve";
                        break;
                    case 3:
                        firstNum = "thirteen";
                        break;
                    case 4:
                        firstNum = "fourteen";
                        break;
                    case 5:
                        firstNum = "fifteen";
                        break;
                    case 6:
                        firstNum = "sixteen";
                        break;
                    case 7:
                        firstNum = "seventeen";
                        break;
                    case 8:
                        firstNum = "eighteen";
                        break;
                    case 9:
                        firstNum = "nineteen";
                        break;
                }
            }
            else
            {
                switch (divisionRemainder)
                {
                    case 1:
                        secondNum = "one";
                        break;
                    case 2:
                        secondNum = "two";
                        break;
                    case 3:
                        secondNum = "three";
                        break;
                    case 4:
                        secondNum = "four";
                        break;
                    case 5:
                        secondNum = "five";
                        break;
                    case 6:
                        secondNum = "six";
                        break;
                    case 7:
                        secondNum = "seven";
                        break;
                    case 8:
                        secondNum = "eight";
                        break;
                    case 9:
                        secondNum = "nine";
                        break;
                }

                switch (intNum)
                {
                    case 2:
                        firstNum = "twenty";
                        break;
                    case 3:
                        firstNum = "thirty";
                        break;
                    case 4:
                        firstNum = "fourty";
                        break;
                    case 5:
                        firstNum = "fifty";
                        break;
                    case 6:
                        firstNum = "sixty";
                        break;
                    case 7:
                        firstNum = "seventy";
                        break;
                    case 8:
                        firstNum = "eighty";
                        break;
                    case 9:
                        firstNum = "ninety";
                        break;
                }

            }
            
            if (secondNum != string.Empty)
            {
                result = firstNum + "-" + secondNum;    
            }
            else
            {
                result = firstNum;
            }
            
            return (result);
        }
    }   

}

