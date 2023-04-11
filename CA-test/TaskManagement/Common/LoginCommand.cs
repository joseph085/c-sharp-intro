using TaskManagement.Admin;
using TaskManagement.Client;
using TaskManagement.Database;
using TaskManagement.Database.Models;

namespace TaskManagement.Common
{
    public class LoginCommand
    {
        public void Handle(DataContext database) //use alias
        {
            string email = Console.ReadLine()!;
            string password = Console.ReadLine()!;

            foreach (User user in database.Users) //fully qualified namespace
            {
                if (user.Email == email && user.Password == password)
                {
                    if (user.IsAdmin)
                    {
                        AdminDashboard adminDashboard = new AdminDashboard();
                        adminDashboard.Introduction(database);
                    }
                    else
                    {
                        ClientDashboard clientDashboard = new ClientDashboard();
                        clientDashboard.Introduction(user);
                    }  
                }
            }

        }
    }
}
