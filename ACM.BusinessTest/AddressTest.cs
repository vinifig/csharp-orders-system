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

        /// <summary>
        /// Verifies if invalid data throws ValidationErrors
        /// </summary>
        /// <param name="street"></param>
        /// <param name="city"></param>
        /// <param name="state"></param>
        /// <param name="zipCode"></param>
        /// <param name="country"></param>
        [Theory]
        #region Required
        [InlineData(null, "Hello City", "UT", "00000-000", "USA")]
        [InlineData("Downtown Street", null, "UT", "00000-000", "USA")]
        [InlineData("Downtown Street", "Hello City", null, "00000-000", "USA")]
        [InlineData("Downtown Street", "Hello City", "UT", null, "USA")]
        [InlineData("Downtown Street", "Hello City", "UT", "00000-000", null)]
        #endregion
        #region StringLength
        [InlineData("Downtown Street", "Hello City", "UTC", "00000-000", "USA")]
        [InlineData("Downtown Street", "Hello City", "UT", "00000-000", "USA1")]
        #endregion
        public void Address_InvalidProperties_ThrowsValidationExceptions(string street, string city, string state, string zipCode, string country)
        {
            // Arrange
            Address address = new Address()
            {
                Street = street,
                City = city,
                State = state,
                ZipCode = zipCode,
                Country = country
            };

            // Act

            // Assert
            Assert.Throws<ValidationException>(() => address.Validate());
        }

    }
}
