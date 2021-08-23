using System;

namespace bubblesort
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 500;
            int[] arr = CreateArray(size);
            
            BubbleSort(arr);
            PrintArray(arr);
            Console.Read();
        }

        static int[] CreateArray(int size)
        {
            Random rng = new();

            int[] array = new int[size];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rng.Next(500);
            }
            return array;
        }

        static void BubbleSort(int[] arr)
        {
            int temp;
            bool swap;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                swap = false;
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swap = true;
                    }
                }

                if (swap == false)
                    break;
            }
        }

        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
