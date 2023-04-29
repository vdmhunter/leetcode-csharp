using LeetCodeCSharpApp.Common;

namespace LeetCodeCSharpApp.ConvertSortedArrayToBinarySearchTree01;

public class Solution
{
    public TreeNode SortedArrayToBST(int[] nums)
    {
        return ToBst(0, nums.Length - 1);

        TreeNode ToBst(int left, int right)
        {
            if (left > right)
                return null!;

            var middle = left + (right - left) / 2;

            return new TreeNode(nums[middle])
            {
                left = ToBst(left, middle - 1),
                right = ToBst(middle + 1, right)
            };
        }
    }
}
