// ReSharper disable InconsistentNaming
// ReSharper disable MemberCanBePrivate.Global

namespace LeetCodeCSharpApp.LFUCache01;

public class LFUCache
{
    private int _minFrequency;
    private readonly int _capacity;
    private readonly Dictionary<int, List<int>> _frequencies;
    private readonly Dictionary<int, (int Value, int Frequency)> _cache;

    public LFUCache(int capacity)
    {
        _capacity = capacity;
        _minFrequency = 0;
        _cache = new Dictionary<int, (int, int)>();
        _frequencies = new Dictionary<int, List<int>>();
    }

    public int Get(int key)
    {
        if (!_cache.ContainsKey(key))
            return -1;

        var (value, pairFrequency) = _cache[key];
        _frequencies[pairFrequency].Remove(key);

        if (_frequencies[pairFrequency].Count == 0 && _minFrequency == pairFrequency)
            ++_minFrequency;

        Insert(key, pairFrequency + 1, value);

        return value;
    }

    public void Put(int key, int value)
    {
        if (_capacity <= 0)
            return;

        if (_cache.ContainsKey(key))
        {
            _cache[key] = (value, _cache[key].Frequency);
            Get(key);

            return;
        }

        if (_capacity == _cache.Count)
        {
            _cache.Remove(_frequencies[_minFrequency].First());
            _frequencies[_minFrequency].RemoveAt(0);
        }

        _minFrequency = 1;
        Insert(key, 1, value);
    }


    private void Insert(int key, int frequency, int value)
    {
        if (!_frequencies.ContainsKey(frequency))
            _frequencies[frequency] = new List<int>();

        _frequencies[frequency].Add(key);
        _cache[key] = (value, frequency);
    }
}
