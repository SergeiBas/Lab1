using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            
            if ((x*x + (y*y)/4 < 1) | ((x*x)/4 + y*y < 1) & y < 2 & y > -2 & x < 2 & x > -2)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
