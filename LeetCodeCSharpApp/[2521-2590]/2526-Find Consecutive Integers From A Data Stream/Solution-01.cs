// ReSharper disable IdentifierTypo

namespace LeetCodeCSharpApp.FindConsecutiveIntegersFromADataStream01;

public class DataStream
{
    private int _count;
    private int _countOfValue;
    private readonly int _value;
    private readonly int _k;

    public DataStream(int value, int k)
    {
        _count = 0;
        _countOfValue = 0;
        _value = value;
        _k = k;
    }

    public bool Consec(int num)
    {
        _count++;

        if (num == _value)
            _countOfValue++;
        else
            _countOfValue = 0;

        if (_count < _k)
            return false;

        return _countOfValue >= _k;
    }
}
