using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество элементов в массиве: ");
        int SIZE = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[SIZE];

        for (int i = 0; i < SIZE; i++)
        {
            Console.Write($"Введите элемент {i + 1}: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        QuickSort(arr, 0, arr.Length - 1);

        for (int i = 0; i < SIZE; i++)
        {
            Console.Write($"{arr[i]} ");
        }
    }
    // рек метод быстрой сорт, вывод отсорт массива 
    static void QuickSort(int[] arr, int low, int high)
    {
        if (low < high)
        {
            // опорн эл
            int pi = Partition(arr, low, high);

            // Рекурсивно сортируем лв и пр часть
            QuickSort(arr, low, pi - 1);
            QuickSort(arr, pi + 1, high);
        }
    }
    // разбиваем массив
    static int Partition(int[] arr, int low, int high)
    {
        // Выбор последнего элемента как опорного
        int pivot = arr[high];
        int i = (low - 1); // Индекс меньшего элемента

        for (int j = low; j < high; j++)
        {
            if (arr[j] <= pivot)
            {
                i++;
                // Меняем местами arr[i] и arr[j]
                /*int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;*/
            }
        }

        // Меняем местами элемент после последнего меньшего и опорный элемент
        int temp = arr[i + 1];
        arr[i + 1] = arr[high];
        arr[high] = temp;

        return (i + 1);
    }

}
