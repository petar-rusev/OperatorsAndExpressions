using System;

class PointInCircle
{
    static void Main()
        {
        
            Console.WriteLine("Please enter the X coordinate of the point.");
            string x = Console.ReadLine();
            float XPoint;
            while (float.TryParse(x, out XPoint) == false)
            {
                Console.WriteLine("Invalid Input! Please enter an integer number. Example 1,2,3,4...etc.");
                x = Console.ReadLine();
            }

            Console.WriteLine("Please enter the Y coordinate of the point.");
            string y = Console.ReadLine();
            float YPoint;
            while (float.TryParse(y, out YPoint) == false)
            {
                Console.WriteLine("Invalid Input! Please enter an integer number. Example 1,2,3,4...etx.");
                y = Console.ReadLine();
            }
            bool CheckXY;
            int XStart = 0;
            int YStart = 0;
            int radius = 2;
               

            float point = (((XPoint - XStart) * (XPoint - XStart)) + ((YPoint - YStart) * (YPoint - YStart)));

            if (point < radius*radius)
            {
                CheckXY = true;
            }
            else
            {
                CheckXY=false;
            }
            if (CheckXY == true)
            {
                Console.WriteLine("Coordinates:\nx={0}\ny={1}\n{2}!", XPoint, YPoint,CheckXY);
            }
            else
            {
                Console.WriteLine("Coordinates:\nx={0}\ny={1}\n{2}!", XPoint, YPoint,CheckXY);
            }
            
        }
}




