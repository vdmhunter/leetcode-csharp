namespace LeetCodeCSharpApp.FindAllAnagramsInAString02;

public class Solution
{
    public IList<int> FindAnagrams(string s, string p)
    {
        var result = new List<int>();

        var sm = new int[26];
        var pm = new int[26];
        int i = 0, j = 0;

        if (p.Length > s.Length)
            return result;

        for (; i < p.Length; ++i)
        {
            pm[p[i] - 'a']++;
            sm[s[i] - 'a']++;
        }

        for (; i < s.Length; ++i)
        {
            if (sm.SequenceEqual(pm))
                result.Add(j);

            sm[s[i] - 'a']++;
            sm[s[j] - 'a']--;
            j++;
        }

        if (sm.SequenceEqual(pm))
            result.Add(j);

        return result;
    }
}
