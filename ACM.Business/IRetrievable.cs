using System.Collections.Generic;

namespace ACM.Business
{
    /// <summary>
    /// Typed Retrievable Class Interface
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRetrievable<T> where T: class
    {
        /// <summary>
        /// Method to Retrieve a entity
        /// </summary>
        T Retrieve(long entityId);

        /// <summary>
        /// Method to Retrieve all entities
        /// </summary>
        IEnumerable<T> Retrieve();
    }

    /// <summary>
    /// Retrievable Class Interface
    /// </summary>
    public interface IRetrievable: IRetrievable<object>
    {

    }
}
