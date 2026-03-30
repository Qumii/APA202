using _08_StatiClassExtensionMethodsExceptions.Exceptions;
using _08_StatiClassExtensionMethodsExceptions.Models;

namespace _08_StatiClassExtensionMethodsExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LoginSystem loginSystem = new LoginSystem();

            while (true)
            {
                try
                {
                    Console.Write("Username: ");
                    string username = Console.ReadLine();

                    Console.Write("Password: ");
                    string password = Console.ReadLine();

                    bool result = loginSystem.Login(username, password);

                    if (result)
                    {
                        break;
                    }
                }
                catch (InvalidUsernameException ex) 
                { 
                    Console.WriteLine("ERROR: " + ex.Message); 
                }
                catch (InvalidPasswordException ex) 
                { 
                    Console.WriteLine("ERROR: " + ex.Message); 
                }
                catch (UserNotFoundException ex) 
                { 
                    Console.WriteLine($"ERROR: {ex.Message}  Movcud userler: admin, student, teacher");                    
                }
                catch (IncorrectPasswordException ex) 
                { 
                    Console.WriteLine("WARNING: " + ex.Message); 
                }
                catch (AccountLockedException ex) 
                { 
                    Console.WriteLine($"CRITICAL: {ex.Message}  Contact admin");
                    break;
                }
                catch (Exception ex) 
                { 
                    Console.WriteLine("UNEXPECTED ERROR: " + ex.Message); 
                }
               
            }
        }
    }
}
