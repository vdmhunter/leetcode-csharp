namespace LeetCodeCSharpApp.DetermineTheWinnerOfABowlingGame01;

public class Solution
{
    public int IsWinner(int[] player1, int[] player2)
    {
        var score1 = CalculateScore(player1);
        var score2 = CalculateScore(player2);

        if (score1 > score2)
            return 1;

        if (score2 > score1)
            return 2;

        return 0;
    }

    private static int CalculateScore(int[] player)
    {
        var n = player.Length;
        var score = 0;

        for (var i = 0; i < n; i++)
            switch (i)
            {
                case >= 1 when player[i - 1] == 10:
                case >= 2 when player[i - 2] == 10:
                    score += 2 * player[i];
                    break;
                default:
                    score += player[i];
                    break;
            }

        return score;
    }
}
