using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ACM.Business;
using ACM.Business.Validation;

namespace ACM.Business.Repository
{
    /// <summary>
    /// Order Data Manager
    /// </summary>
    public class OrderRepository: IOrderRepository
    {

        #region OrderRepository Constructor
        
        /// <summary>
        /// OrderRepository Constructor
        /// </summary>
        public OrderRepository()
        {

        }

        /// <summary>
        /// OrderRepository Constructor
        /// </summary>
        /// <param name="addressRepository"></param>
        /// <param name="customerRepository"></param>
        public OrderRepository(IAddressRepository addressRepository, ICustomerRepository customerRepository)
        {
            _addressRepository = addressRepository;
            _customerRepository = customerRepository;
        }

        #endregion

        #region Properties

        private readonly IAddressRepository _addressRepository = null;
        private readonly ICustomerRepository _customerRepository = null;

        #endregion

        #region Interfaces

        #region IOrderRepository

        /// <summary>
        /// Retrieve order shipping address
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public async Task<Address> RetrieveOrderAddress(long orderId) {
            if (_addressRepository == null)
            {
                throw new UnavailableRepositoryException(typeof(IAddressRepository));
            }
            return await _addressRepository.RetrieveByOrderId(orderId);
        }

        /// <summary>
        /// Method to retrieve the order's customer 
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public async Task<Customer> RetrieveOrderCustomer(long orderId) {
            if (_customerRepository == null)
            {
                throw new UnavailableRepositoryException(typeof(ICustomerRepository));
            }
            return await _customerRepository.RetrieveCustomerByOrderId(orderId);
        }

        #region IRetrievable

        /// <summary>
        /// Method to Retrieve a Order's entity
        /// </summary>
        public async Task<Order> Retrieve(long orderId)
        {
            Order order = new Order()
            {
                ShippingAddress = await RetrieveOrderAddress(orderId),
                Customer = await RetrieveOrderCustomer(orderId)
            };
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



        #endregion

    }
}
