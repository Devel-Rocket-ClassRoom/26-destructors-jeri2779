using System;

class Character
{
    private string _name;

    // 생성자
    public Character(string name)
    {
        _name = name;
        Console.WriteLine($"[1] {_name} 생성");
    }

    // 메서드
    public void Attack()
    {
        Console.WriteLine($"[2] {_name} 공격");
    }

    // 소멸자
    ~Character()
    {
        Console.WriteLine($"[3] {_name} 소멸");
    }
}
