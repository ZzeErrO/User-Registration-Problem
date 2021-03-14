using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class Program
    {
        public static string userName;
        public static string lastName;
        public static string email;
        public static string mobileNumber;
        public static string password;
        public static bool UserName(string userName) 
        {
            return Regex.IsMatch(userName, @"^[A-Z]{1}[a-z0-9A-Z]{2,}$");
        }

        public static bool LastName(string lastName)
        {
            return Regex.IsMatch(lastName, @"^[A-Z]{1}[a-z0-9A-Z]{2,}$");
        }

        public static bool Email(string email)
        {
            return Regex.IsMatch(email, @"^[A-Z0-9a-z]+[@][A-Z0-9a-z]+[.][A-Za-z]{2,3}$");
        }

        public static bool MobileNumber(string mobileNumber)
        {
            return Regex.IsMatch(mobileNumber, @"^[0-9]{2}[ ][0-9]{10}$");
        }
        
        public static bool Password(string password)
        {
            return Regex.IsMatch(password, @"^(?=.*[A-Z])(?=.*[0-9])[A-Za-z0-9.#+*/$@!%^&_-]{8,}$");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Valid First Name: ");
            userName = Console.ReadLine();
            Console.WriteLine(UserName(userName) + "\n");

            Console.WriteLine("Enter a Valid Last Name: ");
            lastName = Console.ReadLine();
            Console.WriteLine(LastName(lastName) + "\n");

            Console.WriteLine("Enter a Valid Email: ");
            email = Console.ReadLine();
            Console.WriteLine(Email(email) + "\n");

            Console.WriteLine("Enter a Valid Mobile Number: ");
            mobileNumber = Console.ReadLine();
            Console.WriteLine(MobileNumber(mobileNumber) + "\n");

            Console.WriteLine("Enter a Valid Password: ");
            password = Console.ReadLine();
            Console.WriteLine(Password(password) + "\n");

            Console.ReadKey();
        }
    }
}
