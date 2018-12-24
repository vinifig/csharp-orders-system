﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ACM.Business
{
    /// <summary>
    /// Customer's Entity Class
    /// </summary>
    public class Customer: IValidatable, IRetrievable<Customer>, ISavable<Customer>
    {

        #region Customer

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

        #region IRetrievable

        /// <summary>
        /// Method to Retrieve a customer's entity
        /// </summary>
        public Customer Retrieve(long entityId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Method to Retrieve all customer's entities
        /// </summary>
        public IEnumerable<Customer> Retrieve()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region ISavable

        /// <summary>
        /// Customer's Entity Save Method
        /// </summary>
        /// <returns></returns>
        public Customer Save()
        {
            throw new NotImplementedException();
        }

        #endregion

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
    
    }
}