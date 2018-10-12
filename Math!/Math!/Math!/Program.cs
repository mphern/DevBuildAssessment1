using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_
{
    class Program
    {
        static void Main()
        {
            Console.Write("Please provide a number: ");
            var number = double.Parse(Console.ReadLine());
            for(int x = 0; x < 13; x++)
            {
                Console.WriteLine(number+ " x " + x + " = " + (number*x));
            }
        }
    }
}
