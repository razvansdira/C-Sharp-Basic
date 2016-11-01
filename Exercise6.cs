using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Basic
{
    class Exercise6
    {
        static void Main(string[] args)
        {
            int nr1, nr2, nr3;

            Console.WriteLine("Input the first number to multiply: ");
            nr1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Input the second number to multiply: ");
            nr2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Input the third number to multiply: ");
            nr3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Output:");
            Console.WriteLine(nr1 * nr2 * nr3);
            Console.ReadKey();
        }
    }
}
