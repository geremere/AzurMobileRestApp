using System;
using System.Runtime.Serialization;

namespace FunctionLib
{
    [Serializable]
    public class FunctionLibArgumentException : Exception
    {
        public FunctionLibArgumentException()
        {
        }

        public FunctionLibArgumentException(string message) : base(message)
        {
        }

        public FunctionLibArgumentException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected FunctionLibArgumentException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}