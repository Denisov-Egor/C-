public class Animal
{
    public string Food;
    public string Location;

    public Animal(string food, string location) 
    {
        Food = food;
        Location = location;
    }

    public void MakeNoise()
    {
        Console.WriteLine("такое животное спит");
    }

    public void Eat()
    {
        Console.WriteLine("такое животное ест");
    }

    public void Sleep()
    {
        Console.WriteLine("животное спит");
    }
}

public class Dog : Animal
{
    public string Dogs;

    public Dog(string food, string location, string dog) : base(food, location)
    {
        Dogs = dog;
    }
    0
    public new void MakeNoise()
    {
        Console.WriteLine("гав-гав");
    }

    public new void Eat()
    {
        Console.WriteLine("собака ест мясо");
    }
}

public class Cat : Animal
{
    public string Cats;

    public Cat(string food, string location, string cat) : base(food, location)
    {
        Cats = cat;
    }

    public new void MakeNoise()
    {
        Console.WriteLine("мяу-мяу");
    }

    public new void Eat()
    {
        Console.WriteLine("кошка ест корм");
    }
}

public class Horse : Animal
{
    public string Horses;

    public Horse(string food, string location, string hors) : base(food, location)
    {
        Horses = hors;
    }

    public new void MakeNoise()
    {
        Console.WriteLine("и-го-го");
    }

    public new void Eat()
    {
        Console.WriteLine($"Лошаль ест сено");
    }
}

public class Veterinal
{
    public void treatAnimal(Animal animal)
    {
        Console.WriteLine("Животное на приеме");
    }
}

public class Program
{
    static void Main()
    {
        Dog dog = new Dog("мясо", "будка", "питбуль");
        Cat cat = new Cat("корм", "дом", "рыжий");
        Horse horse = new Horse("сено", "конюшня", "конь");

        Veterinal vet = new Veterinal();

        vet.treatAnimal(dog);
        vet.treatAnimal(cat);
        vet.treatAnimal(horse);

        dog.MakeNoise();
        dog.Eat();

        cat.MakeNoise();
        cat.Eat();

        horse.MakeNoise();
        horse.Eat();
    }
}

    