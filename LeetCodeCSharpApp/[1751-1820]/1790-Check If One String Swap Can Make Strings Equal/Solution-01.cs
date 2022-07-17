namespace LeetCodeCSharpApp.CheckIfOneStringSwapCanMakeStringsEqual01;

public class Solution
{
    public bool AreAlmostEqual(string s1, string s2)
    {
        if (s1.Length != s2.Length)
            return false;

        int f = -1, s = -1;
        
        for (var i = 0; i < s1.Length; i++)
            if (s1[i] != s2[i])
            {
                if (f == -1)
                    f = i; // first mismatch
                else if (s == -1)
                    s = i; // second mismatch
                else
                    return false; // more than two mismatch
            }

        if (f == -1 && s == -1)
            return true; // equal strings
        
        if ((f == -1) ^ (s == -1))
            return false; // only 1 mismatch

        return s1[s] == s2[f] && s1[f] == s2[s]; // mismatches are mirror images
    }
}
