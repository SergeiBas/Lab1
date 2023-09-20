namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter C: ");
            float C = float.Parse(Console.ReadLine());
            Console.WriteLine("r = " + C / (2 * Math.PI));
        }
    }
}
