namespace LeetCodeCSharpApp.TwoSum02;

/// <summary>
/// Dictionary
/// </summary>
public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var result = new int[2];
        var map = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            if (map.ContainsKey(target - nums[i]))
            {
                result[0] = map[target - nums[i]];
                result[1] = i;

                return result;
            }

            map[nums[i]] = i;
        }

        return null!;
    }
}
