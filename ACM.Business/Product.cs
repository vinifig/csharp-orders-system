using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ACM.Business
{
    /// <summary>
    /// Product's Entity class
    /// </summary>
    public class Product : IValidatable, IEquatable<Product>
    {

        #region Properties

        /// <summary>
        /// Product's Current Price
        /// </summary>
        public double? CurrentPrice { get; set; }

        /// <summary>
        /// Product Id
        /// </summary>
        public long ProductId { get; set; }

        /// <summary>
        /// Product Description
        /// </summary>
        [Required]
        [StringLength(int.MaxValue, MinimumLength = 1)]
        public string Description { get; set; }

        /// <summary>
        /// Product Name
        /// </summary>
        [Required]
        [StringLength(int.MaxValue, MinimumLength = 1)]
        public string Name { get; set; }

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
        public bool Equals(Product other)
        {
            return GetHashCode() == other.GetHashCode();
        }

        /// <summary>
        /// HashCode Generator
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(CurrentPrice, ProductId, Description, Name);
        }

        #endregion
    }
}
