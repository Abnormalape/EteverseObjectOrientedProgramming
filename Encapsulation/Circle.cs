using System;

class Circle : Point
{
    private float radius;
    private float area;
    private float roundlength;
    public Circle(float a)
    {
        radius = a;
    }
    public Circle(float a, float b, float c)
    {
        x = a;
        y = b;
        radius = c;
    }

    public void GetArea()
    {
        area = radius * radius * MathF.PI;
    }
    public void GetRoundLength()
    {
        roundlength = radius * 2 * MathF.PI;
    }

    public void printradius()
    {
        System.Console.WriteLine($"원의 반지름은 : {radius}");
    }
    public void PrintArea()
    {
        System.Console.WriteLine($"원의 넓이는 : {area}");
    }
    public void PrintRound()
    {
        System.Console.WriteLine($"원의 둘레는 : {roundlength}");
    }
    public void ShowData()
    {
        Console.WriteLine($"중심좌표 : [{x},{y}]");
        printradius();
        PrintArea();
    }
}

