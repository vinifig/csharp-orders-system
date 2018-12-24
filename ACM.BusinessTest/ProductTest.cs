using System;
using Xunit;
using ACM.Business;
using System.ComponentModel.DataAnnotations;

namespace ACM.BusinessTest
{
    /// <summary>
    /// ACM.Business.Product Test Class
    /// </summary>
    public class ProductTest
    {

        /// <summary>
        /// Verifies if Product Validate method is implemented
        /// </summary>
        [Fact]
        public void Product_ValidateMethod_IsImplemented()
        {
            // Arrange
            Product Product = new Product();
            Type expected = typeof(NotImplementedException);

            // Act
            Exception e = Record.Exception(() => Product.Validate());
            Type actual = e?.GetType();

            // Assert
            Assert.NotEqual(expected, actual);
        }

    }
}
