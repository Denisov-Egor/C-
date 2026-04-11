// разработать класс для объекта Student с privat полями ФИО (чтение и записи), дата поступления (запись), адресс(чтение) телефон (чтение и запись) курс (запись) факультет (чтение)
// включить в класс метод доступа. 
// создать массив из трех объектов 
// вывести фио всех сотудников список сдутентов заданного факультета список сотрудников поступающих после заданного года
// создать класс с полями wight (ширина) и height (высота) сделать привытными 
// сеттеры должны проверять чтобы значение были больше нуля 
// добавить методы getArea() (площать) и getPremier() (приметер) возваращаемые значения

using System;

public class Student
{
    private string fullName;
    private DateTime admissionDate;
    public string Address { get; set; }
    private string phoneNumber;
    private int course;
    private string faculty;

    public string FullName
    {
        get { return fullName; }
        set { fullName = value; }
    }

    public DateTime AdmissionDate
    {
        get { return admissionDate; }
        set { admissionDate = value; }
    }

    public string PhoneNumber
    {
        get { return phoneNumber; }
        set { phoneNumber = value; }
    }

    public int Course
    {
        get { return course; }
        set { course = value; }
    }

    public string Faculty
    {
        get { return faculty; }
        set { faculty = value; }
    }

    public Student(string fullName, DateTime admissionDate, string address, string phoneNumber, int course, string faculty)
    {
        FullName = fullName;
        AdmissionDate = admissionDate;
        Address = address;
        PhoneNumber = phoneNumber;
        Course = course;
        Faculty = faculty;
    }
}

public class Rectangle
{
    private double width;
    private double height;

    public double Width
    {
        get { return width; }
        set
        {
            if (value > 0)
                width = value;
            else
                throw new ArgumentException("Ширина должна быть больше нуля");
        }
    }

    public double Height
    {
        get { return height; }
        set
        {
            if (value > 0)
                height = value;
            else
                throw new ArgumentException("Высота должна быть больше нуля");
        }
    }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public double GetArea()
    {
        return Width * Height;
    }

    public double GetPerimeter()
    {
        return 2 * (Width + Height);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student[] students = new Student[]
        {
            new Student("Иванов Иван", new DateTime(2019, 9, 1), "Город, улица, дом", "+71234567890", 1, "Факультет Компьютерных Наук"),
            new Student("Петров Петр", new DateTime(2020, 9, 1), "Город, улица, дом", "+79876543210", 2, "Экономический Факультет"),
            new Student("Сидоров Сидор", new DateTime(2018, 9, 1), "Город, улица, дом", "+75555555555", 3, "Факультет Компьютерных Наук")
        };

        Console.WriteLine("Список всех студентов:");
        foreach (var student in students)
        {
            Console.WriteLine(student.FullName);
        }

        string targetFaculty = "Факультет Компьютерных Наук";
        Console.WriteLine($"\nСписок студентов факультета {targetFaculty}:");
        foreach (var student in students)
        {
            if (student.Faculty == targetFaculty)
            {
                Console.WriteLine(student.FullName);
            }
        }

        int targetYear = 2019;
        Console.WriteLine($"\nСписок студентов поступивших после {targetYear}:");
        foreach (var student in students)
        {
            if (student.AdmissionDate.Year > targetYear)
            {
                Console.WriteLine(student.FullName);
            }
        }

        Rectangle rect = new Rectangle(5, 10);
        Console.WriteLine($"\nПлощадь прямоугольника: {rect.GetArea()}");
        Console.WriteLine($"Периметр прямоугольника: {rect.GetPerimeter()}");
    }
}
