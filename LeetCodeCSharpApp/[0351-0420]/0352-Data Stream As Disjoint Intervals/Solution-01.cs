namespace LeetCodeCSharpApp.DataStreamAsDisjointIntervals01;

public class SummaryRanges
{
    private readonly SortedSet<int> _values;

    public SummaryRanges()
    {
        _values = new SortedSet<int>();
    }

    public void AddNum(int value) => _values.Add(value);

    public int[][] GetIntervals()
    {
        if (_values.Count == 0)
            return Array.Empty<int[]>();

        var intervals = new List<int[]>();
        int left = -1, right = -1;

        foreach (var value in _values)
        {
            if (left < 0)
                left = right = value;
            else if (value == right + 1)
                right = value;
            else
            {
                intervals.Add(new[] { left, right });
                left = right = value;
            }
        }

        intervals.Add(new[] { left, right });

        return intervals.ToArray();
    }
}
