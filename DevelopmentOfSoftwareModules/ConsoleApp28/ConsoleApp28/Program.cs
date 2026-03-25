using System;

class Calculator
{
    public double x;
    public double z;

    public Calculator(double x, double z)
    {
        this.x = x; 
        this.z = z;
    }

    public double X
    {
        get { return x; }
        set { x = value; }
    }

    public double Z
    {
        get { return z; }
        set { z = value; }
    }
    public double Formula1()
    {
        double result = 3 * this.X + 5;
        Console.WriteLine($"3 * {this.x} + 5 = {result}");

        return result;
    }
    public double Formula2()
    {
        if (this.x == this.z)
        {
            Console.WriteLine("Ошибка x - z = 0");
            return double.NaN;
        }
        double result = (this.x + this.z) / (this.x - this.z);
        Console.WriteLine($" ({this.x} + {this.z}) / ({this.x} - {this.z})");

        return result;
    }
    public long Formula3()
    {
        double sum = this.x + this.z;

        if (sum < 0 || sum != (int)sum)
        {
            Console.WriteLine("Ошибка: сумма должна быть целым чилом");
            return -1;
        }

        int n = (int)sum;
        long frac = 1;

        for (int i = 2; i <= n; i++)
        {
            frac *= i;
        }
        Console.WriteLine($"({this.x} + {this.z})! = {frac}");

        return frac;
    }

    public void Print()
    {
        this.Formula1();
        this.Formula2();
        this.Formula3();
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Введите x: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Введите z: ");
        double z = double.Parse(Console.ReadLine());

        Calculator calc = new Calculator(x, z);
        calc.Print();
    }
}


