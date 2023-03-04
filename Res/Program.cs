namespace Res
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            Restoran restoran = new Restoran();
            Console.WriteLine(restoran.Makeburger(ref x));
            Console.WriteLine(restoran.MakeHotDog(ref x));
            Console.WriteLine(restoran.MakeSushi(ref x));
            Restoran restoran1 = new Restoran(ref x,out int a);
            Console.WriteLine(a);
            
           
        }
    }
}   