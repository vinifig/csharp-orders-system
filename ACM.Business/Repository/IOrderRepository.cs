using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ACM.Business.Repository
{
    /// <summary>
    /// Generic Order Repository Interface
    /// Should be used for Repository Mocking
    /// </summary>
    public interface IOrderRepository: IRepository<Order>
    {

        /// <summary>
        /// Retrieve order shipping address
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        Task<Address> RetrieveOrderAddress(long orderId);

        /// <summary>
        /// Method to retrieve the order's customer 
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        Task<Customer> RetrieveOrderCustomer(long orderId);
    }
}
