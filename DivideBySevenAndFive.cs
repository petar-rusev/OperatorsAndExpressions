using System;

class DivideBySevenAndFive
{
    static void Main()
    {
        Console.WriteLine("Please enter a number!");
        string num = Console.ReadLine();
        int number;
        bool divide;
        while (int.TryParse(num, out number) == false)
        {
            Console.WriteLine("Invalid input! Please enter a real number.Example - 1 or 1.1");
            num = Console.ReadLine();
        }
        if (number % 7 == 0 & number % 5 == 0)
        {
            divide = true;
        }
        else
        {
            divide = false;
        }
        Console.WriteLine("Is the number divide by 7 and 5?\nThe number{0}->{1}",number,divide);

    }
}

