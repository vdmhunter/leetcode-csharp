namespace LeetCodeCSharpApp.MinimumNumberOfStepsToMakeTwoStringsAnagram01;

public class Solution
{
    public int MinSteps(string s, string t)
    {
        var diff = new int[26];

        foreach (var ch in s)
            diff[ch - 'a']++;

        foreach (var ch in t)
            diff[ch - 'a']--;

        return diff.Sum(x => x > 0 ? x : 0);
    }
}
