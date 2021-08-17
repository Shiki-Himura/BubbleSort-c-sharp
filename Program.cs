using System;

namespace bubblesort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = CreateArray();

            Console.WriteLine("Array: ");
            PrintArray(arr);
            Console.WriteLine("\n" + "------------------------------------------------------");

            Console.WriteLine("Sorted Array: ");
            BubbleSort(arr);
            PrintArray(arr);
            Console.Read();
        }

        static int[] CreateArray()
        {
            Random rng = new();

            int[] array = new int[25];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rng.Next(0, 500);
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
