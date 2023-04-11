using TaskManagement.Database.Models;

namespace TaskManagement.Database
{
    public class DataContext
    {
        public List<User> Users { get; set; } = new List<User>();

        public DataContext()
        {
            AddUserSeeedings();
        }

        private void AddUserSeeedings()
        {
            Users.Add(new User("Super", "Admin", "123321", "admin@gmail.com", true));
        }
    }
}
