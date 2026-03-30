using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_StatiClassExtensionMethodsExceptions.Exceptions
{
    internal class InvalidPasswordException : Exception
    {
        public InvalidPasswordException() : base("Password bos ve ya 6 simvoldan azdir!") { }
        public InvalidPasswordException(string message) : base(message) { }
    }
}
