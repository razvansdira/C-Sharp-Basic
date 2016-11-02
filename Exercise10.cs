using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Basic
{
    class Exercise10
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;

            Console.WriteLine("Enter fisrt number: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter third number: ");
            n3 = Convert.ToInt32(Console.ReadLine());

            int rez1 = (n1 + n2) * n3;
            int rez2 = n1 * n2 + n1 * n3;

            Console.WriteLine("Result of specified numbers {0}, {1} and {2}, for (x+y)*z is {3} and for x*y + y*z is {4}.", n1, n2, n3, rez1, rez2);
            Console.ReadKey();
        }
    }
}
