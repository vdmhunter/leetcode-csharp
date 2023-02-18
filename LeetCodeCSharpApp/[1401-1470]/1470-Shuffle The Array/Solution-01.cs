namespace LeetCodeCSharpApp.ShuffleTheArray01;

public class Solution
{
    public int[] Shuffle(int[] nums, int n)
    {
        var result = new int[nums.Length];
        
        for (var i = 0; i < n; i++)
        {
            result[2 * i] = nums[i];
            result[2 * i + 1] = nums[i + n];
        }
        
        return result;
    }
}
