using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ACM.Business
{
    /// <summary>
    /// Address Entity
    /// </summary>
    public class Address : IValidatable, IEquatable<Address>
    {
        #region Address Constructor

        /// <summary>
        /// Address Entity's constructor
        /// </summary>
        public Address()
        {

        }

        /// <summary>
        /// Address Entity's constructor
        /// </summary>
        public Address(long addressId)
        {
            AddressId = addressId;
        }

        #endregion

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
        [Required]
        public string ZipCode { get; set; }

        /// <summary>
        /// Address Country
        /// </summary>
        [StringLength(3)]
        [Required]
        public string Country { get; set; }

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
        /// Instance hashcode generator
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(AddressId, Street, City, State, ZipCode, Country);
        }

        /// <summary>
        /// Equals comparison
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(Address other)
        {
            return GetHashCode() == other.GetHashCode();
        }

        #endregion
    }
}
