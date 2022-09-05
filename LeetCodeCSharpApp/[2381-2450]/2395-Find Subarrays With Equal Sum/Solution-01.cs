namespace LeetCodeCSharpApp.FindSubarraysWithEqualSum01;

public class Solution
{
    public bool FindSubarrays(int[] nums)
    {
        var hs = new HashSet<int> { nums[0] + nums[1] };

        for (var i = 1; i < nums.Length - 1; i++)
        {
            var sum = nums[i] + nums[i + 1];
            
            if (hs.Contains(sum))
                return true;
            
            hs.Add(sum);
        }

        return false;
    }
}
