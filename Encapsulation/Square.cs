using System;

class Square
{
    private int edge;
    private float area;
    private float roundlength;
    public Square(int a)
    {
        edge = a;
    }
    public void GetArea()
    {
        area = edge*edge;
    }
    public void GetRoundLength()
    {
        roundlength = 4 * edge;
    }

    public void printedge()
    {
        System.Console.WriteLine($"사각형의 한변은 : {edge}");
    }
    public void PrintArea()
    {
        System.Console.WriteLine($"사각형의 넓이는 : {area}");
    }
    public void PrintRound()
    {
        System.Console.WriteLine($"사각형의 둘레는 : {roundlength}");
    }
}

