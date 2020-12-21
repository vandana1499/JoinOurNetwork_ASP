using System;
using System.Runtime.Serialization;

namespace AttorneyService.BusinessLayer
{
    [Serializable]
    internal class CustomNotFoundException : Exception
    {
        
        public CustomNotFoundException()
        {
        }

        public CustomNotFoundException(string message) : base(message)
        {
           
        }

        public CustomNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CustomNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}