using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            Console.Write(Math.Pow(2,(-x)) * Math.Sqrt(x + Math.Pow(Math.Abs(x), 1 / 4.0)));
        }
    }
}
