using System;

class Time
{
    int hour = 0;
    int minute = 0;
    int second = 0;
    public Time(int a)
    {
        hour = a;
    }
    public Time(int a, int b)
    {
        hour = a;
        minute = b;
    }
    public Time(int a, int b, int c)
    {
        hour = a;
        minute = b;
        second = c;
    }
    public void ShowTime()
    {
        Console.WriteLine($"{hour}시{minute}분{second}초");
    }
    public void ShowTimeInSeconds()
    {
        Console.WriteLine($"{hour*3600 + minute*60 + second}초");
    }
}

