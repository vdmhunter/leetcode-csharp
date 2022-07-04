namespace LeetCodeCSharpApp.Candy04;

/// <summary>
/// Single Pass Approach with Constant Space
/// </summary>
public class Solution
{
    public int Candy(int[] ratings)
    {
        int n = ratings.Length, result = n;

        for (int i = 1, up = 0, down = 0, peak = 0; i < ratings.Length; i++)
            if (ratings[i - 1] < ratings[i])
            {
                //put candies vertically on i
                down = 0;
                result += peak = ++up;
            }
            else if (ratings[i - 1] == ratings[i])
            {
                peak = up = down = 0;
            }
            else
            {
                //put candies horizontally ending before i, hold putting on peak as long as down is not above
                up = 0;
                result += ++down + (peak >= down ? -1 : 0);
            }

        return result;
    }
}
