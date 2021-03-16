﻿using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace UserRegistration
{
    public class Program
    {
        public static string userName;
        public static string lastName;
        public static string email;
        public static string mobileNumber;
        public static string password;

        private static List<string> list1 = new List<string>()
        {
            "abc@yahoo.com",
            "abc-100@yahoo.com",
            "abc.100@yahoo.com",
            "abc111@abc.com",
            "abc-100@abc.net",
            "abc.100@abc.com.au",
            "abc@1.com",
            "abc@gmail.com.com",
            "abc+100@gmail.com"
        };

        public static bool UserName(string userName) 
        {
            try
            {
                if (Regex.IsMatch(userName, @"^[A-Z]{1}[a-z0-9A-Z]{2,}$"))
                    return true;
                else
                    throw new UserRegistrationException(UserRegistrationException.ExceptionTypes.INVALID_FIRST_NAME, "Wrong First Name Entered");
            }
            catch (UserRegistrationException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public static bool LastName(string lastName)
        {
            try 
            {
                if (Regex.IsMatch(lastName, @"^[A-Z]{1}[a-z0-9A-Z]{2,}$"))
                    return true;
                else
                    throw new UserRegistrationException(UserRegistrationException.ExceptionTypes.INVALID_LAST_NAME, "Wrong Last Name Entered");
            }
            catch (UserRegistrationException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public static bool Email(string email)
        {
            try
            {
                if (Regex.IsMatch(email, @"^[A-Z0-9a-z]+([.#_+-][A-Z0-9a-z]+)*[@][A-Z0-9a-z]+([.][A-Za-z]{2,3}){1,2}$"))
                    return true;
                else
                    throw new UserRegistrationException(UserRegistrationException.ExceptionTypes.INVALID_EMAIL, "Wrong Email Entered");
            }
            catch (UserRegistrationException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public static bool MobileNumber(string mobileNumber)
        {
            try
            {
                if (Regex.IsMatch(mobileNumber, @"^[0-9]{2}[ ][0-9]{10}$"))
                    return true;
                else
                    throw new UserRegistrationException(UserRegistrationException.ExceptionTypes.INVALID_PHONE_NUMBER, "Wrong Phone Number Entered");
            }
            catch (UserRegistrationException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public static bool Password(string password)
        {
            try
            {
                if (Regex.IsMatch(password, @"^(?=.*[A-Z])(?=.*[0-9])(?=[^.#+*/$@!%^&_-]*[.#+*/$@!%^&_-][^.#+*/$@!%^&_-]*$)[A-Za-z0-9.#+*/$@!%^&_-]{8,}$"))
                    return true;
                else
                    throw new UserRegistrationException(UserRegistrationException.ExceptionTypes.INVALID_PASSWORD, "Wrong Password Entered");
            }
            catch (UserRegistrationException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
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
            Console.WriteLine("Email checking Examples test: \n");

            foreach (var item in list1)
            {
                Console.WriteLine(Email(item));
            }
   
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
