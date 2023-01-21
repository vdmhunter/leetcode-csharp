namespace LeetCodeCSharpApp.ThreeSumClosest01;

public class Solution
{
    public int ThreeSumClosest(int[] nums, int target)
    {
        var result = nums[0] + nums[1] + nums[2];
        Array.Sort(nums);
        var n = nums.Length;
        
        if(result > target)
            return result;

        for (var i = 0; i < n - 2; i++)
        {
            var low = i + 1;
            var high = n - 1;

            while (low < high)
            {
                result = nums[i] + nums[low] + nums[high];

                if (result == target)
                    return target;

                MovePointers(ref low, ref high);
            }
        }
        
        void MovePointers(ref int l, ref int h)
        {
            if (result < target)
                l++;
            else
                h--;
        }

        return result;
    }
}
