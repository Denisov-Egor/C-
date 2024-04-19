using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int frends = 10;

            //frends = frends + 1;
            //frends += 2;
            //frends++;

            //frends = frends - 1;
            //frends -= 2;
            //frends--;

            //frends = frends * 1;
            //frends *= 2;

            //frends = frends / 2;
            //frends /= 2;

            int remainder = frends % 3;

            Console.WriteLine(frends);
            Console.WriteLine(remainder);
        }
    }
}