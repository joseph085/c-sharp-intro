using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Admin.Commands;
using TaskManagement.Database;

namespace TaskManagement.Admin
{
    public class AdminDashboard
    {
        public void Introduction(DataContext dataContexts)
        {
            Console.WriteLine("Hello dear admin");

            while (true)
            {
                string command = Console.ReadLine()!;

                switch (command)
                {
                    case "/add-user":
                        AddUserCommand addUserCommand = new AddUserCommand();
                        addUserCommand.Handle(dataContexts);
                        break;
                    case "/logout":
                        Console.WriteLine("Bye-bye");
                        return;
                    default:
                        Console.WriteLine("Invalid command, pls try again");
                        break;
                }
            }
        }

    }
}
