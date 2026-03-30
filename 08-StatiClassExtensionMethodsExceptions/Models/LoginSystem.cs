using _08_StatiClassExtensionMethodsExceptions.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_StatiClassExtensionMethodsExceptions.Models
{
    internal class LoginSystem
    {
        private User[] users;
        private const int MaxAttempts = 3;

        public LoginSystem()
        {
            users = new User[]
            {
                new User("admin", "admin123"),
                new User("student", "student123"),
                new User("teacher", "teacher123")
            };
        }

        public void ValidateUsername(string username)
        {
            if (string.IsNullOrEmpty(username) || username.Length < 3)
            {
                throw new InvalidUsernameException();
            }
        }

        public void ValidatePassword(string password)
        {
            if (string.IsNullOrEmpty(password) || password.Length < 6)
            {
                throw new InvalidPasswordException();
            }
        }

        private User FindUser(string username)
        {
            for (int i = 0; i < users.Length; i++)
            {
                if (users[i].Username.ToLower() == username.ToLower())
                {
                    return users[i];
                }
            }
            return null;

        }

        public bool Login(string username, string password)
        {
            ValidateUsername(username);
            ValidatePassword(password);

            User user = FindUser(username);
            if (user == null)
            {
                throw new UserNotFoundException(username);
            }
            if (user.isLocked)
            {
                throw new AccountLockedException();
            }
            if (user.Password == password)
            {
                user.FailedAttempts = 0;
                Console.WriteLine($"Login successfull! Welcome, {username}!");
                return true;
            }
            else
            {
                user.FailedAttempts++;
                int attemptsleft = MaxAttempts - user.FailedAttempts;
                if (attemptsleft > 0)
                {
                    throw new IncorrectPasswordException(attemptsleft);
                }
                else
                {
                    user.isLocked = true;
                    throw new AccountLockedException();
                }

            }
        }
    }
}
