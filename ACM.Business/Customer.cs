using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ACM.Business
{
    /// <summary>
    /// Customer's Entity Class
    /// </summary>
    public class Customer: IValidatable, IEquatable<Customer>
    {

        #region Customer Constructor

        /// <summary>
        /// Customer's Entity constructor
        /// </summary>
        public Customer()
        {
        }

        /// <summary>
        /// Customer's Entity constructor
        /// </summary>
        /// <param name="id"></param>
        public Customer(long id)
        {
            CustomerId = id;
        }

        /// <summary>
        /// Customer's Entity constructor
        /// </summary>
        public Customer(string firstName, string lastName, [EmailAddress] string email)
        {
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = email;
        }

        #endregion
        
        #region Properties

        /// <summary>
        /// Customer's System ID
        /// </summary>
        public long CustomerId { get; private set; }

        /// <summary>
        /// Customer's Last Name Property
        /// </summary>
        [Required]
        public string LastName { get; set; }

        /// <summary>
        /// Customer's First Name Property
        /// </summary>
        [Required]
        public string FirstName { get; set; }

        /// <summary>
        /// Customer's Email Property
        /// </summary>
        [Required]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string EmailAddress { get; set; }
        
        /// <summary>
        /// Customer's Work Address
        /// </summary>
        public Address WorkAddress { get; set; }

        /// <summary>
        /// Customer's Home Address
        /// </summary>
        [Required]
        public Address HomeAddress { get; set; }

        /// <summary>
        /// Customer's Full Name Getter
        /// </summary>
        public string FullName { get => $"{LastName}, {FirstName}"; }

        #endregion

        #region Interfaces

        #region IValidatable

        /// <summary>
        /// Customer Instance Validator
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
        /// Customer Equals comparison
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(Customer other)
        {
            return GetHashCode() == other.GetHashCode();
        }

        /// <summary>
        /// GetHashCode override
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(CustomerId, LastName, FirstName, EmailAddress, WorkAddress, HomeAddress, FullName);
        }

        #endregion

    }
}
