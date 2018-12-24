using System;
using System.Collections.Generic;
using System.Text;
using ACM.Business;

namespace ACM.Business.Repository
{
    /// <summary>
    /// Customer Data Manager
    /// </summary>
    public class CustomerRepository: IRepository<Customer>
    {

        #region Interfaces

        #region IRetrievable

        /// <summary>
        /// Method to Retrieve a customer's entity
        /// </summary>
        public Customer Retrieve(long entityId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Method to Retrieve all customer's entities
        /// </summary>
        public IEnumerable<Customer> Retrieve()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region ISavable

        /// <summary>
        /// Customer's Entity Save Method
        /// </summary>
        /// <returns></returns>
        public Customer Save()
        {
            throw new NotImplementedException();
        }

        #endregion

        #endregion

    }
}
