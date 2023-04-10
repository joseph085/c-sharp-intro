namespace Authentication.Database.Models
{
    public class User
    {
        public string _name;
        public string _lastName;
        public string _password;
        public string _email;
        public bool _isAdmin;

        public User(string name, string lastName, string password, string email, bool isAdmin = false)
        {
            _name = name;
            _lastName = lastName;
            _password = password;
            _email = email;
            _isAdmin = isAdmin;
        }
    }
}