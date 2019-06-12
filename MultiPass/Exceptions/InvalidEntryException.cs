using System;
using System.Runtime.Serialization;

namespace MultiPass.Exceptions
{
    [Serializable]
    public class InvalidEntryException : Exception
    {
        public InvalidEntryException() {}
        public InvalidEntryException(string message) : base(message) {}
        public InvalidEntryException(string message, Exception innerException) : base(message, innerException) {}
        protected InvalidEntryException(SerializationInfo info, StreamingContext context) : base(info, context) {}
    }
}
