namespace LeetCodeCSharpApp.LongestConsecutiveSequence01;

public class Solution
{
    public int LongestConsecutive(int[] nums)
    {
        var hs = new HashSet<int>(nums);
        var best = 0;

        foreach (var n in nums)
        {
            if (hs.Contains(n - 1))
                continue;
            
            var m = n + 1;
                
            while(hs.Contains(m))
                m++;
                
            best = Math.Max(best, m - n);
        }
        
        return best;
    }
}
