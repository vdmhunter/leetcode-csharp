namespace LeetCodeCSharpApp.NumberOfBeautifulIntegersInTheRange02;

public class Solution
{
    private Dictionary<(int, int, int, int), int> _dp = null!;
    private int _k;
    private string _upperLimitStr = null!;

    public int NumberOfBeautifulIntegers(int low, int high, int k)
    {
        _dp = new Dictionary<(int, int, int, int), int>();
        _k = k;
        _upperLimitStr = high.ToString();
        var h = Dp(0, 0, 0, 0);
        _dp.Clear();
        _upperLimitStr = (low - 1).ToString();
        var l = Dp(0, 0, 0, 0);

        return h - l;
    }

    private int Dp(int i, int flag, int rest, int oddEven)
    {
        if (i == _upperLimitStr.Length)
            return flag >= 0 && rest == 0 && oddEven == 0 ? 1 : 0;

        if (_dp.TryGetValue((i, flag, rest, oddEven), out var value))
            return value;

        var result = i > 0 && i < _upperLimitStr.Length && rest == 0 && oddEven == 0 ? 1 : 0;

        for (var j = i == 0 ? 1 : 0; j < 10; j++)
        {
            var newFlag = GetNewFlag(flag, i, j);
            result += GetResultForDigit(i, j, newFlag, rest, oddEven);
        }

        _dp[(i, flag, rest, oddEven)] = result;

        return result;
    }

    private int GetNewFlag(int flag, int i, int j)
    {
        if (flag != 0)
            return flag;

        if (j > _upperLimitStr[i] - '0')
            return -1;

        return j < _upperLimitStr[i] - '0' ? 1 : flag;
    }

    private int GetResultForDigit(int i, int j, int newFlag, int rest, int oddEven)
    {
        return j % 2 == 1
            ? Dp(i + 1, newFlag, (rest * 10 + j) % _k, oddEven + 1)
            : Dp(i + 1, newFlag, (rest * 10 + j) % _k, oddEven - 1);
    }
}
