namespace LeetCodeCSharpApp.MyCalendarIII01;

// Your MyCalendarThree object will be instantiated and called as such:
// MyCalendarThree obj = new MyCalendarThree();
// int param_1 = obj.Book(start,end);

/// <summary>
/// Sweep-line Algorithm
/// </summary>
public class MyCalendarThree
{
    private readonly SortedList<int, int> _diff;

    public MyCalendarThree()
    {
        _diff = new SortedList<int, int>();
    }

    public int Book(int start, int end)
    {
        _diff[start] = _diff.GetValueOrDefault(start, 0) + 1;
        _diff[end] = _diff.GetValueOrDefault(end, 0) - 1;
        
        int result = 0, cur = 0;

        foreach (var delta in _diff.Values)
        {
            cur += delta;
            result = Math.Max(result, cur);
        }

        return result;
    }
}
