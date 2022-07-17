namespace LeetCodeCSharpApp.Candy01;

/// <summary>
/// Brute Force
/// </summary>
public class Solution
{
    public int Candy(int[] ratings)
    {
        var candies = new int[ratings.Length];
        Array.Fill(candies, 1);
        var hasChanged = true;
        
        while (hasChanged)
        {
            hasChanged = false;
            for (var i = 0; i < ratings.Length; i++)
            {
                if (i != ratings.Length - 1 && ratings[i] > ratings[i + 1] && candies[i] <= candies[i + 1])
                {
                    candies[i] = candies[i + 1] + 1;
                    hasChanged = true;
                }
                
                if (i > 0 && ratings[i] > ratings[i - 1] && candies[i] <= candies[i - 1])
                {
                    candies[i] = candies[i - 1] + 1;
                    hasChanged = true;
                }
            }
        }

        return candies.Sum();
    }
}
