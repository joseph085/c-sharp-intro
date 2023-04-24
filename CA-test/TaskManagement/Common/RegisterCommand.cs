using TaskManagement.Database;
using TaskManagement.Database.Models;
using TaskManagement.Database.Repositories;
using TaskManagement.Utilities;


namespace TaskManagement.Common
{
    public class RegisterCommand
    {
        public static void Handle()
        {
            UserRepository userRepository = new UserRepository();
            UserValidator userValidator = new UserValidator();

            string firstName = userValidator.GetAndValidateFirstName();
            string lastName = userValidator. GetAndValidateLastName();
            string password = userValidator.GetAndValidatePassword();
            string email = userValidator.GetAndValidateEmail();
            DateTime dateTime = DateTime.Now;


            User human = new User(firstName, lastName, password, email);
            Console.WriteLine($"Succesfully registered {human.Name}, {human.LastName} , {human.Created}");
            userRepository.Insert(human);
        }
    }
}
