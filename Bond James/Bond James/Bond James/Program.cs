using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bond_James
{
    class Program
    {
        static void Main()
        {
            string firstName = GetFirstName();
            string lastName = GetLastName();
            Console.WriteLine(lastName + " " + firstName);
        }
        static string GetFirstName()
        {
            Console.WriteLine("What is your first name? ");
            string firstName = Console.ReadLine();
            return firstName;
        }
        static string GetLastName()
        {
            Console.WriteLine("What is your last name? ");
            string lastName = Console.ReadLine();
            return lastName;
        }
    }
}
