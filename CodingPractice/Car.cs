using System;

class Car
{
    private string _color;

    public Car(string color)
    {
        _color = color;
        Console.WriteLine($"{_color}색 자동차 조립");
    }

    public void Drive()
    {
        Console.WriteLine($"{_color}색 자동차가 달림");
    }

    ~Car()
    {
        Console.WriteLine($"{_color}색 자동차 폐차");
    }
}
