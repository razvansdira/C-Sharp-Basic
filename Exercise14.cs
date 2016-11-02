using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Basic
{
    class Exercise14
    {
        static void Main(string[] args)
        {
            int c;

            Console.WriteLine("Enter the amount of celsius: ");
            c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kelvin = {0}", c+273);
            Console.WriteLine("Fahrenheit = {0}", c*18/10+32);

            Console.ReadKey();
        }
    }
}
