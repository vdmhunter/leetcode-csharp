namespace LeetCodeCSharpApp.FrequencyTracker02;

public class FrequencyTracker
{
    private readonly int[] _cnt = new int[100001];
    private readonly int[] _freq = new int[100001];

    public void Add(int number)
    {
        --_freq[_cnt[number]];
        ++_freq[++_cnt[number]];
    }

    public void DeleteOne(int number)
    {
        if (_cnt[number] <= 0)
            return;

        --_freq[_cnt[number]];
        ++_freq[--_cnt[number]];
    }

    public bool HasFrequency(int frequency)
    {
        return _freq[frequency] > 0;
    }
}
