namespace LeetCodeCSharpApp.MyCalendarIII03;

// Your MyCalendarThree object will be instantiated and called as such:
// MyCalendarThree obj = new MyCalendarThree();
// int param_1 = obj.Book(start,end);

/// <summary>
/// Balanced Tree
/// </summary>
public class MyCalendarThree
{
    private readonly SortedDictionary<int, int> _starts;
    private int _result;

    public MyCalendarThree()
    {
        _starts = new SortedDictionary<int, int> { [0] = 0 };
        _result = 0;
    }

    public int Book(int start, int end)
    {
        Split(start);
        Split(end);

        var intervals = _starts
            .Where(kvp => kvp.Key >= start && kvp.Key < end)
            .ToDictionary(k => k.Key, v => v.Value);

        foreach (var (key, val) in intervals)
        {
            _starts[key] += 1;
            _result = Math.Max(_result, val + 1);
        }

        return _result;
    }

    private void Split(int x)
    {
        var prev = _starts.TakeWhile(kvp => kvp.Key <= x).Last().Key;
        var next = _starts.Reverse().TakeWhile(kvp => kvp.Key >= x).Select(kvp => kvp.Key).Cast<int?>().LastOrDefault();

        if (next == x)
            return;

        _starts[x] = _starts[prev];
    }
}
