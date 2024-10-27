namespace LeetCodeCSharpApp.FindTheClosestPalindrome01;

public class Solution
{
    public string NearestPalindromic(string n)
    {
        long num = long.Parse(n);
        var candidates = new HashSet<long>
        {
            (long)Math.Pow(10, n.Length) - 1,
            (long)Math.Pow(10, n.Length - 1) - 1
        };

        string firstHalf = n[..((n.Length + 1) / 2)];
        long firstHalfNum = long.Parse(firstHalf);

        for (int i = -1; i <= 1; i++)
        {
            long candidateHalf = firstHalfNum + i;
            var candidateStr = candidateHalf.ToString();
            string palindrome = candidateStr + new string(candidateStr.Take(n.Length / 2).Reverse().ToArray());
            candidates.Add(long.Parse(palindrome));
        }

        var closest = long.MaxValue;

        foreach (long candidate in candidates)
        {
            if (candidate == num)
                continue;

            long diff = Math.Abs(candidate - num);

            if (diff < Math.Abs(closest - num) || (diff == Math.Abs(closest - num) && candidate < closest))
                closest = candidate;
        }

        return closest.ToString();
    }
}
