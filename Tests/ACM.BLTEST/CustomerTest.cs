using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTEST
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameValidate()
        {
            //--Arrange
            // object initilizer
            Customer customer = new Customer()
            {
                FirstName = "Rami",
                LastName = "Saeed"
            };

            String expected_value = "Rami, Saeed";


            //--Act
            String realValue = customer.FullName;


            //--Assert
            Assert.AreEqual(expected_value, realValue);

        }
        [TestMethod]
        public void FirstNameEmpty()
        {
            //--Arrange
            // object initilizer
            Customer customer = new Customer()
            {
               
                LastName = "Saeed"
            };

            String expected_value = "Saeed";


            //--Act
            String realValue = customer.FullName;


            //--Assert
            Assert.AreEqual(expected_value, realValue);

        }
        [TestMethod]
        public void LastNameEmpty()
        {
            //--Arrange
            // object initilizer
            Customer customer = new Customer()
            {

                FirstName = "Rami"
            };

            String expected_value = "Rami";


            //--Act
            String realValue = customer.FullName;


            //--Assert
            Assert.AreEqual(expected_value, realValue);

        }

    }
}
