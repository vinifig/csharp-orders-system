using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACM.Business;
using ACM.Business.Errors;

namespace ACM.Business.Repository
{
    /// <summary>
    /// Customer Data Manager
    /// </summary>
    public class CustomerRepository: ICustomerRepository
    {

        #region CustomerRepository Constructor

        /// <summary>
        /// CustomerRepository Constructor
        /// </summary>
        /// <param name="addressRepository"></param>
        public CustomerRepository(IAddressRepository addressRepository = null)
        {
            _addressRepository = addressRepository;
        }

        #endregion

        #region Properties

        private readonly IAddressRepository _addressRepository = null;

        #endregion

        #region Interfaces

        #region ICustomerRepository

        /// <summary>
        /// Retrieve all addresses of a customer
        /// </summary>
        /// <returns></returns>
        public async Task<IList<Address>> RetrieveCustomerAddresses(long customerId)
        {
            if (_addressRepository == null)
            {
                throw new UnavailableRepositoryException(typeof(IAddressRepository));
            }
            IEnumerable<Address> addresses = await _addressRepository.RetrieveByCustomerId(customerId);
            return addresses.ToList();
        }

        #region IRetrievable





        /// <summary>
        /// Method to Retrieve a customer's entity
        /// </summary>
        public async Task<Customer> Retrieve(long customerId)
        {
            // Mocking Data - in the future implements the query here
            Customer customer = new Customer(customerId)
            {
                FirstName = "John",
                LastName = "Doe",
                EmailAddress = "mocked@email.com",
                AddressList = await RetrieveCustomerAddresses(customerId)
            };
            return await Task.FromResult(customer);
        }

        /// <summary>
        /// Method to Retrieve all customer's entities
        /// </summary>
        public async Task<IEnumerable<Customer>> Retrieve()
        {
            // Mocking Data - in the future implements the query here
            IEnumerable<Customer> customers = new List<Customer>()
            {
                await Retrieve(1)
            };
            return customers;
        }

        #endregion

        #region ISavable

        /// <summary>
        /// Customer's Entity Save Method
        /// </summary>
        /// <returns></returns>
        public async Task<Customer> Save(Customer customer)
        {
            return await Task.FromResult(customer);
        }

        #endregion

        #endregion

        #endregion

    }
}
