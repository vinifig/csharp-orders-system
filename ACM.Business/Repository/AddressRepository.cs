using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ACM.Business.Repository
{
    /// <summary>
    /// Generic Address Repository Interface
    /// Should be used for Repository Mocking
    /// </summary>
    /// <summary>
    /// Address Data Manager
    /// </summary>
    public class AddressRepository : IAddressRepository
    {

        #region Interfaces

        #region IAddressRepository

        #region IRetrievable

        /// <summary>
        /// Method to Retrieve a Address's entity
        /// </summary>
        public async Task<Address> Retrieve(long addressId)
        {
            // Mocking Data - in the future implements the query here
            Address Address = new Address(addressId)
            {
                Street = $"Avenida nações unidas",
                Country = "BR",
                State = "SP"
            };
            return await Task.FromResult(Address);
        }

        /// <summary>
        /// Method to Retrieve all Address's entities
        /// </summary>
        public async Task<IEnumerable<Address>> Retrieve()
        {
            // Mocking Data - in the future implements the query here
            // Add Tasks into a list - Performance issues
            IList<Task<Address>> operationsList = new List<Task<Address>>();
            operationsList.Add(Retrieve(1));
            operationsList.Add(Retrieve(2));
            
            IEnumerable<Address> addresses = await Task.WhenAll(operationsList);
            return addresses;
        }

        #endregion

        #region ISavable

        /// <summary>
        /// Address's Entity Save Method
        /// </summary>
        /// <returns></returns>
        public async Task<Address> Save(Address address)
        {
            return await Task.FromResult(address);
        }

        #endregion

        /// <summary>
        /// Retrieves all customer's addresses
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Address>> RetrieveByCustomerId(long customerId)
                => await Retrieve();

        #endregion

        #endregion

    }
}
