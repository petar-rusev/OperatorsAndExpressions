using System;

class PerimeterAndAreaRectangle
{
    static void Main()
    {
        Console.WriteLine("Please enter the Width of the Rectangle.");
        string width = Console.ReadLine();
        double WidthRect;
        while(double.TryParse(width,out WidthRect)==false)
        {
            Console.WriteLine("Invalid input! Please enter a number!Example - 5 or 5.5");
            width = Console.ReadLine();
        }

        Console.WriteLine("Please enter the Length of the Rectangle.");
        string length = Console.ReadLine();
        double LengthRect;
        while(double.TryParse(length,out LengthRect)==false)
        {
            Console.WriteLine("Invalid input! Please enter a number!Example - 5 or 5.5");
            width = Console.ReadLine();
        }
        double Perimeter = 2 * (WidthRect + LengthRect);
        double Area = WidthRect * LengthRect;
        Console.WriteLine("The perimeter of the Rectangle is: {0}",Perimeter);
        Console.WriteLine("The area of the Rectangle is: {0}",Area);

            
    }
}

