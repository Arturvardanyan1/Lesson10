namespace Reku
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            decimal? a = null;
            decimal? b = null;
            decimal? c = null;
            decimal? d = null;
            Console.WriteLine(dec(a, b, c, d));
            //  Console.WriteLine(Factorial(x));

            
        }
        public static int Factorial(int n)
        {
            if (n == 1) return 1;

            return n * Factorial(n - 1);
        }
        public static decimal? dec(decimal? a, decimal? b, decimal? c, decimal? d)
        {
            Console.WriteLine(a * b * c * d);
            return a * b * c * d;
        }
    }
}