using System;
using System.Runtime.ConstrainedExecution;

class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Position { get; set; }
    public double Salary { get; set; }

    public Employee(string name, int age, string position, double salary)
    {
        Name = name;
        Age = age;
        Position = position;
        Salary = salary;
    }

    public void RaiseSalary(double percentage)
    {
        if (percentage > 0)
        {
            Salary += Salary * percentage / 100;
            Console.WriteLine($"{Name} получил повышение на {percentage}%!");
        }
        else
        {
            Console.WriteLine("Некорректный процент повышения.");
        }
    }

    public void CalculateBonus(double bonusPercentage)
    {
        if (bonusPercentage > 0)
        {
            double bonus = Salary * bonusPercentage / 100;
            Console.WriteLine($"{Name} получил премию в размере {bonus} рб ({bonusPercentage}% от зарплаты).");
        }
        else
        {
            Console.WriteLine("Некорректный процент премии.");
        }
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Имя: {Name}");
        Console.WriteLine($"Возраст: {Age}");
        Console.WriteLine($"Должность: {Position}");
        Console.WriteLine($"Зарплате: {Salary} рб");
    }
}

class Program
{
    static void Main()
    {
        Employee[] employees = new Employee[]
        {
            new Employee("Игорь", 39, "Разработчик", 3000),
            new Employee("Антон", 45, "Тестировщик", 3500),
            new Employee("Саша", 29, "Менеджер", 4500),
            new Employee("Ваня", 18, "Разработчик", 3000)

        };

        foreach (Employee employee in employees)
        {
            Console.WriteLine();
            employee.DisplayInfo();

            Console.Write($"{employee.Name}, введите процент повышения зарплаты: ");
            double raisePercentage = Convert.ToDouble(Console.ReadLine());
            employee.RaiseSalary(raisePercentage);

            Console.Write($"{employee.Name}, введите процент премии: ");
            double bonusPercentage = Convert.ToDouble(Console.ReadLine());
            employee.CalculateBonus(bonusPercentage);
        }
    }
}