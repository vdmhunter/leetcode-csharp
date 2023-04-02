namespace LeetCodeCSharpApp.FindTheLongestBalancedSubstringOfABinaryString02;

public class Solution
{
    public int FindTheLongestBalancedSubstring(string s)
    {
        var tmp = "01";

        while (s.Contains(tmp))
            tmp = "0" + tmp + "1";

        return tmp.Length - 2;
    }
}
