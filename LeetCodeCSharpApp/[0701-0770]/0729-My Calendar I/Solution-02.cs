namespace LeetCodeCSharpApp.MyCalendarI02;

public class MyCalendar
{
    private readonly List<(int start, int end)> _list;

    public MyCalendar()
    {
        _list = new List<(int, int)>();
    }

    public bool Book(int start, int end)
    {
        foreach (var p in _list)
        {
            if (p.start <= start && p.end > start)
                return false;
            
            if (start <= p.start && end > p.start)
                return false;
        }

        _list.Add((start, end));
        
        return true;
    }
}
