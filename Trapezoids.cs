using System;

class Trapezoids
{
    static void Main()
    {
        Console.WriteLine("Please enter the base A of the Trapezoid.");
        string a = Console.ReadLine();
        Console.WriteLine("Please enter the base B of the Trapezoid.");
        string b = Console.ReadLine();
        Console.WriteLine("Please enter the height of the Trapezoid.");
        string c = Console.ReadLine();
        double BaseA;
        double BaseB;
        double Height;
        while (double.TryParse(a, out BaseA) == false)
        {
            Console.WriteLine("Invalid input! Please enter an integer or real number!");
            a = Console.ReadLine();
        }
        while (double.TryParse(b, out BaseB) == false)
        {
            Console.WriteLine("Invalid input! Please enter an integer or real number!");
            b = Console.ReadLine();
        }
        while (double.TryParse(c, out Height) == false)
        {
            Console.WriteLine("Invalid input! Please enter an integer or real number!");
            c = Console.ReadLine();
        }
        double area = ((BaseA + BaseB) / 2) * Height;
        Console.WriteLine("\n\nThe Area of the Trapezoid\nBase A={0}\nBase B={1}\nHeight={2}\nArea={3}",BaseA,BaseB,Height,area);
    }
}

