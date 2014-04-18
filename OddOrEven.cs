using System;

class OddOrEven
{
    static void Main()
    {
        Console.WriteLine("Please enter a number.");
        string input = Console.ReadLine();

        int num;
        while (int.TryParse(input, out num) == false)
        {
            Console.WriteLine("Invalid input. Please enter for example 1234 or any integer type number!");
            input = Console.ReadLine();
        }
        bool OddEven;
        if (num % 2 == 0)
        {
            OddEven = true;
        }
        else
        {
            OddEven = false;
        }
        Console.WriteLine("Is Prime? {0} - {1}",num,OddEven);

    }
}

