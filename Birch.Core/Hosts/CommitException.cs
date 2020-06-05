using System;

namespace Birch.Hosts
{
    public class CommitException : Exception
    {
        public CommitException(Exception innerException):base((string) "Commit Failed",innerException)
        {
        }
    }
}