using System;

namespace ITEA_HW4
{
    class Program
    {//..........
        static int[] CreateArray(int N)
        {
            int[] array = new int[N];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-10, 10);
            }

            return array;
        }

        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static int Task1(ref int[] array)
        {
            int min = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }

            return min;
        }
///
        static int Task2(ref int[] array)
        {
            int max = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            return max;
        }

        static int Task3(ref int[] array)
        {
            int indexMin = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < array[indexMin])
                {
                    indexMin = i;
                }
            }

            return indexMin;
        }

        static int Task4(ref int[] array)
        {
            int indexMax = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > array[indexMax])
                {
                    indexMax = i;
                }
            }

            return indexMax;
        }

        static int Task5(ref int[] array)
        {
            int sum = 0;

            for (int i = 1; i < array.Length; i += 2)
            {
                sum += array[i];
            }

            return sum;
        }

        static int[] Task6(ref int[] array)
        {
            int n = array.Length;

            for (int i = 0; i < n / 2; i++)
            {
                Swap(ref array[i], ref array[n - i - 1]);
            }

            return array;
        }

        static int Task7(ref int[] array)
        {
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    ++count;
                }
            }

            return count;
        }

        static void Task8(ref int[] array)
        {
            int n = array.Length;

            for (int i = 0; i < n / 2; i++)
            {
                Swap(ref array[i], ref array[n / 2 + i]);
            }
        }

        static int[] Task9(ref int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = array.Length - 1; j >= (i + 1); j--)
                {
                    if (array[j] < array[j - 1])
                    {
                        Swap(ref array[j], ref array[j - 1]);
                    }
                }
            }

            return array;
        }

        static void Task10(ref int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                for (int j = i; j > 0 && array[j - 1] < array[j]; j--)
                {
                    Swap(ref array[j - 1], ref array[j]);
                }
            }
        }

        static void Main(string[] args)
        {
            int[] array = CreateArray(10);

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }

            Console.WriteLine();

            Console.WriteLine(Task4(ref array));

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }
    }
}
