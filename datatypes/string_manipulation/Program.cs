using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();

        Console.Write("Reverse String: ");
        for (int i = str.Length - 1; i >= 0; i--)
        {
            Console.Write(str[i]);
        }
        Console.WriteLine();

        Console.WriteLine("Substring from 2nd Position: " + str.Substring(1));

        Console.Write("Enter the character to replace: ");
        char ch = Convert.ToChar(Console.ReadLine());

        string newString = str.Replace(ch, '$');
        Console.WriteLine("String after Replacement: " + newString);

        string str2 = str;
        str2 = str2 + " Welcome";

        Console.WriteLine("Original String: " + str);
        Console.WriteLine("Modified String: " + str2);
    }
}
