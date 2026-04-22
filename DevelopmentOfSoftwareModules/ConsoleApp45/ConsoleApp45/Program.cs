// Создайте класс с именем tain содержащий поля название пункта назначения номер поезда время отправления 
// ввести данные в массив из 5 эл типа train упорядочить эл по номерам поездов 
// добавить возможность вывода информаций о поезде номер которого введен пользовтелем 

using System;

class Train
{
    public string Destination { get; set; }
    public int TrainNumber { get; set; }
    public string DepartureTime { get; set; }

    public override string ToString()
    {
        return $"Поезд №{TrainNumber}, назначение: {Destination}, отправление: {DepartureTime}";
    }
}

class Program
{
    static void Main()
    {
        Train[] trains = new Train[5];

        Console.WriteLine("Введите данные о 5 поездах:");
        for (int i = 0; i < trains.Length; i++)
        {
            Console.WriteLine($"Поезд {i + 1}:");

            Console.Write("Пункт назначения: ");
            string dest = Console.ReadLine();

            int number;            
            while (true)
            {
                Console.Write("Номер поезда: ");
                if (int.TryParse(Console.ReadLine(), out number))
                    break;
                Console.WriteLine("Ошибка! Введите целое число.");
            }

            Console.Write("Время отправления: ");
            string time = Console.ReadLine();

            trains[i] = new Train { Destination = dest, TrainNumber = number, DepartureTime = time };
        }

        SortArray(trains);

        Console.WriteLine("Введите номер поезда");
        if (int.TryParse(Console.ReadLine(), out int searchNumber))
        {
            Train found = FindTrainByNumber(trains, searchNumber);
            Console.WriteLine($"Информация {found}");
        }

        static void SortArray(Train[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j].TrainNumber > arr[j+1].TrainNumber)
                    {
                        Train temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = temp;
                    }
                }
            }
        }

        static Train FindTrainByNumber(Train[] arr, int number)
        {
            foreach (Train train in arr)
            {
                if (train.TrainNumber == number)
                    return train;
            }
            return null;
        }
    }
}