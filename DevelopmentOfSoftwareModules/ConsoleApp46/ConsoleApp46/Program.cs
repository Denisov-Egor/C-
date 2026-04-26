// создайте класс train содержащий поля 
// название пункта назначения номер поезда время отправления
// ввести данные в массив из 5 эл типа упорядочить эл по номерам поездов


class Train
{
    public string Name;
    public int TrainNumber;
    public string DepartureTime;
}

public class Program
{
    static void Main()
    {
        Train[] trains = new Train[5];

        for (int i = 0; i < trains.Length; i++)
        {
            Console.WriteLine($"Введите данные для {i + 1} поезда:");
            string name = Console.ReadLine();
            int num = Convert.ToInt32(Console.ReadLine()); 
            string time = Console.ReadLine();

            trains[i] = new Train
            {
                Name = name,
                TrainNumber = num,
                DepartureTime = time
            };
        }

        Sort(trains);

        foreach (Train train in trains)
        {
            Console.WriteLine($"Номер: {train.TrainNumber}, Направление: {train.Name}, Отправление: {train.DepartureTime}");
        }
    }

    static void Sort(Train[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n;i++)
        {
            for (int j = 0; j < n - 1 - i; j++)
            {
                if (arr[j].TrainNumber > arr[j + 1].TrainNumber)
                {
                    Train temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }
}