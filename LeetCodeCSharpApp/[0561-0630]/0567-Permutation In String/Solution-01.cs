namespace LeetCodeCSharpApp.PermutationInString01;

public class Solution
{
    public bool CheckInclusion(string s1, string s2)
    {
        if (s2.Length < s1.Length)
            return false;

        var hits = 0;
        var counts = new int[26];

        foreach (var c in s1)
            counts[c - 'a']++;

        for (int i = 0, j = 0; i < s2.Length; i++)
        {
            if (counts[s2[i] - 'a']-- > 0 && ++hits == s1.Length)
                return true;

            if (i >= s1.Length - 1 && counts[s2[j++] - 'a']++ >= 0)
                hits--;
        }

        return false;
    }
}
