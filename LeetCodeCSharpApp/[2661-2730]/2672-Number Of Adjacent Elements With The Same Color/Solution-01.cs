namespace LeetCodeCSharpApp.NumberOfAdjacentElementsWithTheSameColor01;

public class Solution
{
    public int[] ColorTheArray(int n, int[][] queries)
    {
        var result = new int[queries.Length];
        var state = new int[n];
        var count = 0;

        for (var i = 0; i < queries.Length; i++)
        {
            int index = queries[i][0], color = queries[i][1];

            count -= CountAdjacent(state, index);
            state[index] = color;
            count += CountAdjacent(state, index);

            result[i] = count;
        }

        return result;
    }

    private static int CountAdjacent(int[] nums, int index)
    {
        var count = 0;

        if (index != 0)
            count += nums[index] == nums[index - 1] && nums[index] != 0 ? 1 : 0;

        if (index != nums.Length - 1)
            count += nums[index] == nums[index + 1] && nums[index] != 0 ? 1 : 0;

        return count;
    }
}
