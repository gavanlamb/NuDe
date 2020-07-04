using System;

namespace NuDe.Exceptions
{
    /// <summary>
    /// An exception for a path supplied that points to a file.
    /// </summary>
    public class PathIsAFileException : System.IO.IOException
    {
        /// <summary>
        /// An exception for a path supplied that points to a file.
        /// </summary>
        public PathIsAFileException()
        {
        }

        /// <summary>
        /// An exception for a path supplied that points to a file.
        /// </summary>
        /// <param name="message">Describes the error</param>
        public PathIsAFileException(string message) : base(message)
        {
        }

        /// <summary>
        /// An exception for a path supplied that points to a file.
        /// </summary>
        /// <param name="message">Describes the error</param>
        /// <param name="inner">The exception that is the cause of the current exception. If the innerException parameter is not null, the current exception is raised in a catch block that handles the inner exception.</param>
        public PathIsAFileException(string message, Exception inner) : base(message, inner)
        {
        }
        
        /// <summary>
        /// An exception for a path supplied that points to a file.
        /// </summary>
        /// <param name="message">Describes the error</param>
        /// <param name="hresult">An integer identifying the error that has occurred.</param>
        public PathIsAFileException(string message, int hresult) : base(message, hresult)
        {
        }
    }
}