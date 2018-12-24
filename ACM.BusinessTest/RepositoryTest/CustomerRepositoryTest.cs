using System;
using Xunit;
using ACM.Business;
using System.ComponentModel.DataAnnotations;
using ACM.Business.Repository;
using System.Threading.Tasks;
using ACM.Business.Errors;

namespace ACM.BusinessTest.RepositoryTest
{
    /// <summary>
    /// ACM.Business.Customer Test Class
    /// </summary>
    public class CustomerRepositoryTest
    {
        /// <summary>
        /// Verifies if Customer FullName is Valid
        /// </summary>
        [Fact]
        public async Task Retrieve_Mocked_CorrectValue()
        {
            // Arrange
            ICustomerRepository customerRepository = new CustomerRepository(new AddressRepository());
            Customer expected = new Customer(1)
            {
                FirstName = "John",
                LastName = "Doe",
                EmailAddress = "mocked@email.com"
            };

            // Act
            Customer actual = await customerRepository.Retrieve(1);

            // Assert
            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Verifies if Customer FullName is Valid
        /// </summary>
        [Fact]
        public async Task Retrieve_Mocked_ReturnAtLeastOneAddress()
        {
            // Arrange
            ICustomerRepository customerRepository = new CustomerRepository(new AddressRepository());
            Customer customer = await customerRepository.Retrieve(1);
            int expected = 1;
            int actual = customer.AddressList.Count;

            // Act

            // Assert
            Assert.True(actual > expected, $"CustomerRepository address list length ({actual}) was not greater than expected ({expected})");
        }

        /// <summary>
        /// Verifies if a customer repository,
        /// without a address repository, 
        /// throws an repository unavailable exception
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task RetrieveCustomerAddress_WithoutAddressRepository_ThrowsUnavailableRepositoryException()
        {
            // Arrange
            ICustomerRepository customerRepository = new CustomerRepository();

            // Act

            // Assert
            await Assert.ThrowsAsync<UnavailableRepositoryException>(() => customerRepository.RetrieveCustomerAddresses(1));

        }

        /// <summary>
        /// Verifies if a customer repository,
        /// with a address repository, 
        /// dont throws an repository unavailable exception
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task RetrieveCustomerAddress_WithAddressRepository_DontThrowsUnavailableRepositoryException()
        {
            // Arrange
            ICustomerRepository customerRepository = new CustomerRepository(new AddressRepository());
            Type expected = typeof(UnavailableRepositoryException);

            // Act
            Exception e = await Record.ExceptionAsync(() => customerRepository.RetrieveCustomerAddresses(1));
            Type actual = e?.GetType();

            // Assert
            Assert.NotEqual(expected, actual);

        }


    }
}
