using System;

class ThirdDigitIsSeven
{
    static void Main()
    {
        Console.WriteLine("Please enter a number.");
        string num = Console.ReadLine();
        
        char [] NumArray = new char[num.Length];
        for(int i = 0;i<num.Length;i++)
        {
            NumArray[i] = num[i];
        }


        int counter = -1;
        bool check = false;
        if (NumArray.Length < 3)
        {
            check = false;
            Console.WriteLine("The third digit of the number {0} is 7 ----> {1}", num, check);
        }
        else
        {
            for (int i = num.Length; i > 0; i--)
            {
                counter++;
                if (counter == 2)
                {
                    
                    if (NumArray[i-1] == '7')
                    {
                        check = true;
                        Console.WriteLine("The third digit of the number {0} is 7 ----> {1}", num, check);
                    }
                    else
                    {
                        check = false;
                        Console.WriteLine("The third digit of the number {0} is 7 ----> {1}", num, check);
                    }
                }
                
            }
        }
       
    }
}

