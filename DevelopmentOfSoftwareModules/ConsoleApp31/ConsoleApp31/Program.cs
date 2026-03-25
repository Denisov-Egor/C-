// создать массив объектов класса с полями 
// фамилия имя должность год поступления на рботу зарплата 
// вывести список работников зп которых больше заданной

using System;

public class Employee
{
    public string FirstName;
    public string LastName;
    public string Position;
    public int YearOfHiring;
    public double Salary;

    public Employee(string firstName, string lastName, string position, int yearOfHiring, double salary)
    {
        FirstName = firstName;
        LastName = lastName;
        Position = position;
        YearOfHiring = yearOfHiring;
        Salary = salary;
    }
}

public class Program
{
    public static void PrintEmployee(Employee employee)
    {
        Console.WriteLine($"{employee.LastName} {employee.FirstName}, Должность: {employee.Position}, Год поступления на работу: {employee.YearOfHiring}, Зарплата: {employee.Salary}");
    }

    public static void Main(string[] args)
    {
        Employee[] employees = new Employee[]
        {
            new Employee("Иван", "Петров", "Менеджер", 2015, 75000),
            new Employee("Сергей", "Сидоров", "Инженер", 2018, 65000),
            new Employee("Ольга", "Иванова", "Программист", 2020, 80000),
            new Employee("Елена", "Петрова", "Дизайнер", 2017, 55000)
        };

        Console.Write("Введите порог зарплаты: ");
        double salaryThreshold = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Сотрудники с зарплатой выше {salaryThreshold}:");
        for (int i = 0; i < employees.Length; i++)
        {
            if (employees[i].Salary > salaryThreshold)
            {
                PrintEmployee(employees[i]);
            }
        }
       
    }
}

