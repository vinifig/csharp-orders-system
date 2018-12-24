using System;
using Xunit;
using ACM.Business;
using System.ComponentModel.DataAnnotations;
using ACM.Business.Repository;
using System.Threading.Tasks;

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
            ICustomerRepository customerRepository = new CustomerRepository();
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


    }
}
