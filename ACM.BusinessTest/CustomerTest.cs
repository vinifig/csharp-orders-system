using System;
using Xunit;
using ACM.Business;
using System.ComponentModel.DataAnnotations;

namespace ACM.BusinessTest
{
    /// <summary>
    /// ACM.Business.Customer Test Class
    /// </summary>
    public class CustomerTest
    {
        /// <summary>
        /// Verifies if Customer FullName is Valid
        /// </summary>
        [Fact]
        public void FullName_Value_IsValid()
        {
            // Arrange
            Customer customer = new Customer("John", "Doe", "john@doe.com");
            string expected = "Doe, John";

            // Act
            string actual = customer.FullName;

            // Assert
            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Verifies if full name will correctly change when updates first name
        /// </summary>
        /// <param name="firstName">Initial First Name</param>
        /// <param name="lastName">Last Name</param>
        /// <param name="newFirstName">New Last Name</param>
        [Theory]
        [InlineData("John", "Doe", "Mary")]
        [InlineData("John", "Doe", "MaryDota")]
        public void FirstName_Change_UpdatesValidFullName(string firstName, string lastName, string newFirstName)
        {
            // Arrange
            Customer customer = new Customer(1)
            {
                FirstName = firstName,
                LastName = lastName,
                EmailAddress = "john@doe.com"
            };

            // Act
            customer.FirstName = newFirstName;
            string expected = $"{customer.LastName}, {customer.FirstName}";

            // Assert
            string actual = customer.FullName;
            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Verifies if full name will correctly change when updates first name
        /// </summary>
        /// <param name="firstName">Customer's First Name</param>
        /// <param name="lastName">Customer's Last Name</param>
        /// <param name="email">Customer's Email</param>
        [Theory]
        [InlineData("John", "Doe", null)]
        [InlineData("John", "Doe", "john.doe")]
        public void Validate_InvalidData_GeneratesExceptions(string firstName, string lastName, string email)
        {
            // Arrange
            Customer customer = new Customer(firstName, lastName, email);

            // Act

            // Assert
            Assert.Throws<ValidationException>(() => customer.Validate());
        }

        /// <summary>
        /// Verifies if Customer Validation throws ValidationException when sets a invalid email 
        /// </summary>
        [Fact]
        public void Validate_InvalidEmail_ThrowValidationException()
        {
            // Arrange
            Customer customer = new Customer("John", "Doe", "johndoe.com");

            // Act

            // Assert
            Assert.Throws<ValidationException>(() => customer.Validate());
        }

        /// <summary>
        /// Verifies if Customer Validate method is implemented
        /// </summary>
        [Fact]
        public void Customer_ValidateMethod_IsImplemented()
        {
            // Arrange
            Customer customer = new Customer("John", "Doe", "john@doe.com");
            Type expected = typeof(NotImplementedException);

            // Act
            Exception e = Record.Exception(() => customer.Validate());
            Type actual = e?.GetType();

            // Assert
            Assert.NotEqual(expected, actual);
        }

    }
}
