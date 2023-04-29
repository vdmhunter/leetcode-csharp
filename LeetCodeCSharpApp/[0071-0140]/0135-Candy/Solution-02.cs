namespace LeetCodeCSharpApp.Candy02;

/// <summary>
/// Using two arrays
/// </summary>
public class Solution
{
    public int Candy(int[] ratings)
    {
        var sum = 0;

        var left2Right = new int[ratings.Length];
        var right2Left = new int[ratings.Length];

        Array.Fill(left2Right, 1);
        Array.Fill(right2Left, 1);

        for (var i = 1; i < ratings.Length; i++)
            if (ratings[i] > ratings[i - 1])
                left2Right[i] = left2Right[i - 1] + 1;

        for (var i = ratings.Length - 2; i >= 0; i--)
            if (ratings[i] > ratings[i + 1])
                right2Left[i] = right2Left[i + 1] + 1;

        for (var i = 0; i < ratings.Length; i++)
            sum += Math.Max(left2Right[i], right2Left[i]);

        return sum;
    }
}
