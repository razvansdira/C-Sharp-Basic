using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Basic
{
    class Exercise8
    {
        static void Main(string[] args)
        {
            int n, nr; 

            Console.WriteLine("Enter the number:");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Multiplication:");

            nr = 1 * n;
            Console.WriteLine("{0} * {1} = {2}", n, 1, nr);

            nr = 2 * n;
            Console.WriteLine("{0} * {1} = {2}", n, 2, nr);

            nr = 3 * n;
            Console.WriteLine("{0} * {1} = {2}", n, 3, nr);

            nr = 4 * n;
            Console.WriteLine("{0} * {1} = {2}", n, 4, nr);

            nr = 5 * n;
            Console.WriteLine("{0} * {1} = {2}", n, 5, nr);

            nr = 6 * n;
            Console.WriteLine("{0} * {1} = {2}", n, 6, nr);

            nr = 7 * n;
            Console.WriteLine("{0} * {1} = {2}", n, 7, nr);

            nr = 8 * n;
            Console.WriteLine("{0} * {1} = {2}", n, 8, nr);

            nr = 9 * n;
            Console.WriteLine("{0} * {1} = {2}", n, 9, nr);

            nr = 10 * n;
            Console.WriteLine("{0} * {1} = {2}", n, 10, nr);
            Console.ReadKey();
        }
    }
}
