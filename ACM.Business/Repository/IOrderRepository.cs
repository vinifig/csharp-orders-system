using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.Business.Repository
{
    /// <summary>
    /// Generic Order Repository Interface
    /// Should be used for Repository Mocking
    /// </summary>
    public interface IOrderRepository: IRepository<Order>
    {
    }
}
