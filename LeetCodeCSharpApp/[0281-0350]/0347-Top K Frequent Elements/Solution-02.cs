namespace LeetCodeCSharpApp.TopKFrequentElements02;

public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        var counter = new Dictionary<int, int>();

        foreach (var num in nums)
            if (counter.ContainsKey(num))
                counter[num]++;
            else
                counter[num] = 1;

        var heap = counter.OrderByDescending(x => x.Value).ToArray();
        var result = new int[k];

        for (var i = 0; i < k; i++)
            result[i] = heap.ElementAt(i).Key;

        return result;
    }
}
