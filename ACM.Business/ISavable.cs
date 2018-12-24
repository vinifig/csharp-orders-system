using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ACM.Business
{
    /// <summary>
    /// Typed Savable classes interface 
    /// </summary>
    public interface ISavable<T> where T: class
    {
        /// <summary>
        /// Instance's Save method
        /// </summary>
        /// <returns></returns>
        Task<T> Save(T entity);
    }

    /// <summary>
    /// Savable classes interface 
    /// </summary>
    public interface ISavable: ISavable<object>
    {

    }
}
