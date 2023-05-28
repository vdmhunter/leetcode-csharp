namespace LeetCodeCSharpApp.RemoveTrailingZerosFromAString01;

public class Solution
{
    public string RemoveTrailingZeros(string num)
    {
        var i = num.Length - 1;

        while (i >= 0 && num[i] == '0')
            i--;

        return num[..(i + 1)];
    }
}
