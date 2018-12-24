using System;
using System.Collections.Generic;
using System.Text;
using ACM.Business;

namespace ACM.Business.Repository
{
    /// <summary>
    /// Product Data Manager
    /// </summary>
    public class ProductRepository: IRepository<Product>
    {

        #region Interfaces

        #region IRetrievable

        /// <summary>
        /// Method to Retrieve a Product's entity
        /// </summary>
        public Product Retrieve(long entityId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Method to Retrieve all Product's entities
        /// </summary>
        public IEnumerable<Product> Retrieve()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region ISavable

        /// <summary>
        /// Product's Entity Save Method
        /// </summary>
        /// <returns></returns>
        public Product Save()
        {
            throw new NotImplementedException();
        }

        #endregion

        #endregion

    }
}
