namespace LeetCodeCSharpApp.LargestPositiveIntegerThatExistsWithItsNegative01;

public class Solution
{
    public int FindMaxK(int[] nums)
    {
        var x = nums.Where(n => nums.Contains(-n)).OrderByDescending(n => n).ToList();
        
        if (x.Count == 0)
            return -1;

        return x.First();
    }
}
