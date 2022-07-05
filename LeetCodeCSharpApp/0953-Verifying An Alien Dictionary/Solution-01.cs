namespace LeetCodeCSharpApp.VerifyingAnAlienDictionary01;

public class Solution
{
    private readonly int[] _mapping = new int[26];

    public bool IsAlienSorted(string[] words, string order)
    {
        for (var i = 0; i < order.Length; i++)
            _mapping[order[i] - 'a'] = i;
        
        for (var i = 1; i < words.Length; i++)
            if (Bigger(words[i - 1], words[i]))
                return false;
        
        return true;
    }

    private bool Bigger(string s1, string s2)
    {
        int n = s1.Length, m = s2.Length;
        
        for (var i = 0; i < n && i < m; ++i)
            if (s1[i] != s2[i])
                return _mapping[s1[i] - 'a'] > _mapping[s2[i] - 'a'];
        
        return n > m;
    }
}
