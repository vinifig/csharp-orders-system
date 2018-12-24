using System;
using Xunit;
using ACM.Business;
using System.ComponentModel.DataAnnotations;
using ACM.Business.Repository;
using System.Threading.Tasks;
using ACM.Business.Validation;

namespace ACM.BusinessTest.RepositoryTest
{
    /// <summary>
    /// ACM.Business.Customer Test Class
    /// </summary>
    public class OrderRepositoryTest
    {

        /// <summary>
        /// Verifies if a order repository,
        /// without any of injected repositories, 
        /// throws an repository unavailable exception
        /// </summary>
        /// <param name="withoutCustomerRepository"></param>
        /// <param name="withoutAddressRepository"></param>
        /// <returns></returns>
        [Theory]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(true, true)]
        public async Task Retrieve_WithoutARepository_ThrowsUnavailableRepositoryException(bool withoutCustomerRepository, bool withoutAddressRepository)
        {
            // Arrange
            ICustomerRepository customerRepository = withoutCustomerRepository ? null : new CustomerRepository();
            IAddressRepository addressRepository = withoutAddressRepository ? null : new AddressRepository();
            IOrderRepository orderRepository = new OrderRepository(addressRepository, customerRepository);

            // Act

            // Assert
            await Assert.ThrowsAsync<UnavailableRepositoryException>(() => orderRepository.Retrieve(1));

        }

    }
}
