namespace LeetCodeCSharpApp.BackspaceStringCompare01;

public class Solution
{
    public bool BackspaceCompare(string s, string t)
    {
        return GetString(s).Equals(GetString(t));
    }

    private string GetString(string str)
    {
        int n = str.Length, count = 0;
        var result = string.Empty;
        
        for (var i = n - 1; i >= 0; i--)
        {
            var ch = str[i];

            if (ch == '#')
                count++;
            else
            {
                if (count > 0)
                    count--;
                else
                    result += ch;
            }
        }

        return result;
    }
}
