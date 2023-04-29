namespace LeetCodeCSharpApp.MaximumPointsYouCanObtainFromCards01;

public class Solution
{
    public int MaxScore(int[] cardPoints, int k)
    {
        var total = cardPoints[..k].Sum();
        var maxLength = total;

        for (var i = 0; i < k; i++)
        {
            total += cardPoints[cardPoints.Length - 1 - i] - cardPoints[k - 1 - i];
            maxLength = Math.Max(maxLength, total);
        }

        return maxLength;
    }
}
