using System;
using System.Security.Principal;
using System.Xml.Linq;

class Account
{
    public double AccountNumber { get; set; }
    public string OwnerName { get; set; }
    public double Balance { get; set; }

    public Account(double accountNumber, string ownerName, double balance)
    {
        AccountNumber = accountNumber;
        OwnerName = ownerName;
        Balance = balance;
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"{OwnerName}, вы успешно пополнили счет на {amount}. Новый баланс: {Balance}");
        }
        else
        {
            Console.WriteLine("Ошибка! Сумма пополнения должна быть положительной.");
        }
    }
    public void Withdraw(double amount)
    {
        if (amount > 0 && Balance >= amount)
        {
            Balance -= amount;
            Console.WriteLine($"{OwnerName}, вы успешно сняли {amount} со счета. Остаток: {Balance}");
        }
        else if (amount <= 0)
        {
            Console.WriteLine("Ошибка! Сумма снятия должна быть положительной.");
        }
        else
        {
            Console.WriteLine("Ошибка! Недостаточно средств на счете.");
        }
    }

    public void CheckBalance()
    {
        Console.WriteLine($"{OwnerName}, ваш текущий баланс: {Balance}");
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Номер счета: {AccountNumber}, Имя владельца: {OwnerName}, Баланс: {Balance}");
    }
}

class Program
{
    static void Main()
    {
        Account[] accounts = new Account[3];

        accounts[0] = new Account(1, "Ваня", 4654);
        accounts[1] = new Account(2, "Артем", 45646);
        accounts[2] = new Account(3, "Саша", 978794);

        for (int i = 0; i < accounts.Length; i++)
        {
            Console.WriteLine($"Аккаунт {i + 1}:");
            accounts[i].DisplayInfo();
            accounts[i].Deposit(1000);
            accounts[i].Withdraw(500);
            accounts[i].CheckBalance();
            Console.WriteLine();
        }
    }
}