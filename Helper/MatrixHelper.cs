using System;

namespace Helper
{
    public class MatrixHelper
    {
        public static int[,] GenerateMatrix(int x, int y)
        {
            if (x <= 0 || y <= 0)
            {
                throw new ArgumentException();
            }

            Random random = new Random();
            int[,] matrix = new int[x, y];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(0, x * y);
                }
            }

            return matrix;
        }

        public static int[,] ReverseMatrix(int[,] matrix)
        {
            if (matrix == null)
            {
                throw new ArgumentException();
            }

            for (int i = 0, count = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1) && count < matrix.Length / 2; j++, count++)
                {
                   LinearEquations.Swap(ref matrix[i, j], ref matrix[matrix.GetLength(0) - 1 - i, matrix.GetLength(1) - 1 - j]);
                }
            }

            return matrix;
        }

        public static void PrintMatrix(int[,] matrix)
        {
            if (matrix == null)
            {
                throw new ArgumentException();
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }

        //3.	Find the index of the minimum element of the array
        public static int[] GetMinIndexOfMatrix(int[,] matrix)
        {
            if (matrix == null || matrix.Length == 0)
            {
                throw new ArgumentException();
            }
            
            int xMinIndex = 0;
            int yMinIndex = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < matrix[xMinIndex, yMinIndex])
                    {
                        xMinIndex = i;
                        yMinIndex = j;
                    }
                }  
            }
            
            int[] array = new int[] { xMinIndex, yMinIndex };
            
            return (array);
        }

        //1.	Find the minimum element of an array
        public static int GetMinElementOfMatrix(int[,] matrix)
        {
            int[] array = GetMinIndexOfMatrix(matrix);
            
            int result = matrix[array[0], array[1]]; 

            return result;
        }

        //4.	Find the index of the maximum element of the array
        public static int[] GetMaxIndexOfMatrix(int[,] matrix)
        {
            if (matrix == null || matrix.Length == 0)
            {
                throw new ArgumentException();
            }

            int xMaxIndex = 0;
            int yMaxIndex = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > matrix[xMaxIndex, yMaxIndex])
                    {
                        xMaxIndex = i;
                        yMaxIndex = j;
                    }
                }
            }

            int[] array = new int[] { xMaxIndex, yMaxIndex };

            return (array);
        }

        //2.	Find the maximum element of an array
        public static int GetMaxElementOfMatrix(int[,] matrix)
        {
            int[] array = GetMaxIndexOfMatrix(matrix);

            int result = matrix[array[0], array[1]];

            return result;
        }

        //5.	Find the number of array elements that are greater than all their neighbors at the same time

        //6.	Flip an array about its main diagonal
        public static int[,] GetFlippedArrayAboutItsMainDiagonal(int[,] matrix)
        {
            if (matrix == null || matrix.GetLength(0) != matrix.GetLength(1) || matrix.Length != 0)
            {
                throw new ArgumentException();
            }

            int[,] flippedArray = new int[matrix.GetLength(0), matrix.GetLength(1)];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i != j)
                    {
                        flippedArray[i, j] = matrix[matrix.GetLength(0) - 1 - i, matrix.GetLength(1) - 1 - j];
                    }
                    else
                    {
                        flippedArray[i, j] = matrix[i, j];
                    }
                }
            }

            return flippedArray;
        }
    }
}
