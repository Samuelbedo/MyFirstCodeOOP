using System;
using System.Runtime.Serialization;

namespace MyFirstCodeOOP
{
    [Serializable]
    internal class Dayexception : Exception
    {
        public Dayexception()
        {
        }

        public Dayexception(string message) : base(message)
        {
        }

        public Dayexception(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected Dayexception(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}