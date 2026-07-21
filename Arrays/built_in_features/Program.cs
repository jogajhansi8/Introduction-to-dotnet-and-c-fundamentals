using System;

class Program
{
    static void Main()
    {
        int[] arr = new int[5];

        Console.WriteLine("Enter 5 elements:");

        int count = 0;

        for (int i = 0; i < 5; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
            count++;
        }

        Console.WriteLine("Number of elements in the array = " + count);
    }
}