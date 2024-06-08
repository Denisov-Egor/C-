//Напишите программу, которая выведет сумму всех элементов массива.

using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];
            numbers[0] = 1;
            numbers[1] = 15;
            numbers[2] = 2;

            Console.WriteLine(numbers[0] + numbers[1] + numbers[2]);
        }
    }
}