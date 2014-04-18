using System;

class WeightOnTheMoon
{
    static void Main()
    {
        Console.WriteLine("Please enter your weight in kilograms.");
        string weight = Console.ReadLine();
        float WeightOnEarth;

        while (float.TryParse(weight, out WeightOnEarth) == false)
        {
            Console.WriteLine("Invalid Input! Please enter your weight in kilograms.Example: 80 or 80.23");
            weight = Console.ReadLine();
        }
        float WeightOnMoon = (WeightOnEarth * 17) / 100;

        Console.WriteLine("Weight on Earth - {0}",WeightOnEarth);
        Console.WriteLine("Weight on Moon - {0}",WeightOnMoon);
      

    }
}

