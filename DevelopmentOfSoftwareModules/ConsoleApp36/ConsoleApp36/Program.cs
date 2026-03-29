// создать массив объектов file с полями 
// имя файла размер дата создания кол-во обращений 
// создать массив объектов 
// вывести 
// список файло размер которых привышает заданный
// список файло число обращений к которым привышает заданное 

using System;

public class File
{
    public string Name;
    public int Size;
    public DateTime CreationDate;
    public int AccessCount;

    public File(string name, int size, DateTime creationDate, int accessCount)
    {
        Name = name;
        Size = size;
        CreationDate = creationDate;
        AccessCount = accessCount;
    }

   /* public override string ToString()
    {
        return $"Имя файла: {Name}, Размер: {Size} байтов, Дата создания: {CreationDate}, Количество обращений: {AccessCount}";
    }*/
}

class Program
{
    static void Main()
    {
        File[] files = new File[]
        {
            new File("file1.txt", 1024, new DateTime(2026, 3, 12), 5),
            new File("file2.txt", 2048, new DateTime(2023, 2, 10), 10),
            new File("file3.txt", 512, new DateTime(2026, 4, 1), 7),
            new File("file4.txt", 4096, new DateTime(2026, 6, 5), 15)
        };

        Console.Write("Введите минимальный размер файла (в байтах): ");
        int minSize = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите минимальное количество обращений: ");
        int minAccessCount = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("Файлы с размером больше " + minSize + " байтов:");
        for (int i = 0; i < files.Length; i++)
        {
            if (files[i].Size > minSize)
                Console.WriteLine($"Имя файла: {files[i].Name}, Размер: {files[i].Size} байтов, Дата создания: {files[i].CreationDate}, Количество обращений: {files[i].AccessCount}");
        }

        Console.WriteLine("\nФайлы с числом обращений, превышающим " + minAccessCount + ":");
        for (int i = 0; i < files.Length; i++)
        {
            if (files[i].AccessCount > minAccessCount)
                Console.WriteLine($"Имя файла: {files[i].Name}, Размер: {files[i].Size} байтов, Дата создания: {files[i].CreationDate}, Количество обращений: {files[i].AccessCount}");
        }
    }
}
