using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration;
using System.Collections.Generic;

namespace MSTest
{
    [TestClass]
    public class UnitTest1
    {
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

        [TestMethod]
        public void GivenFirstName_WhenValidated_ThenReturnsTrue()
        {
            //AAA
            //Arrange
            string firstName = "Prashik";
            //Act
            bool result = Program.UserName(firstName);
            //Assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void GivenLastName_WhenValidated_ThenReturnsTrue()
        {
            //AAA
            //Arrange
            string lastName = "Jaware";
            //Act
            bool result = Program.LastName(lastName);
            //Assert
            Assert.AreEqual(true, result);

        }

        [TestMethod]
        public void GivenEmail_WhenValidated_ThenReturnsTrue()
        {
            //AAA
            //Arrange
            string email = "abc+123-xyz987.pqr@gmail456.com.in";
            //Act
            bool result = Program.Email(email);
            //Assert
            Assert.AreEqual(true, result);

        }

        [TestMethod]
        public void GivenMultipleEmail_WhenValidated_ThenReturnsTrue()
        {
            //AAA
            //Arrange
            //Act
            foreach (var item in list1)
            {
                //Act
                bool result = Program.Email(item);
                //Assert
                Assert.AreEqual(true, result);
            }

        }

        [TestMethod]
        public void GivenMobileNumber_WhenValidated_ThenReturnsTrue()
        {
            //AAA
            //Arrange
            string mobileNumber = "91 8426103579";
            //Act
            bool result = Program.MobileNumber(mobileNumber);
            //Assert
            Assert.AreEqual(true, result);

        }

        [TestMethod]
        public void GivenPasswordRule4_WhenValidated_ThenReturnsTrue()
        {
            //AAA
            //Arrange
            string password = "I@mTheEmperor0OfAllLivingBeings";
            //Act
            bool result = Program.Password(password);
            //Assert
            Assert.AreEqual(true, result);

        }

    }
}
