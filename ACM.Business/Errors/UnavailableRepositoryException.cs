using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.Business.Errors
{
    /// <summary>
    /// Exception throwed when a repository is not available
    /// </summary>
    public class UnavailableRepositoryException : Exception
    {
        /// <summary>
        /// UnavailableRepositoryException constructor
        /// </summary>
        public UnavailableRepositoryException(Type repositoryType)
            : base($"Unavailable {repositoryType.Name} repository") { 

        }
    }
}
