namespace LeetCodeCSharpApp.MyCalendarI01;

public class MyCalendar
{
    private readonly List<(int, int)> _list = new();

    public bool Book(int start, int end)
    {
        var range = (start, end);
        var index = _list.BinarySearch(range, new EventRangeComparer());

        if (index >= 0)
            return false;

        _list.Insert(~index, range);

        return true;
    }
}

public class EventRangeComparer : IComparer<(int, int)>
{
    public int Compare((int, int) x, (int, int) y)
    {
        if (x.Item2 <= y.Item1)
            return -1;

        if (y.Item2 <= x.Item1)
            return 1;

        return 0;
    }
}
