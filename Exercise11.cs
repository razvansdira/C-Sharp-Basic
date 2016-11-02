using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Basic
{
    class Exercise11
    {
        static void Main(string[] args)
        {
            int age;

            Console.WriteLine("Enter your age:");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("You look older than {0}, sorry!", age);
            Console.ReadKey();
        }
    }
}
