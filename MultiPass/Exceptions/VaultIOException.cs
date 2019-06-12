using System;
using System.Runtime.Serialization;

namespace MultiPass.Exceptions
{
    [Serializable]
    public class VaultIOException : Exception
    {
        public VaultIOException() {}
        public VaultIOException(string message) : base(message) {}
        public VaultIOException(string message, Exception innerException) : base(message, innerException) {}
        protected VaultIOException(SerializationInfo info, StreamingContext context) : base(info, context) {}
    }
}
