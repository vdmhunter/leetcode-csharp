namespace LeetCodeCSharpApp.FormSmallestNumberFromTwoDigitArrays01;

public class Solution
{
    public int MinNumber(int[] nums1, int[] nums2)
    {
        var l1 = new List<int>(nums1);
        var l2 = new List<int>(nums2);
        var min1 = l1.Min();
        var min2 = l2.Min();
        var common = l1.Intersect(l2).OrderBy(n => n).ToList();

        switch (common.Count)
        {
            case 0:
                if(min1 < min2)
                    return min1 * 10 + min2;
                return min2 * 10 + min1;
            default:
                return common[0];
        }
    }
}
