using System;
using Xunit;
using ACM.Business;
using System.ComponentModel.DataAnnotations;

namespace ACM.BusinessTest
{
    /// <summary>
    /// ACM.Business.Address Test Class
    /// </summary>
    public class AddressTest
    {

        /// <summary>
        /// Verifies if Address Validate method is implemented
        /// </summary>
        [Fact]
        public void Address_ValidateMethod_IsImplemented()
        {
            // Arrange
            Address Address = new Address();
            Type expected = typeof(NotImplementedException);

            // Act
            Exception e = Record.Exception(() => Address.Validate());
            Type actual = e?.GetType();

            // Assert
            Assert.NotEqual(expected, actual);
        }

    }
}
