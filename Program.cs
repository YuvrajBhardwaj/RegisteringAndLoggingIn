using System;

namespace RegisteringAndLoggingIn
{
    class Program
    {
        static string username;
        static string password;
        static void Main(string[] args)
        {
            Register();
            Login();
            Console.Read();
        }
        public static void Register()
        {
            Console.WriteLine("Please enter your username.");
            username = Console.ReadLine();
            Console.WriteLine("Please enter your password.");
            password = Console.ReadLine();
            Console.WriteLine("Regestration Completed.");
            Console.WriteLine("--------------------------------------------------------");
        }

        public static void Login()
        {
            Console.WriteLine("Please enter your username");
            if (username == Console.ReadLine())
            {
                Console.WriteLine("Please enter your password");
                if(password == Console.ReadLine())
                {
                    Console.WriteLine("Login Successful");
                }
                else
                {
                    Console.WriteLine("Login Failed, wrong password. Restart your Program");
                }
            }
            else
            {
                Console.WriteLine("Login Failed, wrong username. Restart your Program");
            }
        }
    }
}
