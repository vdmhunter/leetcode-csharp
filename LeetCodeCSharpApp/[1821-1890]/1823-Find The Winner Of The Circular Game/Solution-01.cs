namespace LeetCodeCSharpApp.FindTheWinnerOfTheCircularGame01;

public class Solution
{
    public int FindTheWinner(int n, int k)
    {
        var position = 0;

        for (var i = 2; i <= n; i++)
            position = (position + k) % i;

        return position + 1;
    }
}
