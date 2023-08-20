namespace LeetCodeCSharpApp.CountPairsWhoseSumIsLessThanTarget02;

public class Solution
{
    public int CountPairs(IList<int> nums, int target)
    {
        var count = 0;
        var numsArray = nums.ToArray();
        Array.Sort(numsArray);

        var left = 0;
        var right = numsArray.Length - 1;

        while (left < right)
        {
            if (numsArray[left] + numsArray[right] < target)
            {
                count += right - left;
                left++;
            }
            else
            {
                right--;
            }
        }

        return count;
    }
}
