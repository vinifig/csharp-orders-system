﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ACM.Business
{
    /// <summary>
    /// OrderItem's Entity Class
    /// </summary>
    public class OrderItem : IValidatable, IEquatable<OrderItem>
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
        [Range(0.01, double.MaxValue)]
        public double ItemProductPrice { get; set; }

        /// <summary>
        /// Order Item Product's Quantity
        /// </summary>
        [Range(0.01, double.MaxValue)]
        public double Quantity { get; set; }

        /// <summary>
        /// SubTotal Item Price
        /// </summary>
        public double SubTotal { get => ItemProductPrice * Quantity; }

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
        public bool Equals(OrderItem other)
        {
            return GetHashCode() == other.GetHashCode();
        }

        /// <summary>
        /// HashCode Generator
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(ItemId, Product, ItemProductPrice, Quantity, SubTotal);
        }

        #endregion
    }
}
