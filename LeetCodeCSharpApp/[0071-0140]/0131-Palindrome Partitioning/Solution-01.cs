namespace LeetCodeCSharpApp.PalindromePartitioning01;

public class Solution
{
    public IList<IList<string>> Partition(string s)
    {
        var partitions = new List<IList<string>>();
        Backtrack(partitions, new List<string>(), s, 0);

        return partitions;
    }

    private static void Backtrack(IList<IList<string>> partitions, IList<string> currentPartition, string s, int start)
    {
        if (start == s.Length)
        {
            partitions.Add(new List<string>(currentPartition));

            return;
        }

        for (var i = start; i < s.Length; i++)
            if (IsPalindrome(s, start, i))
            {
                currentPartition.Add(s.Substring(start, i - start + 1));
                Backtrack(partitions, currentPartition, s, i + 1);
                currentPartition.RemoveAt(currentPartition.Count - 1);
            }
    }

    private static bool IsPalindrome(string s, int start, int end)
    {
        while (start < end)
            if (s[start++] != s[end--])
                return false;

        return true;
    }
}
