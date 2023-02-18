namespace LeetCodeCSharpApp.ShuffleTheArray02;

public class Solution
{
    public int[] Shuffle(int[] nums, int n)
    {
        var len = nums.Length;

        // to store the pair of numbers in right half of the original array
        for (var i = n; i < len; i++)
            nums[i] = nums[i] * 1024 + nums[i - n];

        var index = 0;
        
        // to retrieve values from the pair of numbers and placing those retrieved value at their desired position
        for (var i = n; i < len; i++, index += 2)
        {
            nums[index] = nums[i] % 1024;
            nums[index + 1] = nums[i] / 1024;
        }

        return nums;
    }
}
