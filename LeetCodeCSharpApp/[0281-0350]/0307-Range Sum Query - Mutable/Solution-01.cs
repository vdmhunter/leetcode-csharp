namespace LeetCodeCSharpApp.RangeSumQueryMutable01;

/// <summary>
/// Buckets solution
/// </summary>
public class NumArray
{
    private readonly int _bucketSize;
    private readonly int[] _nums;
    private readonly int[] _bucketsSum;

    public NumArray(int[] nums)
    {
        _nums = nums;
        _bucketSize = (int)Math.Sqrt(nums.Length);
        _bucketsSum = new int [nums.Length / _bucketSize + 1];

        for (var i = 0; i < nums.Length; i++)
            _bucketsSum[i / _bucketSize] += nums[i];
    }

    public void Update(int index, int val)
    {
        _bucketsSum[index / _bucketSize] += -_nums[index] + val;
        _nums[index] = val;
    }

    public int SumRange(int left, int right)
    {
        var sum = 0;

        for (var i = left; i <= right;)
            if (i % _bucketSize == 0 && right - i >= _bucketSize)
            {
                sum += _bucketsSum[i / _bucketSize];
                i += _bucketSize;
            }
            else
            {
                var bound = Math.Min(right, (i / _bucketSize + 1) * _bucketSize - 1);

                for (; i <= bound; i++)
                    sum += _nums[i];
            }

        return sum;
    }
}
