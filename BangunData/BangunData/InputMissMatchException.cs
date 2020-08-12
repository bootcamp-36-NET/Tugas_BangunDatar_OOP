using System;
using System.Runtime.Serialization;

namespace BangunData
{
    [Serializable]
    internal class InputMissMatchException : Exception
    {
        public InputMissMatchException()
        {
        }

        public InputMissMatchException(string message) : base(message)
        {
        }

        public InputMissMatchException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InputMissMatchException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}