using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ACM.Business.Repository
{
    /// <summary>
    /// Generic Customer Repository Interface
    /// Should be used for Repository Mocking
    /// </summary>
    public interface ICustomerRepository: IRepository<Customer>
    {
        /// <summary>
        /// Retrieve customer addresses list
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        Task<IList<Address>> RetrieveCustomerAddresses(long customerId);

        /// <summary>
        /// Method to Retrieve a customer's entity
        /// </summary>
        Task<Customer> RetrieveWithAddresses(long customerId);

        /// <summary>
        /// Method to retrieve the order's customer 
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        Task<Customer> RetrieveCustomerByOrderId(long orderId);
    }
}
