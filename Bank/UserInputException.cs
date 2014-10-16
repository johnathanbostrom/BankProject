using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Bank
{
    [Serializable]
    class UserInputException : Exception
    {
        public UserInputException()
            : base() { }

        public UserInputException(string message)
            : base(message) { }

        public UserInputException(string format, params object[] args)
            : base(string.Format(format, args)) { }

        public UserInputException(string message, Exception innerException)
            : base(message, innerException) { }

        public UserInputException(string format, Exception innerException, params object[] args)
            : base(string.Format(format, args), innerException) { }

        protected UserInputException(SerializationInfo info, StreamingContext context)
            : base(info, context) { }
    }
}
