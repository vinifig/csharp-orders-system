using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ACM.Business;

namespace ACM.Business.Repository
{
    /// <summary>
    /// Order Data Manager
    /// </summary>
    public class OrderRepository: IOrderRepository
    {

        #region Interfaces

        #region IRetrievable

        /// <summary>
        /// Method to Retrieve a Order's entity
        /// </summary>
        public async Task<Order> Retrieve(long entityId)
        {
            Order order = new Order();
            return await Task.FromResult(order);
        }

        /// <summary>
        /// Method to Retrieve all Order's entities
        /// </summary>
        public async Task<IEnumerable<Order>> Retrieve()
        {
            // Mocking Data - in the future implements the query here
            IEnumerable<Order> orders = new List<Order>()
            {
                await Retrieve(1)
            };
            return orders;
        }

        #endregion

        #region ISavable

        /// <summary>
        /// Order's Entity Save Method
        /// </summary>
        /// <returns></returns>
        public async Task<Order> Save(Order order)
        {
            return await Task.FromResult(order);
        }

        #endregion

        #endregion

    }
}
