using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.Business.Repository
{
    /// <summary>
    /// Generic Customer Repository Interface
    /// Should be used for Repository Mocking
    /// </summary>
    public interface ICustomerRepository: IRepository<Customer>
    {
    }
}
