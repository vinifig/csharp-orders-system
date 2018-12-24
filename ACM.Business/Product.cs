using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ACM.Business
{
    /// <summary>
    /// Product's Entity class
    /// </summary>
    public class Product : ISavable<Product>, IRetrievable<Product>, IValidatable
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
        public string ProductDescription { get; set; }

        /// <summary>
        /// Product Name
        /// </summary>
        [Required]
        public string ProductName { get; set; }

        #endregion

        #region Interfaces

        #region IRetrievable
        /// <summary>
        /// Implementation of IRetrievable.Retrieve(long entityId)
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>
        public Product Retrieve(long entityId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Implementation of IRetrievable.Retrieve()
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Product> Retrieve()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region ISavable

        /// <summary>
        /// Product's Instance Save method
        /// </summary>
        /// <returns></returns>
        public Product Save()
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
