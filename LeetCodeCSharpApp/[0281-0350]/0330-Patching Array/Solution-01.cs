namespace LeetCodeCSharpApp.PatchingArray01;

public class Solution
{
    public int MinPatches(int[] nums, int n)
    {
        var miss = 1L;
        var added = 0;
        var i = 0;

        while (miss <= n)
        {
            if (i < nums.Length && nums[i] <= miss)
            {
                miss += nums[i];
                i++;
            }
            else
            {
                miss += miss;
                added++;
            }
        }

        return added;
    }
}
