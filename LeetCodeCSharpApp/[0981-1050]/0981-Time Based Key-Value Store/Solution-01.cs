namespace LeetCodeCSharpApp.TimeBasedKeyValueStore01;

public class TimeMap
{
    private readonly Dictionary<string, List<KeyValuePair<int, string>>> _dictionary = new();

    public void Set(string key, string value, int timestamp)
    {
        if (_dictionary.ContainsKey(key))
            _dictionary[key].Add(new KeyValuePair<int, string>(timestamp, value));
        else
            _dictionary[key] = new List<KeyValuePair<int, string>> { new(timestamp, value) };
    }

    public string Get(string key, int timestamp)
    {
        if (!_dictionary.ContainsKey(key))
            return string.Empty;

        var x = _dictionary[key].LastOrDefault(x => x.Key <= timestamp);
        var result = x.Value;

        return result == null! ? string.Empty : result;
    }
}
