using System;

class TestObject
{
    private int _id;

    public TestObject(int id)
    {
        _id = id;
        Console.WriteLine($"객체 {_id} 생성");
    }

    ~TestObject()
    {
        Console.WriteLine($"객체 {_id} 소멸");
    }
}
