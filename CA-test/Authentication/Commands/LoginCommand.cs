using Authentication.Database;
using Authentication.Database.Models;

namespace Authentication.Commands
{
    public class LoginCommand
    {
        public void Handle(DataContext database) //use alias
        {
            string email = Console.ReadLine()!;
            string password = Console.ReadLine()!;

            foreach (User user in database._users) //fully qualified namespace
            {
                if (user._email == email && user._password == password)
                {
                    if (user._isAdmin)
                        Console.WriteLine("Hello dear admin");
                    else
                        Console.WriteLine($"Hello! : {user._email} {user._password}");
                }
            }

        }
    }
}
