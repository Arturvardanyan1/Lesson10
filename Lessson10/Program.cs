using Lessson10;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using System.Xml.Linq;

namespace Lessson101
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int x = 0;
            string name = Console.ReadLine();

            Human human = new Human();
            human.Validation(name, ref x);
            if (x != 1)
            {
                Console.WriteLine(ErrorTypes.OK);
            }
            else
            {
                Console.WriteLine(ErrorTypes.SurNamenotValid);
            }

            char t = char.Parse(Console.ReadLine());
           QanakiHashvum qanakiHashvum = new QanakiHashvum();
           int k= qanakiHashvum.qanak(t, ref name);
            Console.WriteLine(k);

        }

    }
}