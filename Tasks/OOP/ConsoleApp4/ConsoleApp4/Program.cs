using System;

class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public int Mileage { get; private set; }

    public Car(string brand, string model, int year)
    {
        Brand = brand;
        Model = model;
        Year = year;
        Mileage = 0;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Марка: {Brand}");
        Console.WriteLine($"Модель: {Model}");
        Console.WriteLine($"Год выпуска: {Year}");
        Console.WriteLine($"Пробег: {Mileage} км");
    }

    public void IncreaseMileage(int additionalMileage)
    {
        if (additionalMileage < 0)
        {
            throw new ArgumentException("Пробег не может быть отрицательным.", nameof(additionalMileage));
        }
        Mileage += additionalMileage;
    }
}

class Program
{
    static void Main()
    {
        Car[] cars = new Car[]
        {
            new Car("Toyota", "Corolla", 2018),
            new Car("Ford", "Mustang", 2020),
            new Car("Chevrolet", "Camaro", 2021)
        };

        for (int i = 0; i < cars.Length; i++)
        {
            Console.Write($"Введите пробег для {cars[i].Brand} {cars[i].Model} (в км): ");
            int additionalMileage;
            while (!int.TryParse(Console.ReadLine(), out additionalMileage) || additionalMileage < 0)
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите положительное число для пробега.");
            }
            cars[i].IncreaseMileage(additionalMileage);
        }


        foreach (Car car in cars)
        {
            car.DisplayInfo();
            Console.WriteLine(); 
        }
    }
}