using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        string result = "";

        foreach (char ch in input)
        {
            // Increment character by 1
            char newChar = (char)(ch + 1);

            // Toggle case
            if (char.IsUpper(newChar))
            {
                newChar = char.ToLower(newChar);
            }
            else if (char.IsLower(newChar))
            {
                newChar = char.ToUpper(newChar);
            }

            result += newChar;
        }

        Console.WriteLine("New String: " + result);
    }
}
