// создать массив объектов структуры Person с полями
// Фамилия Имя Очество Адресс Образование Год рождения 
// создать массив объектов 
// вывести 
// список граждан возрас которых привышает заданный 
// список граждан с вышим образованием

using System;

public struct Person
{
    public string FirstName;
    public string LastName;
    public string MiddleName;
    public string Address;
    public string Education;
    public int YearOfBirth;

    public Person(string firstName, string lastName, string middleName, string address, string education, int yearOfBirth)
    {
        FirstName = firstName;
        LastName = lastName;
        MiddleName = middleName;
        Address = address;
        Education = education;
        YearOfBirth = yearOfBirth;
    }
}

public class Program
{
    public static void Main()
    {
            Person[] people = new Person[]
        {
                new Person("Иван", "Иванов", "Иванович", "ул. Советская, д.10", "Высшее", 20),
                new Person("Петр", "Петров", "Петрович", "ул. Ленина, д.25", "Среднее", 30),
                new Person("Василий", "Васильев", "Васильевич", "ул. Мира, д.40", "Высшее", 19),
                new Person("Ирина", "Иванова", "Ивановна", "ул. Кирова, д.55", "Среднее", 18)
        };

        Console.Write("Введите возрастные ограничения: ");
        int ageThreshold = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите уровень образования : ");
        string educationFilter = Console.ReadLine();

        Console.WriteLine($"\nСписок людей возрас которых привышает {ageThreshold} лет:");
        for (int i = 0; i < people.Length; i++)
        {
            if (people[i].YearOfBirth > ageThreshold)
            {
                Console.WriteLine($"{people[i].FirstName} {people[i].LastName}");
            }
        }

        Console.WriteLine($"\nСписок людей с образованием {educationFilter}:");
        for (int i = 0; i < people.Length; i++)
        {
            if (people[i].Education == educationFilter)
            {
                Console.WriteLine($"{people[i].FirstName} {people[i].LastName}");
            }
        }
    }
}