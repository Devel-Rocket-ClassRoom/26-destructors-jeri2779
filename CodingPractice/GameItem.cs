using System;

class GameItem
{
    private static int s_nextId = 1;
    private int _id;
    private string _name;
    private int _price;

    public GameItem(string name, int price)
    {
        _id = s_nextId++;
        _name = name;
        _price = price;
        Console.WriteLine($"[생성] 아이템 #{_id}: {_name} ({_price}골드)");
    }

    public void Use()
    {
        Console.WriteLine($"[사용] {_name} 아이템을 사용함");
    }

    ~GameItem()
    {
        Console.WriteLine($"[삭제] 아이템 #{_id}: {_name} 인벤토리에서 제거됨");
    }
}