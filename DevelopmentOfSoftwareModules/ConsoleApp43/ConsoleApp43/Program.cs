using CompanyNamespace;
using CompanyNamespace.DepartmentA;
using System;

namespace CompanyNamespace
{
    namespace DepartmentA
    {
        public class Person
        {
            public string Фамилия { get; set; }
            public string Имя { get; set; }
            public int Возраст { get; set; }

            public void PrintInfo()
            {
                Console.WriteLine($"{Фамилия} {Имя}, возраст: {Возраст}");
            }
        }
    }

    namespace DepartmentB
    {
        public class Employee : Person
        {
            public DateTime ДатаПоступленияНаРаботу { get; set; }
            public string Должность { get; set; }
            public double Зарплата { get; set; }

            public new void PrintInfo()
            {
                Console.WriteLine($"{Фамилия} {Имя}, возраст: {Возраст}, дата поступления на работу: {ДатаПоступленияНаРаботу.ToShortDateString()}, должность: {Должность}, зарплата: {Зарплата}");
            }
        }
    }

    public class Company
    {
        public string Название { get; set; }

        public void PrintCompanyInfo(Person person)
        {
            Console.WriteLine($"{person.Фамилия} {person.Имя} работает в компании {Название} {person.GetType().GetProperty("Должность").GetValue(person, null)}");
        }
    }
}

class Program
{
    static void Main()
    {
        CompanyNamespace.DepartmentA.Person person = new CompanyNamespace.DepartmentA.Person
        {
            Фамилия = "Иванов",
            Имя = "Иван",
            Возраст = 30
        };

        CompanyNamespace.DepartmentB.Employee employee = new CompanyNamespace.DepartmentB.Employee
        {
            Фамилия = "Петров",
            Имя = "Пётр",
            Возраст = 25,
            ДатаПоступленияНаРаботу = DateTime.Now.AddYears(-3),
            Должность = "Менеджер",
            Зарплата = 50000
        };

        person.PrintInfo();
        employee.PrintInfo();

        Company company = new Company { Название = "WB" };
        company.PrintCompanyInfo(employee);
    }
}
