using System;
using Xunit;
using ACM.Business;
using System.ComponentModel.DataAnnotations;
using System.Collections;
using System.Collections.Generic;

namespace ACM.BusinessTest
{
    /// <summary>
    /// ACM.Business.Order Test Class
    /// </summary>
    public class OrderTest
    {

        /// <summary>
        /// Verifies if Order Validate method is implemented
        /// </summary>
        [Fact]
        public void Order_ValidateMethod_IsImplemented()
        {
            // Arrange
            Order Order = new Order();
            Type expected = typeof(NotImplementedException);

            // Act
            Exception e = Record.Exception(() => Order.Validate());
            Type actual = e?.GetType();

            // Assert
            Assert.NotEqual(expected, actual);
        }

        /// <summary>
        /// Verifies if Order Items's Property is not null when initialized
        /// </summary>
        [Fact]
        public void Order_Initialize_ItemsShouldNotBeNull()
        {
            // Arrange
            Order order = new Order();
            IEnumerable<OrderItem> expected = null;
            IEnumerable<OrderItem> actual = order.Items;

            // Act

            // Assert
            Assert.NotEqual(expected, actual);
        }

    }
}
