using TaskManagement.Database;
using TaskManagement.Database.Models;
using TaskManagement.Utilities;


namespace TaskManagement.Common
{
    public class RegisterCommand
    {
        public void Handle(DataContext database)
        {
            UserValidator userValidator = new UserValidator();

            string firstName = userValidator.GetAndValidateFirstName();
            string lastName = userValidator. GetAndValidateLastName();
            string password = userValidator.GetAndValidatePassword();
            string email = userValidator.GetAndValidateEmail(database.Users);

            User human = new User(firstName, lastName, password, email);

            database.Users.Add(human);
        }
    }
}
