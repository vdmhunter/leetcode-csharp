namespace LeetCodeCSharpApp.FrequencyTracker;

public class FrequencyTracker
{
    private readonly Dictionary<int, HashSet<int>> _freqToNums;
    private readonly Dictionary<int, int> _numToFreq;

    public FrequencyTracker()
    {
        _numToFreq = new Dictionary<int, int>();
        _freqToNums = new Dictionary<int, HashSet<int>>();
    }

    public void Add(int number)
    {
        _numToFreq.TryAdd(number, 0);

        var oldFreq = _numToFreq[number];
        var newFreq = oldFreq + 1;
        _numToFreq[number] = newFreq;

        if (!_freqToNums.ContainsKey(newFreq))
            _freqToNums[newFreq] = new HashSet<int>();

        _freqToNums[newFreq].Add(number);

        if (oldFreq <= 0)
            return;

        _freqToNums[oldFreq].Remove(number);

        if (_freqToNums[oldFreq].Count == 0)
            _freqToNums.Remove(oldFreq);
    }

    public void DeleteOne(int number)
    {
        if (!_numToFreq.ContainsKey(number))
            return;

        var oldFreq = _numToFreq[number];
        var newFreq = oldFreq - 1;

        if (newFreq == 0)
            _numToFreq.Remove(number);
        else
        {
            _numToFreq[number] = newFreq;

            if (!_freqToNums.ContainsKey(newFreq))
                _freqToNums[newFreq] = new HashSet<int>();

            _freqToNums[newFreq].Add(number);
        }

        _freqToNums[oldFreq].Remove(number);

        if (_freqToNums[oldFreq].Count == 0)
            _freqToNums.Remove(oldFreq);
    }

    public bool HasFrequency(int frequency)
    {
        return _freqToNums.ContainsKey(frequency);
    }
}
