using System;



public class Student
{
    private string name;
    private int age;

    public Student(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public string GetName()
    {
        return name;
    }
    public int GetAge()
    {
        return age;
    }
    public void SetName(string name)
    {
        if (string.IsNullOrEmpty(name) == false) // string.IsNullOrWhiteSpace
        {
            this.name = name;
        }
        else
        {
            throw new ArgumentException("이름 값은 빈 문자열이면 안됩니다.");
        }
    }
    public void SetAge(int age)
    {
        if (age < 0)
        {
            throw new ArgumentException("나이는 양수여야 합니다.");
        }
    }
    public void PrintData()
    {
        Console.WriteLine($"이름 : {name}\n나이 : {age}");
    }

}

