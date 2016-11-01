using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Basic
{
    class Exercise7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the first number: ");
            int nr1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the second number: ");
            int nr2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Operations: ");

            Console.WriteLine("{0} + {1} = {2}", nr1, nr2, nr1 + nr2);
            Console.WriteLine("{0} - {1} = {2}", nr1, nr2, nr1 - nr2);
            Console.WriteLine("{0} x {1} = {2}", nr1, nr2, nr1 * nr2);
            Console.WriteLine("{0} / {1} = {2}", nr1, nr2, nr1 / nr2);
            Console.WriteLine("{0} mod {1} = {2}", nr1, nr2, nr1 % nr2);
            Console.ReadKey();
        }
    }
}
