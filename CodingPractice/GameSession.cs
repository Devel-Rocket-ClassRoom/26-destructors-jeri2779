using System;

class GameSession
{
    private string _playerName;
    private DateTime _startTime;

    public GameSession(string playerName)
    {
        _playerName = playerName;
        _startTime = DateTime.Now;
        Console.WriteLine($"[{_startTime:HH:mm:ss}] {_playerName} 게임 시작");
    }

    public void Play()
    {
        Console.WriteLine($"{_playerName} 플레이 중...");
    }

    ~GameSession()
    {
        DateTime endTime = DateTime.Now;
        TimeSpan duration = endTime - _startTime;
        Console.WriteLine($"[{endTime:HH:mm:ss}] {_playerName} 게임 종료");
        Console.WriteLine($"플레이 시간: {duration.TotalSeconds:F1}초");
    }
}
