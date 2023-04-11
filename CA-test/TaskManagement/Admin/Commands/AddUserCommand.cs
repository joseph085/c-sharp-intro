using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Common;
using TaskManagement.Database;
using TaskManagement.Database.Models;

namespace TaskManagement.Admin.Commands
{
    public class AddUserCommand
    {
        public void Handle(DataContext dataContext)
        {
            UserValidator userValidator = new UserValidator();

            string firstName = userValidator.GetAndValidateFirstName();
            string lastName = userValidator.GetAndValidateLastName();
            string password = userValidator.GetAndValidatePassword();
            string email = userValidator.GetAndValidateEmail(dataContext.Users);

            User human = new User(firstName, lastName, password, email);

            dataContext.Users.Add(human);
        }
    }
}
