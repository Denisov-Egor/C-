using System;
using System.Xml.Linq;

class Product
{
    public string Name { get; set; }
    public double Price { get; set; }
    public double Quantity { get; set; }

    public Product(string name, double price, double quantity)
    {
        Name = name;
        Price = price; 
        Quantity = quantity;
    }

    public bool Sell(int quantityToSell)
    {
        if (quantityToSell <= 0 || quantityToSell > Quantity)
        {
            Console.WriteLine("Невозможно продать указанное количество товаров.");
            return false;
        }

        Quantity -= quantityToSell;
        Console.WriteLine($"Продано {quantityToSell} шт. товара '{Name}'. Осталось: {Quantity} шт.");
        return true;
    }

    public bool Restock(int quantityToAdd)
    {
        if (quantityToAdd <= 0)
        {
            Console.WriteLine("Невозможно добавить неположительное количество товара.");
            return false;
        }

        Quantity += quantityToAdd;
        Console.WriteLine($"Добавлено {quantityToAdd} шт. товара '{Name}'. Теперь на складе: {Quantity} шт.");
        return true;
    }


    public void DisplayInfo()
    {
        Console.WriteLine($"Имя: {Name}, Цена: {Price}, Кол-во  на складе: {Quantity}");
    }

class Program
{
        static void Main()
        {
            Product[] products = new Product[3];

            products[0] = new Product("Яблоко", 15.20, 55);
            products[1] = new Product("Морковь", 30.15, 100);
            products[2] = new Product("Груша", 20, 87);

            while (true)
            {
                Console.WriteLine("\nВыберите продукт для продажи или пополнения:");
                for (int i = 0; i < products.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {products[i].Name}");
                }
                Console.WriteLine("0. Выход");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice) || choice < 0 || choice > products.Length)
                {
                    Console.WriteLine("Неверный ввод. Попробуйте снова.");
                    continue;
                }

                if (choice == 0)
                {
                    break;
                }

                Product selectedProduct = products[choice - 1];
                selectedProduct.DisplayInfo();

                Console.WriteLine("\nВыберите действие:");
                Console.WriteLine("1. Продать товар");
                Console.WriteLine("2. Добавить товар на склад");
                int action;
                if (!int.TryParse(Console.ReadLine(), out action) || action < 1 || action > 2)
                {
                    Console.WriteLine("Неверный ввод. Попробуйте снова.");
                    continue;
                }

                if (action == 1)
                {
                    Console.Write($"Введите количество {selectedProduct.Name}, которое вы продали: ");
                    int quantityToSell = Convert.ToInt32(Console.ReadLine());
                    selectedProduct.Sell(quantityToSell);
                }
                else
                {
                    Console.Write($"Введите количество {selectedProduct.Name}, которое вы добавили на склад: ");
                    int quantityToAdd = Convert.ToInt32(Console.ReadLine());
                    selectedProduct.Restock(quantityToAdd);
                }
            }

            Console.WriteLine("Программа завершена.");
        }
    }
}