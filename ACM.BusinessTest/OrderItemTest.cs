using System;
using Xunit;
using ACM.Business;
using System.ComponentModel.DataAnnotations;

namespace ACM.BusinessTest
{
    /// <summary>
    /// ACM.Business.OrderItem Test Class
    /// </summary>
    public class OrderItemTest
    {

        /// <summary>
        /// Verifies if OrderItem Validate method is implemented
        /// </summary>
        [Fact]
        public void OrderItem_ValidateMethod_IsImplemented()
        {
            // Arrange
            OrderItem OrderItem = new OrderItem();
            Type expected = typeof(NotImplementedException);

            // Act
            Exception e = Record.Exception(() => OrderItem.Validate());
            Type actual = e?.GetType();

            // Assert
            Assert.NotEqual(expected, actual);
        }

    }
}
