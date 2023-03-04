using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Res
{
    internal class Restoran
    {
        public int MakeSushi(ref int x)
        {
            int y = 5000;
            return x * y;
        }
        public int MakeHotDog(ref int x)
        {
            int y = 400;
            return y * x;
        }
        public int Makeburger(ref int x)
        {
            int y = 1000;
            return y * x;
        }

        public Restoran()
        {

        }
        public Restoran(ref int x, out int d)
        {
            int a = Makeburger(ref x);
            int b = MakeSushi(ref x);
            int c = MakeHotDog(ref x);
            d = a + b + c;
        }
    }
}
