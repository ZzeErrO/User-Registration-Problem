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

    }
}
