using System;

namespace Helper

{
    public class ArrayHelper
    {
        public static void PrintArray(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentException();
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }

            Console.WriteLine();
        }

        public static int[] RandomArray(int a)
        {
            if (a < 0)
            {
                throw new ArgumentException();
            }

            int size = a;

            Random random = new Random();
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(1, 10);
            }

            return array;
        }

        public static void Sort(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentException();
            }

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        LinearEquations.Swap(ref array[i], ref array[j]);
                    }
                }
            }
        }

        //1. Find the minimum element of an array
        public static int GetMinElementOfArray(int[] array)
        {
            return array[GetMinIndexOfArray(array)];
        }


        //2. Find the maximum element of an array
        public static int GetMaxElementOfArray(int[] array)
        {
            return array[GetMaxIndexOfArray(array)];
        }


        //3. Find the index of the minimum element of the array
        public static int GetMinIndexOfArray(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentException();
            }

            int firstElement = array[0];
            int minIndex = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < firstElement)
                {
                    firstElement = array[i];
                    minIndex = i;
                }
            }

            return minIndex;
        }


        //4. Find the index of the maximum element of the array
        public static int GetMaxIndexOfArray(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentException();
            }

            int firstElement = array[0];
            int maxIndex = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > firstElement)
                {
                    firstElement = array[i];
                    maxIndex = i;
                }
            }

            return maxIndex;
        }


        //5. Calculate the sum of array elements with odd indices
        public static int GetSumOddIndices(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentException();
            }

            int sum = 0;

            for (int i = 1; i < array.Length; i += 2)
            {
                sum += array[i];
            }

            return sum;
        }


        //6. Make an array reverse (an array in the opposite direction)
        public static int[] GetReverse(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentException();
            }

            int count = 1;
            int[] newArray = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[array.Length - count];
                count++;
            }

            return newArray;
        }


        //7. Count the number of odd array elements
        public static int GetCountOddElements(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentException();
            }

            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    count++;
                }
            }

            return count;
        }


        //8. Swap the first and second half of the array, for example, for an array of 1 2 3 4, the result is 3 4 1 2, or for 1 2 3 4 5 -> 4 5 3 1 2.
        public static int[] SwapArray(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentException();
            }

            int half = array.Length - array.Length / 2;

            for (int i = 0; i < array.Length / 2; i++)
            {
                LinearEquations.Swap(ref array[i], ref array[half]);
                half++;
            }

            return array;
        }
    }
}
