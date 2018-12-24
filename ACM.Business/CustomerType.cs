using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.Business
{
    /// <summary>
    /// Type of Customer Enum
    /// </summary>
    public enum CustomerType
    {
        /// <summary>
        /// Unknown types
        /// </summary>
        Unknown = 0,

        /// <summary>
        ///  Business Customers
        /// </summary>
        Business = 1,
        /// <summary>
        /// Retail Customers
        /// </summary>
        Residential = 2,
        /// <summary>
        /// Governamental Customers
        /// </summary>
        Government = 3,
        /// <summary>
        /// Professors and Education related customers 
        /// </summary>
        Education = 4
    }
}
