using System;

class PrimeNumberCheck
{
    static void Main()
    {
        Console.WriteLine("Please enter a number which is n ≤ 100");
        string num = Console.ReadLine();
        byte number;
        while (byte.TryParse(num, out number) == false)
        {
            Console.WriteLine("The entered number is not valid! Please enter a number according to the definition n ≤ 100 ");
            num = Console.ReadLine();
            
        }
        if (number > 100)
        {
            Console.WriteLine("The entered number is not valid! Please enter a number according to the definition n ≤ 100 ");
            num = Console.ReadLine();
        }
        bool check=false;
        if (number % 2 == 0)
        {
            check = true;
        }
        else
        {
            check = false;
        }

        Console.WriteLine("The number {0} is Prime------> {1}",number,check);
    }
}

