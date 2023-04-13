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
    public class ShowUsersCommand
    {
        public static void Handle()
        {
            int order = 1;

            foreach (User user in DataContext.Users)
            {
                Console.WriteLine($"{order}. {user.GetShortInfo()}");
                order++;
            }
        }
    }
}
