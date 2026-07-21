using System;

class Program
{
    static void Main()
    {
        double side, area;

        Console.Write("Enter the side of the square: ");
        side = Convert.ToDouble(Console.ReadLine());

        area = side * side;

        Console.WriteLine("Area of the square = " + area);
    }
}