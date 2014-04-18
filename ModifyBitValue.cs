using System;

class ModifyBitValue
{
    static void Main()
    {
        Console.WriteLine("Please enter an Integer number: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter the position of the bit you would like to see the value: ");
        int p = int.Parse(Console.ReadLine());


        int mask = 1 << p;
        int numAndMask = mask & n;
        int bit = numAndMask >> p;

        string bin = Convert.ToString(n, 2).PadLeft(32, '0');
        Console.WriteLine("The binary representation of the number {0} is: {1}", n, bin);

        if (bit == 0)
        {
            n = n | (1 << p);
            Console.WriteLine("The value of the bit in position {0} is {1} and the changed number is {2}", p, bit, n);

        }
        else
        {
            n = n & (~(1 << p));
            Console.WriteLine("The value of the bit in position {0} is {1} and the changed number is {2}", p, bit, n);

        }
    }
}

