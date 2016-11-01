using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Basic
{
    class Exercise5
    {
        static void Main(string[] args)
        {
            int nr1;
            int nr2;
            int cos;
            Console.WriteLine("Input the First Number: ");
            nr1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the Second Number: ");
            nr2 = int.Parse(Console.ReadLine());
            cos = nr1;
            nr1 = nr2;
            nr2 = cos;
            Console.WriteLine("After Swapping: ");
            Console.WriteLine("First Number: " + nr1);
            Console.WriteLine("Second Number: " + nr2);
            Console.ReadKey();
        }
    }
}
