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
        /// Address City's Street
        /// </summary>
        [Required]
        public string Street { get; set; }

        /// <summary>
        /// Address State's City
        /// </summary>
        [Required]
        public string City { get; set; }

        /// <summary>
        /// Address Country's State
        /// </summary>
        [StringLength(2)]
        [Required]
        public string State { get; set; }

        /// <summary>
        /// Address Zip Code
        /// </summary>
        public string ZipCode { get; set; }

        /// <summary>
        /// Address Country
        /// </summary>
        [StringLength(3)]
        [Required]
        public string Country { get; set; }

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
