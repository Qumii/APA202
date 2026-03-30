using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_StatiClassExtensionMethodsExceptions.Models
{
    internal class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool isLocked { get; set; }
        public int FailedAttempts { get; set; }

        public User(string username, string password)
        {
            Username=username;
            Password=password;
            isLocked = false;
            FailedAttempts = 0;
        }
    }
}
