using System;
using Xunit;
using ACM.Business;
using System.ComponentModel.DataAnnotations;

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

    }
}
