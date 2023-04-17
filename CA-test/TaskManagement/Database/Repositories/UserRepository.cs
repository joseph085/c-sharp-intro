using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Database.Models;

namespace TaskManagement.Database.Repositories
{
    public class UserRepository
    {
        public User GetUserOrDefaultByEmail(string email)
        {
            foreach (User user in DataContext.Users)
            {
                if (user.Email == email)
                {
                    return user;
                }
            }

            return null!;
        }

    }
}
