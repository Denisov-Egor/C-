using System;

public enum DaysOfWeek
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

public class Program
{
    public static void Main()
    {
        // получаем массив значений и преобразуем в массив
        DaysOfWeek[] days = Enum.GetValues(typeof(DaysOfWeek)).Cast<DaysOfWeek>().ToArray();

        Console.WriteLine("Дни недели: ");
        for (int i = 0; i < days.Length; i++)  
        {
            Console.WriteLine($"{i + 1}: {days[i]}");
        }

        // получение рб дней и выходных с помощью метода
        DaysOfWeek[] weekdays = GetWeekdays();
        DaysOfWeek[] weekends = GetWeekends();

        Console.WriteLine("\nРабочие дни:");
        foreach (var day in weekdays)
        {
            Console.WriteLine(day);
        }

        Console.WriteLine("\nВыходные дни:");
        foreach (var day in weekends)
        {
            Console.WriteLine(day);
        }
    }

    // возвращяем массив 
    public static DaysOfWeek[] GetWeekdays()
    {
        return Enum.GetValues(typeof(DaysOfWeek)).Cast<DaysOfWeek>().Where(d => d != DaysOfWeek.Saturday && d != DaysOfWeek.Sunday).ToArray();
    }

    public static DaysOfWeek[] GetWeekends()
    {
        return new DaysOfWeek[]
        {
            DaysOfWeek.Saturday,
            DaysOfWeek.Sunday
        };
    }
}
