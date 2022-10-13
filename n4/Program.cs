namespace n4
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

            Console.Write($"a/PI={a}/3,1416={{0:0.0000}}\t", a/x);
            Console.Write($"a+b+c={a}+{b}+{c}={a+b+c}\t");
            Console.Write($"с/E={c}/2,718={{0:0.000}}\t", c / y);
        }
    }
}