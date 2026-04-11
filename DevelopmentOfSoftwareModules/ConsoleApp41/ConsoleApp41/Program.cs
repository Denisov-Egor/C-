// создать класс с приватными полями - адресс этаж кол-во комнат площадь
// создать массив объектов и вывести
// 1)список квартир имеющих заданное число комнат 
// 2)список кв имеющих расположение на заданном этаже

using System;

public class Apartment
{
    private string address;
    private int floor;
    private int numberOfRooms;
    private double area;

    public Apartment(string address, int floor, int numberOfRooms, double area)
    {
        this.address = address;
        this.floor = floor;
        this.numberOfRooms = numberOfRooms;
        this.area = area;
    }

    public string Address
    {
        get { return address; }
    }

    public int Floor
    {
        get { return floor; }
    }

    public int NumberOfRooms
    {
        get { return numberOfRooms; }
    }

    public double Area
    {
        get { return area; }
    }
}

class Program
{
    static void Main()
    {
        Apartment[] apartments = new Apartment[]
        {
            new Apartment("Address1", 1, 2, 60.5),
            new Apartment("Address2", 3, 4, 90.0),
            new Apartment("Address3", 1, 3, 75.0),
            new Apartment("Address4", 2, 2, 55.0)
        };

        int targetNumberOfRooms = 2;
        Console.WriteLine($"Квартиры с {targetNumberOfRooms} комнатами:");
        foreach (var apartment in apartments)
        {
            if (apartment.NumberOfRooms == targetNumberOfRooms)
            {
                Console.WriteLine($"Адрес: {apartment.Address}, Этаж: {apartment.Floor}, Комнаты: {apartment.NumberOfRooms}, Площадь: {apartment.Area}");
            }
        }

        int targetFloor = 1;
        Console.WriteLine($"\nКвартиры на этаже {targetFloor}:");
        foreach (var apartment in apartments)
        {
            if (apartment.Floor == targetFloor)
            {
                Console.WriteLine($"Адрес: {apartment.Address}, Этаж: {apartment.Floor}, Комнаты: {apartment.NumberOfRooms}, Площадь: {apartment.Area}");
            }
        }
    }
}
