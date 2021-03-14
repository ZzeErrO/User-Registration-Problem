using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration;

namespace MSTest
{
    [TestClass]
    public class UnitTest1
    {
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
            string email = "abc123@gmail.com";
            //Act
            bool result = Program.Email(email);
            //Assert
            Assert.AreEqual(true, result);

        }

        [TestMethod]
        public void GivenMobileNumber_WhenValidated_ThenReturnsTrue()
        {
            //AAA
            //Arrange
            string mobileNumber = "91 8524561397";
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
