namespace LeetCodeCSharpApp.TwoSumIIInputArrayIsSorted01;

public class Solution
{
    public int[] TwoSum(int[] numbers, int target)
    {
        int l = 0, r = numbers.Length - 1;

        while (numbers[l] + numbers[r] != target)
            if (numbers[l] + numbers[r] < target)
                l++;
            else
                r--;

        return new[] { l + 1, r + 1 };
    }
}
