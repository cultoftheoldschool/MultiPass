using System;
using System.Runtime.Serialization;

namespace MultiPass.Exceptions
{
    [Serializable]
    public class VaultCompatibilityException : Exception
    {
        public VaultCompatibilityException() {}
        public VaultCompatibilityException(string message) : base(message) {}
        public VaultCompatibilityException(string message, Exception innerException) : base(message, innerException) {}
        protected VaultCompatibilityException(SerializationInfo info, StreamingContext context) : base(info, context) {}
    }
}
