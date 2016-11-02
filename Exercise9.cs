using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Basic
{
    class Exercise9
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4;

            Console.WriteLine("Enter the first number: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the third number: ");
            n3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the four number: ");
            n4 = Convert.ToInt32(Console.ReadLine());

            int avg = (n1 + n2 + n3 + n4) / 4;

            Console.WriteLine("The average of {0} , {1} , {2} , {3} is {4}.", n1, n2, n3, n4, avg);
            
            Console.ReadKey();
        }
    }
}
