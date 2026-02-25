using System;
using System.Threading;


Seat s1 = new Seat("김민수");
Seat s2 = new Seat("이지영");
Seat s3 = new Seat("박서준");

Console.WriteLine();
Seat.ShowStats();
Console.WriteLine();

s1 = null;
s2 = null;
s3 = null;

GC.Collect();
GC.WaitForPendingFinalizers();

Console.WriteLine();
Seat.ShowStats();
// README.md를 읽고 코드를 작성하세요.
Console.WriteLine("코드를 작성하세요.");
class Seat
{
    private static int s_idCount = 0;
    private static int s_studentCount = 0;

    private int _id;
    private string _name;

    public Seat(string name)
    {
        s_idCount++;
        s_studentCount++;
        _id = s_idCount;
        _name = name;
        Console.WriteLine($"좌석 {_id}번 착석: {name}, ");
         
    }

    public void Study(string name)
    {
        Console.WriteLine($"{name}이(가) 좌석 {_id}번에서 공부 중...");
    }

    ~Seat()
    {
        s_studentCount--;
        Console.WriteLine($"몬스터 소멸: {_name} (ID: {_id})");
        Console.WriteLine($"  - 현재 생존: {s_studentCount}마리");
    }

    public static void ShowStats()
    {
        Console.WriteLine($"총 이용: {s_studentCount}, 현재 착석: {s_studentCount}");
    }
}


