// создайте массив объекта класса product c полями:
// наименование производитель цена срок храниения количество
// ввести товары с заданным наименованием 

using System;

public class Product
{
    public string Name;
    public string Manufacturer;
    public double Price;
    public int StorageLife;
    public int Quantity;

    public Product(string name, string manufacturer, double price, int storageLife, int quantity)
    {
        Name = name;
        Manufacturer = manufacturer;
        Price = price;
        StorageLife = storageLife;
        Quantity = quantity;
    }

    public override string ToString()
    {
        return $"Имя: {Name}, Производитель: {Manufacturer}, Цена: {Price}, Срок хранения: {StorageLife} дни, Кол-во: {Quantity}";
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Product[] products = new Product[]
        {
            new Product("Апельсин", "Фруктовый фермер", 1.50, 30, 10),
            new Product("Молоко", "Молочная ферма.", 2.50, 7, 5),
            new Product("Хлеб", "Хлебная ферма", 2.00, 14, 8),
            new Product("Яблоко", "Яблочная ферма", 1.30, 30, 15)
        };


        Console.Write("Введите наименование товара для поиска: ");
        string searchName = Console.ReadLine();

        for (int i = 0; i < products.Length; i++)
        {
            if (products[i].Name.Equals(searchName, StringComparison.OrdinalIgnoreCase))
                Console.WriteLine(products[i]);
        }
    }
}
