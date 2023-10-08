namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter A: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter B: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine(a*b);
        }
    }
}
