using System;

class PointInsideCircleOutsideRec
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
            Console.WriteLine("Invalid Input! Please enter an integer number. Example 1,2,3,4...etc.");
            y = Console.ReadLine();
        }
        bool CheckXY;
        int XStart = 1;
        int YStart = 1;
        float radius = 1.5F;
        

        float point = (((XPoint - XStart) * (XPoint - XStart)) + ((YPoint - YStart) * (YPoint - YStart)));

        if (point < radius * radius)
        {
            CheckXY = true;
        }
        else
        {
            CheckXY = false;
        }

        bool CheckRectX;
        float RectXMin = -1;
        float RectXMax = 5;
        float RectYMin = -1;
        float RectYMax = 1;
        bool CheckXRectIn = XPoint > RectXMin & XPoint < RectXMax;
        bool CheckXRectLim = XPoint == RectXMin | XPoint == RectXMax;
        CheckRectX = CheckXRectIn | CheckXRectLim;

        bool CheckRectY;
        bool CheckYRectIn = YPoint > RectYMin & YPoint < RectYMax;
        bool CheckYRectLim = YPoint == RectYMin | YPoint == RectYMax;
        CheckRectY = CheckYRectIn | CheckYRectLim;

        bool CheckRect = CheckRectX & CheckRectY;
        string confirm = "Yes";
        if (CheckRect & CheckXY == true)
        {
            Console.WriteLine("Coordinates:\nx={0}\ny={1}\nIs inside the Rectangle and in a Circle - {2}", XPoint, YPoint, confirm);
        }
        else
        {
            confirm = "No";
            Console.WriteLine("Coordinates:\nx={0}\ny={1}\nIs inside the Rectangle and in a Circle - {2}", XPoint, YPoint, confirm);
        }
   
    }
}

