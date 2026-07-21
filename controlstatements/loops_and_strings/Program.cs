using System;

class Program
{
    static void Main()
    {
        string username = "admin";
        string password = "12345";

        string user, pass;
        int attempts = 0;

        while (attempts < 3)
        {
            Console.Write("Enter Login: ");
            user = Console.ReadLine();

            Console.Write("Enter Password: ");
            pass = Console.ReadLine();

            if (user == username && pass == password)
            {
                Console.WriteLine("Login Successful");
                return;
            }
            else
            {
                attempts++;
                Console.WriteLine("Invalid Login or Password");
            }
        }

        Console.WriteLine("You are rejected after 3 wrong attempts.");
    }
}