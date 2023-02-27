using System;
using System.Runtime.Serialization;

namespace MyFirstCodeOOP
{
    [Serializable]
    internal class MonthExcepction : Exception
    {
        public MonthExcepction()
        {
        }

        public MonthExcepction(string message) : base(message)
        {
        }

        public MonthExcepction(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MonthExcepction(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}