using System;

class Program
{
    static void Main()
    {
        int num1, num2;

        Console.Write("Enter num1: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter num2: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        int a = num1;
        int b = ++a;
        Console.WriteLine("\nAfter Pre-Increment:");
        Console.WriteLine("num1 = " + a);
        Console.WriteLine("num2 = " + b);
        a = num1;
        b = a++;
        Console.WriteLine("\nAfter Post-Increment:");
        Console.WriteLine("num1 = " + a);
        Console.WriteLine("num2 = " + b);

        Console.WriteLine("\nBefore Swapping:");
        Console.WriteLine("num1 = " + num1);
        Console.WriteLine("num2 = " + num2);

        int temp = num1;
        num1 = num2;
        num2 = temp;

        Console.WriteLine("\nAfter Swapping:");
        Console.WriteLine("num1 = " + num1);
        Console.WriteLine("num2 = " + num2);
    }
}