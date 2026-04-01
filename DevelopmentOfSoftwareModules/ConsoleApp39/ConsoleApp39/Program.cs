// создать три класса первый описывает человека у него есть поля
// Имя Фамилия год рождения
// Второй описывается автомобиль у него есть поля
// название автор год выпуска
// третий описывает книгу у него есть поля
// название автор год выпуска
// в каждом класссе создать конструктор и метод который выводит значения всех полей
// в одном классе создать метод который принимает в качестве параметра два других объекта и выводит
// строку в формате <Имя человека> читает книгу <Название книги> про машину <Название машины>

using System;

public class Person
{
    public string FirstName;
    public string LastName;
    public int YearOfBirth;

    public Person(string firstName, string lastName, int yearOfBirth)
    {
        FirstName = firstName;
        LastName = lastName;
        YearOfBirth = yearOfBirth;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Имя: {FirstName}, Фамилия: {LastName}, Год рождения: {YearOfBirth}");
    }
}

public class Car
{
    public string Name;
    public string ;
}