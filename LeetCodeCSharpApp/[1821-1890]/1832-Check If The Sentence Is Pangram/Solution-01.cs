namespace LeetCodeCSharpApp.CheckIfTheSentenceIsPangram;

public class Solution
{
    public bool CheckIfPangram(string sentence)
    {
        var abc = new bool[26];

        foreach (var c in sentence)
            abc[c - 'a'] = true;

        return abc.All(i => i);
    }
}
