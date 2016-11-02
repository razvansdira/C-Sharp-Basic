using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Basic
{
    class Exercise13
    {
        static void Main (String[] args)
        {
            int nr;

            Console.WriteLine("Enter a number: ");
            nr = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Display:");
            Console.WriteLine("{0}{0}{0}\n", nr);
            Console.WriteLine("{0} {0}\n", nr);
            Console.WriteLine("{0} {0}\n", nr);
            Console.WriteLine("{0} {0}\n", nr);
            Console.WriteLine("{0}{0}{0}", nr);

            Console.ReadKey();
        }
    }
}
