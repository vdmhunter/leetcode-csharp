namespace LeetCodeCSharpApp.MyCalendarIII02;

// Your MyCalendarThree object will be instantiated and called as such:
// MyCalendarThree obj = new MyCalendarThree();
// int param_1 = obj.Book(start,end);

/// <summary>
/// Segment Tree
/// </summary>
public class MyCalendarThree
{
    private readonly Dictionary<int, int> _values;
    private readonly Dictionary<int, int> _lazy;

    public MyCalendarThree()
    {
        _values = new Dictionary<int, int>();
        _lazy = new Dictionary<int, int>();
    }

    public int Book(int start, int end)
    {
        Update(start, end - 1, 0, 1000000000, 1);

        return _values.GetValueOrDefault(1, 0);
    }

    private void Update(int start, int end, int left, int right, int idx)
    {
        if (start > right || end < left)
            return;

        if (start <= left && right <= end)
        {
            _values[idx] = _values.GetValueOrDefault(idx, 0) + 1;
            _lazy[idx] = _lazy.GetValueOrDefault(idx, 0) + 1;
        }
        else
        {
            var mid = (left + right) / 2;

            Update(start, end, left, mid, idx * 2);
            Update(start, end, mid + 1, right, idx * 2 + 1);

            _values[idx] = _lazy.GetValueOrDefault(idx, 0) +
                           Math.Max(_values.GetValueOrDefault(idx * 2, 0), _values.GetValueOrDefault(idx * 2 + 1, 0));
        }
    }
}
