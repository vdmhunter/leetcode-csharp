namespace LeetCodeCSharpApp.FindWordsThatCanBeFormedByCharacters01;

public class Solution
{
    public int CountCharacters(string[] words, string chars)
    {
        var counts = new int[26];

        foreach (var c in chars)
            counts[c - 'a']++;

        return words.Where(s => CanForm(s, counts)).Sum(s => s.Length);
    }

    private static bool CanForm(string word, int[] counts)
    {
        var c = new int[26];

        foreach (var x in word.Select(ch => ch - 'a'))
        {
            c[x]++;

            if (c[x] > counts[x])
                return false;
        }

        return true;
    }
}
