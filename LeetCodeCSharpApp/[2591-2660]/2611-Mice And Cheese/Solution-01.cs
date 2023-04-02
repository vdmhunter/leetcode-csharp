namespace LeetCodeCSharpApp.MiceAndCheese01;

public class Solution
{
    public int MiceAndCheese(int[] reward1, int[] reward2, int k)
    {
        var n = reward1.Length;

        // Create a list of tuples to store the rewards of each cheese type
        var rewards = new List<(int FirstReward, int SecondReward)>();
        
        for (var i = 0; i < n; i++)
            rewards.Add((reward1[i], reward2[i]));

        // Sort the cheese types in descending order of the difference between reward1 and reward2
        rewards.Sort((a, b) => b.FirstReward - b.SecondReward - (a.FirstReward - a.SecondReward));

        var totalPoints = 0;
        var kCount = 0;
        
        for (var i = 0; i < n; i++)
            if (n == 1 && k != 0)
            {
                // First mouse eats this single type of cheese.
                totalPoints += rewards[i].FirstReward;
            }
            else if (kCount == k)
            {
                // First mouse has already eaten k types of cheese,
                // so the second mouse should eat the rest
                totalPoints += rewards[i].SecondReward;
            }
            else if (i + (k - kCount) > n)
            {
                // There aren't enough cheese types left for the first mouse to eat k types,
                // so the second mouse should eat the rest
                totalPoints += rewards[i].SecondReward;
            }
            else
            {
                // The first mouse eats this cheese type
                totalPoints += rewards[i].FirstReward;
                kCount++;
            }

        return totalPoints;
    }
}
