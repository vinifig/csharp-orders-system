using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ACM.Business
{
    /// <summary>
    /// OrderItem's Entity Class
    /// </summary>
    public class OrderItem: ISavable<OrderItem>, IRetrievable<OrderItem>, IValidatable
    {

        #region Properties

        /// <summary>
        /// OrderItem Id
        /// </summary>
        public long ItemId { get; set; }

        /// <summary>
        /// Order's Item Product
        /// </summary>
        [Required]
        public Product Product { get; set; }

        /// <summary>
        /// Price of order's product 
        /// </summary>
        [Required]
        public double ItemProductPrice { get; set; }

        /// <summary>
        /// Order Item Product's Quantity
        /// </summary>
        [Required]
        public double Quantity { get; set; }

        /// <summary>
        /// SubTotal Item Price
        /// </summary>
        public double SubTotal { get => ItemProductPrice * Quantity; }

        #endregion

        #region Interfaces

        #region IRetrievable
        /// <summary>
        /// Implementation of IRetrievable.Retrieve(long entityId)
        /// </summary>
        /// <param name="orderItemId"></param>
        /// <returns></returns>
        public OrderItem Retrieve(long orderItemId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Implementation of IRetrievable.Retrieve()
        /// </summary>
        /// <returns></returns>
        public IEnumerable<OrderItem> Retrieve()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region ISavable

        /// <summary>
        /// Product's Instance Save method
        /// </summary>
        /// <returns></returns>
        public OrderItem Save()
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
