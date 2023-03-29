namespace LeetCodeCSharpApp.ReducingDishes01;

public class Solution
{
    public int MaxSatisfaction(int[] satisfaction)
    {
        Array.Sort(satisfaction);
        var totalSatisfaction = 0;
        var sum = 0;

        for (var i = satisfaction.Length - 1; i >= 0; i--)
        {
            if (totalSatisfaction > totalSatisfaction + sum + satisfaction[i])
                break;

            sum += satisfaction[i];
            totalSatisfaction += sum;
        }

        return totalSatisfaction;
    }
}
