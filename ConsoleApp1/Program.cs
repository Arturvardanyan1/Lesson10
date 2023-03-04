namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Restaurant restaurant;
            Restaurant restaurant1 = new Restaurant();
            Console.WriteLine(restaurant1.MakeFood(Menu.Pizza, 6));
            Console.WriteLine(restaurant1.t);
            Restaurant restaurant2 = new Restaurant(66);
            Console.WriteLine(restaurant2.MakeFood(Menu.Pizza,5));
            Console.WriteLine(restaurant2.t); 
            
        }
    }
}