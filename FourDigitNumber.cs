using System;

class FourDigitNumber
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter four digit number (1234)");
        string number = Console.ReadLine();
        char[] NumArray = new char[number.Length];
        int counter=-1;

        if (number.Length > 4 | number.Length < 4)
        {
            Console.WriteLine("The number is with more or less digits!Please enter number with four digits!");
        }
        else
        {
            
            for (int i = 0; i < number.Length; i++)
            {
                NumArray[i] = number[i];
                counter++;
            }
            
        }
        int a = NumArray[0]-'0';
        int b = NumArray[1]-'0';
        int c = NumArray[2]-'0';
        int d = NumArray[3]-'0';
       
        int sum = a + b + c + d;
        
        Console.WriteLine("The sum of the digits of the number {0} is {1}",number,sum);
        Console.WriteLine("{0}{1}{2}{3}",d,c,b,a);
        Console.WriteLine("{0}{1}{2}{3}", d, a, b, c);
        Console.WriteLine("{0}{1}{2}{3}", a, c, b, d);
      
    }
}
