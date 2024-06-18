namespace LeetCodeCSharpApp.MostProfitAssigningWork01;

public class Solution
{
    public int MaxProfitAssignment(int[] difficulty, int[] profit, int[] worker)
    {
        Array.Sort(worker);
        Array.Sort(difficulty, profit);

        var result = 0;
        var max = 0;
        int i = 0, j = 0;

        while (j < worker.Length)
        {
            if (i < difficulty.Length && worker[j] >= difficulty[i])
            {
                max = Math.Max(max, profit[i]);
                ++i;
            }
            else
            {
                result += max;
                ++j;
            }
        }

        return result;
    }
}
