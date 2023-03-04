using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Restaurant
    {
        public int t;
        public const string Address = "Abovyan-1";
        public const string Number = "+37496666666";

       
            
        

        public decimal MakeFood(Menu menu, int count)
        {
            switch (menu)
            {
                case Menu.HotDog:
                    {
                        return (decimal)Menu.HotDog * (count + t);
                    }
                case Menu.Sushi:
                    {
                        return (decimal)Menu.Sushi * (count + t);
                    }
                case Menu.Pizza:
                    {
                        return (Decimal)Menu.Sushi * (count + t);
                    }
                case Menu.Shawrma:
                    {
                        return (decimal)Menu.Shawrma * (count + t);
                    }
                case Menu.Xash:
                    {
                        return (decimal)Menu.Xash * (count + t);
                    }
                default:
                    {
                        return 0;
                    }
            }
        }
        public Restaurant()
        {

        }
        public Restaurant(int u)
        {
            t = u;
        }

    }
    public enum Menu
    {
        HotDog = 300,
        Sushi = 5000,
        Pizza = 2000,
        Shawrma = 1000,
        Xash = 6000
    }
}
