using System;

namespace MeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // ПРИМЕР 1
            String fullName = "Fastick Des";

            fullName = fullName.ToUpper(); // Все с заглавной буквы
            fullName = fullName.ToLower(); // Все с маленькой буквы

            Console.WriteLine(fullName);

            // ПРИМЕР 2
            String phoneNumber = "123-456-1890";

            phoneNumber = phoneNumber.Replace("-", "/"); // Замена символов

            Console.WriteLine(phoneNumber);

            // ПРИМЕР 3
            String userName = fullName.Insert(0, "@"); // Вставляет символ перед индексом 

            Console.WriteLine(userName);

            // ПРИМЕР 4
            Console.WriteLine(fullName.Length); // Кол-во символов 

            // ПРИМЕР 5
            String firstName = fullName.Substring(0, 3); // Вывод определенных символов
            String lastName = fullName.Substring(4, 4); // Вывод определенных символов

            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
        }
    }
}