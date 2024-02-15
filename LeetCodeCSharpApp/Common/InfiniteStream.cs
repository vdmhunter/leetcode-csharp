// ReSharper disable ClassNeverInstantiated.Global

namespace LeetCodeCSharpApp.Common;

public class InfiniteStream(int[] bits)
{
    private int _currentIndex;

    public int Next()
    {
        if (_currentIndex >= bits.Length)
            return 0;

        var value = bits[_currentIndex];
        _currentIndex++;

        return value;
    }
}
