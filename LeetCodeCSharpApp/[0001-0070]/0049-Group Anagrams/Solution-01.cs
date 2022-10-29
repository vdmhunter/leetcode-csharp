// ReSharper disable IdentifierTypo

namespace LeetCodeCSharpApp.GroupAnagrams01;

public class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        if (strs == null || strs.Length == 0)
            return new List<IList<string>>();

        var map = new Dictionary<string, List<string>>();

        foreach (var s in strs)
        {
            var ca = new char[26];

            foreach (var c in s.ToCharArray())
                ca[c - 'a']++;

            var keyStr = new string(ca);

            if (!map.ContainsKey(keyStr))
                map[keyStr] = new List<string>();

            map[keyStr].Add(s);
        }

        return new List<IList<string>>(map.Values);
    }
}
