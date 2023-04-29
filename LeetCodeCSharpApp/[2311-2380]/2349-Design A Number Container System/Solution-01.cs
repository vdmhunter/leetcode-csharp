namespace LeetCodeCSharpApp.DesignANumberContainerSystem01;

public class NumberContainers
{
    private readonly Dictionary<int, int> _indexNumberMap;
    private readonly Dictionary<int, SortedSet<int>> _numberIndexMap;

    public NumberContainers()
    {
        _indexNumberMap = new Dictionary<int, int>();
        _numberIndexMap = new Dictionary<int, SortedSet<int>>();
    }

    public void Change(int index, int number)
    {
        if (_indexNumberMap.ContainsKey(index))
        {
            var currNum = _indexNumberMap[index];
            _numberIndexMap[currNum].Remove(index);
            if (_numberIndexMap[currNum].Count == 0)
                _numberIndexMap.Remove(currNum);

            _indexNumberMap[index] = number;
        }
        else
        {
            _indexNumberMap.Add(index, number);
        }

        if (_numberIndexMap.TryGetValue(number, out var value))
            value.Add(index);
        else
            _numberIndexMap.Add(number, new SortedSet<int> { index });
    }

    public int Find(int number)
    {
        if (_numberIndexMap.TryGetValue(number, out var value))
            return value.Min;

        return -1;
    }
}
