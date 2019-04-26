using System;
using System.Runtime.Serialization;

namespace ClassLibrary1
{
    [Serializable]
    public class PropertyExceptinon : Exception
    {
        public PropertyExceptinon()
        {
        }

        public PropertyExceptinon(string message) : base(message)
        {
        }

        public PropertyExceptinon(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected PropertyExceptinon(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}