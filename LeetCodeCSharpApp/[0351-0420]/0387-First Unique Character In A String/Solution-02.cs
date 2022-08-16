namespace LeetCodeCSharpApp.FirstUniqueCharacterInAString02;

public class Solution
{
    public int FirstUniqChar(string s)
    {
        return s.IndexOfAny(s.GroupBy(c => c).Where(g => g.Count() == 1).Select(g => g.Key).ToArray());
    }
}
