using System.ComponentModel.DataAnnotations;

namespace ACM.Business
{
    /// <summary>
    /// Validatable Interface
    /// </summary>
    public interface IValidatable
    {
        /// <summary>
        /// Method to validate the object instance
        /// </summary>
        /// <exception cref="ValidationException"></exception>
        /// <returns cref="bool"></returns>
        void Validate();
    }
}
