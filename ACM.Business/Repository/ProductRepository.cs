using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ACM.Business;

namespace ACM.Business.Repository
{
    /// <summary>
    /// Product Data Manager
    /// </summary>
    public class ProductRepository: IProductRepository
    {

        #region Interfaces

        #region IRetrievable

        /// <summary>
        /// Method to Retrieve a Order's entity
        /// </summary>
        public async Task<Product> Retrieve(long entityId)
        {
            Product product = new Product();
            return await Task.FromResult(product);
        }

        /// <summary>
        /// Method to Retrieve all Order's entities
        /// </summary>
        public async Task<IEnumerable<Product>> Retrieve()
        {
            // Mocking Data - in the future implements the query here
            IEnumerable<Product> products = new List<Product>()
            {
                await Retrieve(1)
            };
            return products;
        }

        #endregion

        #region ISavable

        /// <summary>
        /// Order's Entity Save Method
        /// </summary>
        /// <returns></returns>
        public async Task<Product> Save(Product product)
        {
            return await Task.FromResult(product);
        }

        #endregion

        #endregion
    }
}
