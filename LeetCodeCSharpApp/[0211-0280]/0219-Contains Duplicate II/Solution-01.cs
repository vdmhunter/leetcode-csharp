namespace LeetCodeCSharpApp.ContainsDuplicateII01;

public class Solution
{
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        if (k == 0)
            return false;

        var map = new Dictionary<int, int>();
        
        for (var i = 0; i < nums.Length; i++)
        {
            var num = nums[i];
            
            if (map.ContainsKey(num) && i - map[num] <= k)
                return true;
            
            map[num] = i;
        }

        return false;
    }
}
