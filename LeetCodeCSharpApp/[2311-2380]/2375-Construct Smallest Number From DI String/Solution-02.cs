namespace LeetCodeCSharpApp.ConstructSmallestNumberFromDIString02;

public class Solution
{
    public string SmallestNumber(string pattern)
    {
        var n = pattern.Length + 1;
        var result = new char[n];

        for (var i = 0; i < n; i++)
            result[i] = (char)('1' + i);

        var lastI = 0;

        for (var i = 0; i < n - 1; i++)
            if (pattern[i] == 'I')
            {
                Array.Reverse(result, lastI, i + 1 - lastI);
                lastI = i + 1;
            }

        if (pattern.Last() == 'D')
            Array.Reverse(result, lastI, n - lastI);

        return new string(result);
    }
}
