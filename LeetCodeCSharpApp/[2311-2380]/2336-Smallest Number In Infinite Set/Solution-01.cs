namespace LeetCodeCSharpApp.SmallestNumberInInfiniteSet01;

public class SmallestInfiniteSet
{
    private int _current;
    private readonly SortedSet<int> _set;

    public SmallestInfiniteSet()
    {
        _current = 1;
        _set = new SortedSet<int>();
    }

    public int PopSmallest()
    {
        if (_set.Count > 0)
        {
            var result = _set.Min;
            _set.Remove(result);

            return result;
        }

        _current += 1;

        return _current - 1;
    }

    public void AddBack(int num)
    {
        if (_current > num)
            _set.Add(num);
    }
}
