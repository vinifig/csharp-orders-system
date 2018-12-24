using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ACM.Business
{
    /// <summary>
    /// Order's Entity class
    /// </summary>
    public class Order : IValidatable, IEquatable<Order>
    {
        #region Order Constructor
        /// <summary>
        /// Order Initializer
        /// </summary>
        public Order()
        {
            Items = new List<OrderItem>();
        }

        /// <summary>
        /// Order Initializer
        /// </summary>
        /// <param name="orderId"></param>
        public Order(long orderId)
        {
            OrderId = orderId
        }

        #endregion

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
        public string Details { get; set; }

        /// <summary>
        /// Last Order's Update DateTime
        /// </summary>
        public DateTimeOffset? Date { get; set; }

        #endregion

        #region Interfaces

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

        #region Overrides

        /// <summary>
        /// Equals comparison
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(Order other)
        {
            return GetHashCode() == other.GetHashCode();
        }

        /// <summary>
        /// HashCode Generator
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(CurrentPrice, OrderId, Customer, ShippingAddress, Items, Details, Date);
        }

        #endregion
    }
}

