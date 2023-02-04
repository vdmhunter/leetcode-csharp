namespace LeetCodeCSharpApp.MaximumNumberOfIntegersToChooseFromARangeI01;

public class Solution
{
    public int MaxCount(int[] banned, int n, int maxSum)
    {
        var bannedSet = new HashSet<int>(banned);
        var count = 0;
        
        for (var i = 1; i <= n && i <= maxSum; i++)
            if (!bannedSet.Contains(i))
            {
                count++;
                maxSum -= i;
            }

        return count;
    }
}
