namespace LeetCodeCSharpApp.NumberOfDistinctAverages01;

public class Solution
{
    public int DistinctAverages(int[] nums)
    {
        var numsList = new List<int>(nums);
        var averagesList = new List<decimal>();

        while (numsList.Count != 0)
        {
            var min = numsList.Min();
            var max = numsList.Max();
            averagesList.Add((max + min) / 2m);

            numsList.Remove(min);
            numsList.Remove(max);
        }

        return averagesList.Distinct().Count();
    }
}
