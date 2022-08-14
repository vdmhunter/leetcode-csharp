namespace LeetCodeCSharpApp.ConstructSmallestNumberFromDIString01;

public class Solution
{
    private string _result = string.Empty;
    private int _patternLength;
    private readonly Stack<int> _stack = new();
    private int _number;
    
    public string SmallestNumber(string pattern)
    {
        _patternLength = pattern.Length;

        for (var i = 0; i < _patternLength; i++)
            PatternHandle(pattern, i);

        if (_stack.Count > 0 || pattern[_patternLength - 1] == 'I')
            _result += (_number + 1).ToString();

        while (_stack.Count > 0)
            _result += _stack.Pop().ToString();
        
        return _result;
    }

    private void PatternHandle(string pattern, int i)
    {
        _number = i + 1;

        if (pattern[i] == 'D')
            _stack.Push(_number);
        else
        {
            _result += _number.ToString();

            while (_stack.Count > 0)
                _result += _stack.Pop().ToString();
        }
    }
}
