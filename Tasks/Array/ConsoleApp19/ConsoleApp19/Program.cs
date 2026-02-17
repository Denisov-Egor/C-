// Напишите программу, которая сортирует массив строк в алфавитном порядке с использованием метода пузырька.

using System;

class Program
{
    static void Main()
    {
        string[] words = { "яблоко", "Апельсин", "банан", "Груша", "вишня" };

        Console.WriteLine("Исходный массив:");
        PrintArray(words);

        BubbleSort(words);

        Console.WriteLine("\nОтсортированный массив:");
        PrintArray(words);

        static void BubbleSort(string[] array)
        {
            int n = array.Length;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (string.Compare(array[j], array[j + 1], StringComparison.CurrentCulture) > 0)
                    {
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }

        }

        static void Swap(ref string a, ref string b)
        {
            string temp = a;
            a = b;
            b = temp;
        }

        static void PrintArray(string[] array)
        {
            foreach (string item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}