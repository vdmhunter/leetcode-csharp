namespace LeetCodeCSharpApp.MaximumNestingDepthOfTheParentheses01;

public class Solution
{
    public int MaxDepth(string s)
    {
        int result = 0, cur = 0;

        foreach (char ch in s)
        {
            if (ch == '(')
                result = Math.Max(result, ++cur);
            if (ch == ')')
                cur--;
        }

        return result;
    }
}
