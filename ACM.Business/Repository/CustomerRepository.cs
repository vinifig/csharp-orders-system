using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ACM.Business;

namespace ACM.Business.Repository
{
    /// <summary>
    /// Customer Data Manager
    /// </summary>
    public class CustomerRepository: ICustomerRepository
    {

        #region Interfaces

        #region IRetrievable

        /// <summary>
        /// Method to Retrieve a customer's entity
        /// </summary>
        public async Task<Customer> Retrieve(long entityId)
        {
            // Mocking Data - in the future implements the query here
            Customer customer = new Customer();
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

    }
}
