using System;
using System.Runtime.Serialization;

namespace ClassLibrary
{
    [Serializable]
    public class FunctionLibException : Exception
    {
        public FunctionLibException()
        {
        }

        public FunctionLibException(string message) : base(message)
        {
        }

        public FunctionLibException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected FunctionLibException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}