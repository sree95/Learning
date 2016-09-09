using System;
using System.Runtime.Serialization;

namespace CustomExceptions
{
    class MyCustomException : Exception
    {
        public MyCustomException()
            :base()
        {

        }

        public MyCustomException(string message)
            :base(message)
        {

        }

        public MyCustomException(string message, Exception innerException)
            :base(message,innerException)                        
        {

        }

        public MyCustomException(SerializationInfo info,StreamingContext context)
            :base(info,context)
        {

        }
        
    }
}
