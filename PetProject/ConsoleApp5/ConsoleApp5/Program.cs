using System;
using System.Collections.Generic;

public class Player
{
    public string Name { get; set; }
    public int Health { get; set; } = 100;
    public int Attack { get; set; } = 10;

    public string GetStatus()
    {
        return $"Имя: {Name} | Здоровье: {Health} | Атака: {Attack}";
    }
}

public class Room
{
    public string Name { get; set; }
    public string Description { get; set; }

    public Room? Left { get; set; }
    public Room? Right { get; set; }
    public Room? Up { get; set; }
    public Room? Down { get; set; }

    public Enemy? Enemy { get; set; }
}

public class Enemy
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int Attack { get; set; }
    public string AttackName { get; set; }

    public string GetStatus()
    {
        return $"👹 {Name} (Здоровье: {Health})";
    }
}

public class GameScene
{
    private Player player;
    private Room currentRoom;

    public GameScene(Player player, Room startRoom)
    {
        this.player = player;
        if (startRoom != null)
        {
            this.currentRoom = startRoom;
        }
        else
        {
            Console.WriteLine("Ошибка: Начальная комната не задана!");
        }
    }

    public void ShowStatus()
    {
        if (currentRoom == null)
        {
            Console.WriteLine("Ошибка: Карта разрушена! Игра окончена.");
            return;
        }

        Console.WriteLine($"\n📍 {currentRoom.Name}: {currentRoom.Description}");
        Console.WriteLine(player.GetStatus());

    }

    public void Move()
    {
        Console.Write("Направление: (Up/Down/Left/Right): ");
        string? direction = Console.ReadLine()?.ToLower();

        switch (direction)
        {
            case "up":
                if (currentRoom.Up != null)
                {
                    currentRoom = currentRoom.Up;
                }
                else
                {
                    Console.WriteLine("⚠️ Нельзя пойти вверх.");
                }
                break;

            case "down":
                if (currentRoom.Down != null)
                {
                    currentRoom = currentRoom.Down;
                }
                else
                {
                    Console.WriteLine("⚠️ Нельзя пойти вниз.");
                }
                break;

            case "left":
                if (currentRoom.Left != null)
                {
                    currentRoom = currentRoom.Left;
                }
                else
                {
                    Console.WriteLine("⚠️ Нельзя пойти влево.");
                }
                break;

            case "right":
                if (currentRoom.Right != null)
                {
                    currentRoom = currentRoom.Right;
                }
                else
                {
                    Console.WriteLine("⚠️ Нельзя пойти вправо.");
                }
                break;

            case null:
            default:
                Console.WriteLine("Неверное направление.");
                break;
        }
    }

    public void Fight()
    {
        if (currentRoom.Enemy != null)
        {
            Console.WriteLine("\n⚔️ Встречен враг!");
            Console.WriteLine(currentRoom.Enemy.GetStatus());

            int damage = 0;
            do
            {
                Console.Write("Урон, который наносит герой: ");
                string input = Console.ReadLine() ?? "0";
                try
                {
                    damage = Convert.ToInt32(input);
                    if (damage > 0)
                    {
                        currentRoom.Enemy.Health -= damage;
                        Console.WriteLine($"💥 Нанесён урон {damage}. Здоровье врага: {currentRoom.Enemy.Health}");
                    }
                }
                catch
                {
                    damage = 0;
                }
            } while (currentRoom.Enemy.Health > 0);

            if (currentRoom.Enemy.Health <= 0)
            {
                Console.WriteLine("🎉 Враг повержен! Вы получили опыт.");
            }
            else
            {
                Console.WriteLine("🦠 Враг победил!");
                player.Health -= currentRoom.Enemy.Attack;
                Console.WriteLine($"Ваше здоровье: {player.Health}");
            }
        }
        else
        {
            Console.WriteLine("Здесь никого нет.");
        }
    }
}


public class Program
{
    public static void Main()
    {
        Console.Clear();
        Console.WriteLine("🕹 Добро пожаловать в Text RPG! Нажмите 'R', чтобы завершить игру.\n");

        var roomStart = new Room { Name = "Начало", Description = "Вы стоите в темном лабиринте." };
        var roomHall = new Room { Name = "Темный коридор", Description = "Впереди видите свет." };
        var roomTreasure = new Room { Name = "Тайник", Description = "Здесь лежит меч!" };
        var roomEnemy = new Room { Name = "Пещера", Description = "Здесь живет гигантский слизняк." };

        var player = new Player { Name = "Герой", Health = 100, Attack = 10 };

        roomStart.Right = roomHall;
        roomHall.Right = roomTreasure;
        roomTreasure.Right = roomEnemy;

        var enemy = new Enemy { Name = "Слизняк", Health = 50, Attack = 10, AttackName = "Кислотный удар" };
        roomEnemy.Enemy = enemy;

        var game = new GameScene(player, roomStart);
        Room currentRoom = roomStart; 

        while (player.Health > 0)
        {
            game.ShowStatus();
            game.Fight();
            game.Move();
        }

        Console.WriteLine("🔴 Игра окончена, игрок погиб. Перезапустите программу.");
    }
}
