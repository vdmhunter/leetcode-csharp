namespace LeetCodeCSharpApp.FindTheDifferenceOfTwoArrays01;

public class Solution
{
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
    {
        return new IList<int>[]
        {
            nums1.Except(nums2).ToArray(),
            nums2.Except(nums1).ToArray(),
        };
    }
}
