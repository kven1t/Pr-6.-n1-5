namespace Pr_6._n1_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.Write("а= ");
            a = double.Parse(Console.ReadLine());

            Console.Write("b= ");
            b = double.Parse(Console.ReadLine());

            c = a / b;

            Console.WriteLine($"{a}/{b} = {{0:0.000}}", c);
        }
    }
}