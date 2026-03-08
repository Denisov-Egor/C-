// сортировка перемешиванием
using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество строк: ");
        int height = int.Parse(Console.ReadLine());

        Console.Write("Введите количество столбцов: ");
        int width = int.Parse(Console.ReadLine());

        int[,] arr = new int[height, width];

        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                Console.Write($"Введите элемент [{i + 1}, {j + 1}]: ");
                arr[i, j] = int.Parse(Console.ReadLine());
            }
        }
        // перобр в одномер масс
        int[] myint = FlattenArray(arr);

        ShakerSort(myint);

        // Преобразование в двумерный массив
        UnflattenArray(myint, arr, height, width);

        Console.WriteLine("\nОтсортированный массив:");
        Print2DArray(arr);
    }

    static int[] FlattenArray(int[,] array)
    {
        int height = array.GetLength(0);
        int width = array.GetLength(1);

        // созд одномерного массива 
        int[] result = new int[height * width];

        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                result[i * width + j] = array[i, j];
            }
        }

        return result;
    }

    static void UnflattenArray(int[] flattenedArray, int[,] array, int height, int width)
    {
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                array[i, j] = flattenedArray[i * width + j];
            }
        }
    }

    static void ShakerSort(int[] myint)
    {
        int n = myint.Length;
        bool swapped;

        do
        {
            swapped = false;

            // перемещает слева на  право
            for (int i = 0; i < n - 1; i++)
            {
                if (myint[i] > myint[i + 1])
                {
                    int temp = myint[i];
                    myint[i] = myint[i + 1];
                    myint[i + 1] = temp;
                    swapped = true;
                }
            }

            // проверка на отсорт массив
            if (!swapped)
                break;

            // уменьшаем на 1 так как последний эл уже на месте     
            n--;

            // перемещаемся справа налево
            for (int i = n - 1; i > 0; i--)
            {
                if (myint[i] < myint[i - 1])
                {
                    int temp = myint[i];
                    myint[i] = myint[i - 1];
                    myint[i - 1] = temp;
                    swapped = true;
                }
            }
        } while (swapped);
    }

    static void Print2DArray(int[,] array)
    {
        int height = array.GetLength(0);
        int width = array.GetLength(1);

        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
