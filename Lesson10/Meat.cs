using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10
{
    partial class Meat
    {
        //public static int Qyabab(int x)
        //{
        //    int y = 800 * x;
        //    Console.WriteLine("qyababi arjeqy = " + y);
        //    return y;
        //}
        public static int Shaurma(int x)
        {
            int y = 1000 * x;
            Console.WriteLine("shaurmi arjeqy = " + y);
            return y;
        }
        public Meat(int x)
        {
            Shaurma(x);
            Qyabab(x);
                
        }
        //public Meat()
        //{

        //}
        //public Meat(int x)
        //{
        //    Qyabab(x);
        //    Shaurma(x);

        //}
        //public Meat(int x,int y)
        //{
        //    Qyabab(y);
        //    Shaurma(x);

        //}
    }
    
}
