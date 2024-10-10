using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szamrendszer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sz = 0;
            Console.WriteLine("10-es számrendzserből 2-es számrendszerbe váltás.");
            Console.WriteLine("Addjon meg egy számott.");
            sz = Convert.ToInt32(Console.ReadLine());
            if (sz % 2 == 0) Console.WriteLine("0");
            else Console.WriteLine("1");
            while (sz > 1)
            {
                sz /= 2;
                if (sz %2 == 0) Console.WriteLine("0");
                else Console.WriteLine("1");
            }

        }

    }
}

