namespace LeetCodeCSharpApp.RansomNote01;

public class Solution
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        var freq = new int[26];

        foreach (var letter in magazine)
            freq[letter - 'a']++;

        return ransomNote.All(letter => freq[letter - 'a']-- > 0);
    }
}
