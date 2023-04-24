using TaskManagement.Common;
using TaskManagement.Database;

namespace TaskManagement
{
    //Encapsulaiton

    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Adding command : ");
                Console.WriteLine("/register");
                Console.WriteLine("/login");
                Console.WriteLine("/exit");
                Console.WriteLine();
                string command = Console.ReadLine()!;
                switch (command)
                {
                    case "/register":
                        RegisterCommand.Handle();
                        break;
                    case "/login":
                        LoginCommand.Handle();
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
}
