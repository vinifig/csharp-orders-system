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
    public interface IAddressRepository: IRepository<Address>
    {
        /// <summary>
        /// Retrieve customer addresses list
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        Task<IEnumerable<Address>> RetrieveByCustomerId(long customerId);
    }
}
