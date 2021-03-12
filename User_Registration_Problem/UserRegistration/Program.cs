using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Program
    {
        public static string userName;
        public static string lastName;

        public static bool UserName(string userName) 
        {
            return Regex.IsMatch(userName, @"^[A-Z]{1}[a-z0-9A-Z]{2,}$");
        }

        public static bool LastName(string lastName)
        {
            return Regex.IsMatch(lastName, @"^[A-Z]{1}[a-z0-9A-Z]{2,}$");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Valid User Name: ");
            userName = Console.ReadLine();
            Console.WriteLine(UserName(userName)+"\n");

            Console.WriteLine("Enter a Valid Last Name: ");
            lastName = Console.ReadLine();
            Console.WriteLine(UserName(lastName)+"\n");

            Console.ReadKey();
        }
    }
}
