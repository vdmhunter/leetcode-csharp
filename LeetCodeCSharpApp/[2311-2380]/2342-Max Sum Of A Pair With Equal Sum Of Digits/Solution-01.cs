namespace LeetCodeCSharpApp.MaxSumOfAPairWithEqualSumOfDigits01;

public class Solution
{
    public int MaximumSum(int[] nums)
    {
        var dic = new Dictionary<int, List<int>>();

        foreach (var n in nums)
        {
            var sum = n.ToString().Sum(c => c - '0');

            if (!dic.ContainsKey(sum))
                dic.Add(sum, new List<int> { n });
            else
                dic[sum].Add(n);
        }

        return dic.Values
            .Where(v => v.Count >= 2)
            .Select(pairsList => pairsList.OrderByDescending(pl => pl).Take(2).Sum())
            .Prepend(-1)
            .Max();
    }
}
