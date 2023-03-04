using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lessson10
{
    enum ErrorTypes
    {
        OK,
        SurNamenotValid
        
    }
    public class Human
    {
        public int Validation(string str, ref int x)
        {

            for (int i = 0; i < str.Length; i++)
            {
                if (!char.IsLetter(str[i]))
                {
                    return x = 1;
                    break;
                }
            }

            return x;

        }

    }
}
