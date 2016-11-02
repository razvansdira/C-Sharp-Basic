using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Basic
{
    class Exercise12
    {
        static void Main (string[] args)
        {
            int nr;

            Console.WriteLine("Enter a digit: ");
            nr = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Display:");

            Console.Write( nr );
            Console.Write(" ");
            Console.Write(nr);
            Console.Write(" ");
            Console.Write(nr);
            Console.Write(" ");
            Console.Write(nr);
            Console.Write(" ");
            Console.WriteLine();

            Console.Write(nr);
            Console.Write(nr);
            Console.Write(nr);
            Console.Write(nr);
            Console.WriteLine();

            Console.Write("{0} {0} {0} {0}\n", nr);
            Console.Write("{0}{0}{0}{0}", nr);

            Console.ReadKey();
        }
    }
}
