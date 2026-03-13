using System;
using System.Runtime.InteropServices;
using System.Xml.Linq;

class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string GroupNumber { get; set; }
    private List<int> Grades { get; set; }


    public Student(string name, int age, string groupNumber)
    {
        Name = name;
        Age = age;
        GroupNumber = groupNumber;
        Grades = new List<int>();
    }

    public void AddGrades(int grade)
    {
        if (grade >= 0 && grade <= 5)
        {
            Grades.Add(grade);
        }
        else
        {
            Console.WriteLine("Неверная оценка. Допустимый диапазон: 0-5.");
        }
    }

    public double CalculateAverageGrade()
    {
        if (Grades.Count == 0)
        {
            return 0;
        }
        int totalSum = 0;
        foreach (int grade in Grades)
        {
            totalSum += grade;
        }
        return (double)totalSum / Grades.Count;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Имя: {Name}, Возраст: {Age}, Номер группы: {GroupNumber}");

        if (Grades.Count > 0)
        {
            Console.Write("Оценки: ");
            foreach (int grade in Grades)
            {
                Console.Write($"{grade} ");
            }
            Console.WriteLine($"\nСредний балл: {CalculateAverageGrade():F2}");
        }
        else
        {
            Console.WriteLine("Нет оценок.");
        }
    }
}

class Program
{
    static void Main()
    {
        Student[] students = new Student[3];

        students[0] = new Student("Иван Иванов", 20, "Группа А");
        students[1] = new Student("Мария Петрова", 21, "Группа Б");
        students[2] = new Student("Алексей Сидоров", 22, "Группа В");

        for (int i = 0; i < students.Length; i++)
        {
            Console.WriteLine($"Студент {i + 1}:");
            students[i].DisplayInfo();
            Console.WriteLine();

            Console.Write("Введите количество оценок для студента {i + 1} (0 для пропуска): ");
            int numGrades = int.Parse(Console.ReadLine());

            if (numGrades > 0)
            {
                for (int j = 0; j < numGrades; j++)
                {
                    Console.Write($"Введите оценку {j + 1}: ");
                    int grade = int.Parse(Console.ReadLine());
                    students[i].AddGrades(grade);
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Информация о студенте {i + 1} после добавления оценок:");
            students[i].DisplayInfo();
            Console.WriteLine();
        }
    }
}
   
