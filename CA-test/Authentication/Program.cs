namespace Authentication
{
    class User
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

    class Database
    {
        public List<User> _users = new List<User>();

        public Database()
        {
            AddUserSeeedings();
        }

        public void AddUserSeeedings()
        {
            _users.Add(new User("Super", "Admin", "123321", "admin@gmail.com", true));
        }
    }

    class LoginCommand
    {
        public void Handle(Database database)
        {
            string email = Console.ReadLine()!;
            string password = Console.ReadLine()!;

            foreach (User user in database._users)
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

    class RegisterCommand
    {
        public Utility _utility = new Utility();

        public void Handle(Database database)
        {
            string firstName = GetAndValidateFirstName();
            string lastName = GetAndValidateLastName();
            string password = GetAndValidatePassword();
            string email = GetAndValidateEmail(database._users);

            User human = new User(firstName, lastName, password, email);

            database._users.Add(human);
        }

        #region First name

        string GetAndValidateFirstName()
        {
            while (true)
            {
                Console.WriteLine("Pls enter first name : ");
                string firstName = Console.ReadLine()!;

                if (IsValidFirstName(firstName))
                    return firstName;

                Console.WriteLine("Some information is not correnct");
            }
        }
        bool IsValidFirstName(string firstName)
        {
            int MIN_LENGTH = 3;
            int MAX_LENGTH = 30;

            return IsValidName(firstName, MIN_LENGTH, MAX_LENGTH);
        }

        #endregion

        #region Last name

        string GetAndValidateLastName()
        {
            while (true)
            {
                Console.WriteLine("Pls enter last name : ");
                string lastName = Console.ReadLine()!;

                if (IsValidLastName(lastName))
                    return lastName;

                Console.WriteLine("Some information is not correnct");
            }
        }
        bool IsValidLastName(string lastName)
        {
            int MIN_LENGTH = 5;
            int MAX_LENGTH = 20;

            return IsValidName(lastName, MIN_LENGTH, MAX_LENGTH);
        }

        #endregion

        #region Password

        string GetAndValidatePassword()
        {
            while (true)
            {
                Console.WriteLine("Pls enter password : ");
                string password = Console.ReadLine()!;

                Console.WriteLine("Pls enter confirm password : ");
                string confirmPassword = Console.ReadLine()!;

                if (password == confirmPassword)
                    return password;

                Console.WriteLine("Some information is not correnct");
            }
        }

        #endregion

        #region Password

        string GetAndValidateEmail(List<User> users)
        {
            char AT_SIGN = '@';

            while (true)
            {
                Console.WriteLine("Pls enter email : ");
                string email = Console.ReadLine()!;
                //Way 1
                //if (_utility.Contains(email, AT_SIGN) && !IsEmailExists(users, email))
                //    return email;

                //Way2
                //bool isValidFormat = false;
                //bool isUnique = false;

                //if (_utility.Contains(email, AT_SIGN))
                //    isValidFormat = true;
                //else
                //{
                //    isValidFormat = false;
                //    Console.WriteLine("Ensure that your email contains @ characheter");
                //}

                //if (!IsEmailExists(users, email))
                //    isUnique = true;
                //else
                //{
                //    isUnique = false;
                //    Console.WriteLine("Your email is already used in system, pls try another email");
                //}

                //if (isValidFormat && isUnique)
                //    return email;

                //Way 3
                //if (_utility.Contains(email, AT_SIGN))
                //{
                //    if (!IsEmailExists(users, email))
                //        return email;
                //    else
                //        Console.WriteLine("Your email is already used in system, pls try another email");
                //}
                //else
                //    Console.WriteLine("Ensure that your email contains @ characheter");

            }
        }

        public bool IsEmailExists(List<User> users, string email)
        {
            foreach (User user in users)
            {
                if (user._email == email)
                {
                    return true;
                }
            }

            return false;
        }

        #endregion

        #region Common

        bool IsValidName(string name, int minLength, int maxLenght)
        {
            if (!_utility.IsLengthBetween(name, minLength, maxLenght))
            {
                return false;
            }

            char firstLetter = name[0];

            if (!_utility.IsUpperLetter(firstLetter))
            {
                return false;
            }

            for (int i = 1; i < name.Length; i++)
            {
                if (_utility.IsUpperLetter(name[i]))
                {
                    return false;
                }
            }

            return true;
        }

        #endregion
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Database database = new Database();

            while (true)
            {
                string command = Console.ReadLine()!;

                switch (command)
                {
                    case "/register":
                        RegisterCommand registerCommand = new RegisterCommand();
                        registerCommand.Handle(database);
                        break;
                    case "/login":
                        LoginCommand loginCommand = new LoginCommand();
                        loginCommand.Handle(database);
                        break;
                    case "/exit":
                        Console.WriteLine("Bye-bye");
                        return;
                    default:
                        Console.WriteLine("Invalid command, pls try again");
                        break;
                }
            }
        }
    }

    public class Utility
    {
        public char[] _uppercaseLetters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
                                        'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        public char[] _numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        #region Utility

        public bool TryParse(string text, out int number)
        {
            try
            {
                number = int.Parse(text);
                return true;
            }
            catch
            {
                number = -1;
                return false;
            }
        }
        public bool IsStartsWith(string text, string startText)
        {
            if (startText.Length > text.Length)
            {
                return false;
            }

            for (int i = 0; i < startText.Length; i++)
            {
                if (text[i] != startText[i])
                {
                    return false;
                }
            }

            return true;
        }
        public string Substring(string text, int startIdx, int endIdx)
        {
            string subString = "";

            for (int i = startIdx; i <= endIdx; i++)
            {
                subString += text[i];
            }

            return subString;
        }
        public string SubstringFromEnd(string text, int length)
        {
            if (text.Length <= length || length < 0)
            {
                return default;
            }

            string subString = "";

            for (int i = text.Length - 1; i >= text.Length - length; i--)
            {
                subString += text[i];
            }

            return Reverse(subString);
        }

        public string Reverse(string text)
        {
            string reversed = "";

            for (int i = text.Length - 1; i >= 0; i--)
            {
                reversed += text[i];
            }

            return reversed;
        }

        public bool IsLengthBetween(decimal number, decimal min, decimal max)
        {
            return number > min && number < max;
        }
        public bool IsLengthBetween(string text, int min, int max)
        {
            return text.Length > min && text.Length < max;
        }

        //Method overloading ( polymorphism)
        public bool IsLengthBetween(int number, int min, int max)
        {
            return number > min && number < max;
        }
        public bool IsUpperLetter(char letter)
        {
            foreach (char uppercaseLetter in _uppercaseLetters) //while LOOP
            {
                if (uppercaseLetter == letter)
                {
                    return true;
                }
            }

            //for (int i = 0; i < uppercaseLetters.Length; i++)
            //{
            //    if (uppercaseLetters[i] == lette)
            //    {
            //        return true;
            //    }
            //}

            return false;
        }


        public bool IsDigit(string text)
        {
            foreach (char characted in text)
            {
                if (!IsDigit(characted))
                {
                    return false;
                }
            }

            return true;
        }
        public bool IsDigit(char digit)
        {
            foreach (char number in _numbers) //Compiled to while LOOP in IL
            {
                if (digit == number)
                {
                    return true;
                }
            }

            return false;
        }
        public bool IsExactLength(string text, int length)
        {
            return text.Length == length;
        }

        public bool Contains(string text, char character)
        {
            foreach (char chr in text)
            {
                if (chr == character)
                    return true;
            }

            return false;
        }


        #endregion
    }
}