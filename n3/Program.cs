namespace n3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, y, c;
            Console.Write("x= ");
            x = double.Parse(Console.ReadLine());

            Console.Write("y= ");
            y = double.Parse(Console.ReadLine());

            c = x*3 / y;

            Console.WriteLine($"{x*3}/{y} = {{0:0.0000}}", c);
        }
    }
}