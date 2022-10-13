namespace n5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            double x, y;
            Console.Write("а= ");
            a = int.Parse(Console.ReadLine());

            Console.Write("b= ");
            b = int.Parse(Console.ReadLine());

            Console.Write("с= ");
            c = int.Parse(Console.ReadLine());

            x = Math.PI;
            y = Math.E;

            Console.Write($"a*P: {a}*3,1416={{0:0.0000}}\t", a * x);
            Console.Write($"b*E: {b}*2,718={{0:0.000}}\t", b * y);
            Console.Write($"с*PI*E: {c}*3,14*2,72={{0:0.00}}\t", c*x*y);
        }
    }
}