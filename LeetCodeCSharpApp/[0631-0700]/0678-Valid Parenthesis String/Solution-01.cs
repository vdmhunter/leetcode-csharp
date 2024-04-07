namespace LeetCodeCSharpApp.ValidParenthesisString01;

public class Solution
{
    public bool CheckValidString(string s)
    {
        int cMin = 0, cMax = 0;

        foreach (char ch in s)
        {
            if (ch == '(')
            {
                cMax++;
                cMin++;
            }
            else if (ch == ')')
            {
                cMax--;
                cMin = Math.Max(cMin - 1, 0);
            }
            else
            {
                cMax++;
                cMin = Math.Max(cMin - 1, 0);
            }

            if (cMax < 0)
                return false;
        }

        return cMin == 0;
    }
}
