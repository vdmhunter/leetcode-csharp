namespace LeetCodeCSharpApp.SeparateTheDigitsInAnArray01;

public class Solution
{
    public int[] SeparateDigits(int[] nums)
    {
        return (from num in nums from c in num.ToString().ToCharArray() select c - '0').ToArray();
    }
}
