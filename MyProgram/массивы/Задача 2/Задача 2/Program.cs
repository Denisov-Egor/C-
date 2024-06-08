// Напишите программу, которая выведет максимальное число в массиве.

using System;

namespace MyApp
{
    class Program
    { 
        static void Main(string[] args)
        {
            int[] number = new int[3];
            number[0] = 1;
            number[1] = 15;
            number[2] = 2;

            if (number[0] > number[1] && number[0] > number[1])
            {
                Console.WriteLine(number[0]);
            }
            else if (number[1] > number[0] && number[1] > number[2])
            {
                Console.WriteLine(number[1]);
            }
            else
            {
                Console.WriteLine(number[2]);
            }
        }
    }
}