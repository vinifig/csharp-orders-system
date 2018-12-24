using System;
using System.Collections.Generic;
using System.Text;
using ACM.Business;

namespace ACM.Business.Repository
{
    /// <summary>
    /// Order Data Manager
    /// </summary>
    public class OrderRepository: IRepository<Order>
    {

        #region Interfaces

        #region IRetrievable

        /// <summary>
        /// Method to Retrieve a Order's entity
        /// </summary>
        public Order Retrieve(long entityId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Method to Retrieve all Order's entities
        /// </summary>
        public IEnumerable<Order> Retrieve()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region ISavable

        /// <summary>
        /// Order's Entity Save Method
        /// </summary>
        /// <returns></returns>
        public Order Save()
        {
            throw new NotImplementedException();
        }

        #endregion

        #endregion

    }
}
