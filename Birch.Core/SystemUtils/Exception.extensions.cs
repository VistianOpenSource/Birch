using System;
using System.Collections.Generic;
using System.Text;

namespace Birch
{
    public static class ExceptionExtensions
    {
        /// <summary>
        /// Given an exception enumerate all of the inner exceptions
        /// </summary>
        /// <param name="exception"></param>
        /// <returns></returns>j
        public static IEnumerable<Exception> GetInnerExceptions(this Exception exception)
        {
            if (exception == null)
            {
                throw new ArgumentNullException(nameof(exception));
            }

            var innerException = exception;
            do
            {
                yield return innerException;
                innerException = innerException.InnerException;
            }
            while (innerException != null);
        }

    }
}
