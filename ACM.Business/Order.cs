using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ACM.Business
{
    /// <summary>
    /// Order's Entity class
    /// </summary>
    public class Order : IRetrievable<Order>, IValidatable, ISavable<Order>
    {

        #region Properties

        /// <summary>
        /// Order's Current Price
        /// </summary>
        public decimal? CurrentPrice { get; set; }

        /// <summary>
        /// Order Id
        /// </summary>
        public long OrderId { get; set; }

        /// <summary>
        /// Order's customer
        /// </summary>
        public Customer Customer { get; set; }

        /// <summary>
        /// Order's Shipping Address
        /// </summary>
        public Address ShippingAddress { get; set; }

        /// <summary>
        /// Order Items
        /// </summary>
        [Required]
        public IEnumerable<OrderItem> Items { get; set; }

        /// <summary>
        /// Order Description
        /// </summary>
        [Required]
        public string Details { get; set; }

        /// <summary>
        /// Last Order's Update DateTime
        /// </summary>
        public DateTimeOffset? Date { get; set; }

        #endregion

        #region Interfaces

        #region IRetrievable
        /// <summary>
        /// Implementation of IRetrievable.Retrieve(long entityId)
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>
        public Order Retrieve(long entityId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Implementation of IRetrievable.Retrieve()
        /// </summary>
        /// <returns></returns>
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

        #region IValidatable

        /// <summary>
        /// Implementation of IValidatable.Validate()
        /// </summary>
        /// <exception cref="ValidationException"></exception>
        public void Validate()
        {
            ValidationContext ctx = new ValidationContext(this);
            Validator.ValidateObject(this, ctx, true);
        }


        #endregion

        #endregion
    }
}

