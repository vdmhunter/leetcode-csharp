namespace LeetCodeCSharpApp.CombinationSumIV01;

public class Solution
{
    private readonly Dictionary<int, int> _cache = new();

    public int CombinationSum4(int[] nums, int target)
    {
        switch (target)
        {
            case 0:
                return 1;
            case < 0:
                return 0;
        }

        if (_cache.TryGetValue(target, out var r))
            return r;
        
        var count = nums.Sum(t => CombinationSum4(nums, target - t));
        _cache[target] = count;
        
        return count;
    }
}
