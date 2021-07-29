using System;

namespace login
{
    class Program
    {

        static string username;
        static string password;

        static void Main(string[] args)
        {
            register();
            System.Threading.Thread.Sleep(3000);

            login();
        }

        static void register()
        {
            Console.Clear();

            username = userInput("Please enter your username\n");
            Console.Clear();
            password = userInput("Please enter your password\n");
            Console.Clear();
            Console.WriteLine("Registration complete");

        }

        static void login(string tempUsername = "")
        {
            Console.Clear();
            string password = "";

            //User-Input
            if (tempUsername.Equals(username))
            {
                Console.WriteLine($"Hello {username}");
                password = userInput("Please enter correct password\n");
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Login");
                username = userInput("Please enter your username\n");
                Console.Clear();
                Console.WriteLine("Login");
                password = userInput("Please enter your password\n");
                Console.Clear();
            }


            // Send login cred
            doLogin(username, password);

            Console.Read();
        }

        static string userInput(string value)
        {
            Console.WriteLine(value);
            return Console.ReadLine();
        }

        static string doLogin(string inputUsername, string inputPassword)
        {
            // one user database
            //   string checkUser = "admin";
            //   string checkPassword = "admin";

            //Code inside will be executed, if login is true
            if (inputUsername.Equals(username) && inputPassword.Equals(password))
            {
                Console.WriteLine($"Hello {username} \nyou are now logged in");
            }
            else
            {
                Console.WriteLine("Error");

                if (!username.Equals(inputUsername))
                {
                    Console.WriteLine("Wrong username");
                    login();
                }

                if (!password.Equals(inputPassword))
                {
                    Console.WriteLine("Wrong password, try again");

                    login(inputUsername);

                }
            }
            return Console.ReadLine();
        }


    }
}
