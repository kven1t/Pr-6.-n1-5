namespace n2
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

            c = b / a;

            Console.WriteLine($"{b}/{a} = {{0:0.00}}", c);
        }
    }
}