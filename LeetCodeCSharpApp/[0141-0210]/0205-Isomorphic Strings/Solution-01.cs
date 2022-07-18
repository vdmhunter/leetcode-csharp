namespace LeetCodeCSharpApp.IsomorphicStrings01;

public class Solution
{
    public bool IsIsomorphic(string s, string t)
    {
        return s.Distinct().Count() == t.Distinct().Count() && t.Distinct().Count() == s.Zip(t).Distinct().Count();
    }
}
