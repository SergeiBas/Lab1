using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            
            if ((y <= 1 & x <= 1 & x >= -1) && (x >= -1 & y >= -1) 
                                            || (y - x >= -2 & y >= -2 & y <= 0 & x >= 0 & x <= 2))
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
