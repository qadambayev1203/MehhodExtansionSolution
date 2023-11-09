using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MehhodExtansion
{
    class Program
    {
        static void Main(string[] args)
        {
            Mathh summ = new Mathh();
            Console.WriteLine(summ.Summ(15, 12));
            Console.WriteLine(summ.Ayiruv(15, 12));
            Console.ReadKey();
        }
    }
}
