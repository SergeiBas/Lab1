using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            Console.Write((5 * Math.Pow(x, 3)) *
                          (Math.Pow(1 / Math.Pow(x, 2) + (1 / Math.Pow(x, 3)), (1 / 5.0))));
        }
    }
}
