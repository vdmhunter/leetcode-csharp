namespace LeetCodeCSharpApp.ValidAnagram02;

public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        var alphabet = new int[26];
        
        foreach (var i in s)
            alphabet[i - 'a']++;

        foreach (var i in t)
            alphabet[i - 'a']--;

        return alphabet.All(i => i == 0);
    }
}
