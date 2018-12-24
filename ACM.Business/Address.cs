using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ACM.Business
{
    /// <summary>
    /// Address Entity
    /// </summary>
    public class Address: IRetrievable<Address>, ISavable<Address>, IValidatable
    {


        #region Properties
        
        /// <summary>
        /// Address Id
        /// </summary>
        public long? AddressId { get; set; }

        /// <summary>
        /// Address Street
        /// </summary>
        [Required]
        public string Street { get; set; }

        #endregion

        #region Interfaces

        #region IRetrievable

        /// <summary>
        /// Address Entity Retrieve Method
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>
        public Address Retrieve(long entityId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Address Collection Entity Retrieve Method
        /// Not Implemented
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Address> Retrieve()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region ISavable

        /// <summary>
        /// Address Entity Save Method
        /// </summary>
        /// <returns></returns>
        public Address Save()
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
