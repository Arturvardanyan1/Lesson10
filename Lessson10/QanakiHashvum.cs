using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lessson10
{
    internal class QanakiHashvum
    {
        public int qanak(char t,ref string s )
        {
            int k=0;
            for (int i = 0; i < s.Length; i++)
            {
                if (t == s[i])
                {
                    k++;
                }
            }
            return k;   
        }
    }
}
