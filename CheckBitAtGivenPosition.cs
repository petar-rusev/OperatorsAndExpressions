using System;

class CheckBitAtGivenPosition
{
    static void Main()
    {
        Console.WriteLine("Please enter a number: ");
        int num = int.Parse(Console.ReadLine());
        string bin = Convert.ToString(num, 2).PadLeft(64, '0');
        Console.WriteLine("Binary representation of the number {0} is: {1}\n\n", num, bin);
        Console.WriteLine("Please enter the number of the bit you want to check.");

        int p = int.Parse(Console.ReadLine());

        int mask = 1 << p;
        int secondnum = num;

        int maskAndSecondNum = mask & secondnum;
        int bit = maskAndSecondNum >> p;
        bool check;
        if (bit == 0)
        {
            check = false;
        }
        else
        {
            check = true;
        }
        Console.WriteLine("The value of the {0} bit of the number {1} is 1? - {2}\n\n ", p, num,check);
    }
}

