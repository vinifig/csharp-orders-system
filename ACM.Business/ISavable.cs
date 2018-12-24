using System;
using System.Collections.Generic;
using System.Text;

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
        T Save();
    }

    /// <summary>
    /// Savable classes interface 
    /// </summary>
    public interface ISavable: ISavable<object>
    {

    }
}
