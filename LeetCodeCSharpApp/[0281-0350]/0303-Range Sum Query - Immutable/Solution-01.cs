namespace LeetCodeCSharpApp.RangeSumQueryImmutable01;

public class NumArray
{
    private readonly int[] _nums;

    public NumArray(int[] nums) => _nums = nums;

    public int SumRange(int left, int right) => _nums[left..(right + 1)].Sum();
}
