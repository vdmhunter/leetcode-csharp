namespace LeetCodeCSharpApp.FindMedianFromDataStream01;

// Your MedianFinder object will be instantiated and called as such:
// MedianFinder obj = new MedianFinder();
// obj.AddNum(num);
// double param_2 = obj.FindMedian();

public class MedianFinder
{
    private readonly List<int> _list;
    private int _count;

    public MedianFinder()
    {
        _list = new List<int>();
    }

    public void AddNum(int num)
    {
        var i = 0;

        for (; i < _count; i++)
            if (_list[i] >= num)
                break;

        _list.Insert(i, num);

        _count++;
    }

    public double FindMedian()
    {
        return _count % 2 == 0
            ? Math.Round((_list.ElementAt(_count / 2 - 1) + _list.ElementAt(_count / 2)) * 1.0D / 2, 5)
            : Convert.ToDouble(_list.ElementAt(_count / 2));
    }
}
