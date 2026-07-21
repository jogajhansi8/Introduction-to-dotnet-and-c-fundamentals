using System;

class Program
{
    static void Main()
    {
        string text;
        int alphabets = 0, digits = 0;

        Console.Write("Enter a string: ");
        text = Console.ReadLine();

        foreach (char ch in text)
        {
            if (char.IsLetter(ch))
            {
                alphabets++;
            }
            else if (char.IsDigit(ch))
            {
                digits++;
            }
        }

        Console.WriteLine("Number of Alphabets = " + alphabets);
        Console.WriteLine("Number of Digits = " + digits);
    }
}
