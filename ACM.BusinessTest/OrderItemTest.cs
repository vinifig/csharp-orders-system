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


        /// <summary>
        /// Verifies if invalid data throws ValidationErrors
        /// </summary>
        /// <param name="price"></param>
        /// <param name="quantity"></param>
        [Theory]
        #region Range
        [InlineData(0, 0.01)]
        [InlineData(-1, 0.01)]
        [InlineData(0.01, 0)]
        [InlineData(0.01, -1)]
        [InlineData(-1, -1)]
        #endregion
        public void OrderItem_InvalidProperties_ThrowsValidationExceptions(double price, double quantity)
        {
            // Arrange
            OrderItem orderItem = new OrderItem()
            {
                Product = new Product()
            };

            // Act

            // Assert
            Assert.Throws<ValidationException>(() => orderItem.Validate());
        }

    }
}
