namespace LeetCodeCSharpApp.MinimumSecondsToEqualizeACircularArray01;

public class Solution
{
    public int MinimumSeconds(IList<int> nums)
    {
        var nPos = new Dictionary<int, List<int>>();

        for (var i = 0; i < nums.Count; i++)
        {
            if (!nPos.ContainsKey(nums[i]))
                nPos[nums[i]] = new List<int>();

            nPos[nums[i]].Add(i);
        }

        var result = int.MaxValue;

        foreach (var pos in nPos.Select(kvp => kvp.Value))
        {
            pos.Add(pos[0] + nums.Count);

            var seconds = Enumerable.Range(1, pos.Count - 1)
                .Select(i => (pos[i] - pos[i - 1]) / 2)
                .Max();

            result = Math.Min(result, seconds);
        }

        return result;
    }
}
