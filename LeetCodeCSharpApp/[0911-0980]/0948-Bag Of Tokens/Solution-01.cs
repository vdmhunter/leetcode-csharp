namespace LeetCodeCSharpApp.BagOfTokens01;

public class Solution
{
    public int BagOfTokensScore(int[] tokens, int power)
    {
        Array.Sort(tokens);
        
        int res = 0, points = 0, i = 0, j = tokens.Length - 1;
        
        while (i <= j)
            if (power >= tokens[i])
            {
                power -= tokens[i++];
                res = Math.Max(res, ++points);
            }
            else if (points > 0)
            {
                points--;
                power += tokens[j--];
            }
            else
                break;

        return res;
    }
}
