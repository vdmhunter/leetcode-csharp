namespace LeetCodeCSharpApp.DetermineIfACellIsReachableAtAGivenTime01;

public class Solution
{
    public bool IsReachableAtTime(int sx, int sy, int fx, int fy, int t)
    {
        var need = Math.Max(Math.Abs(sx - fx), Math.Abs(sy - fy));

        return need > 0 ? t >= need : t != 1;
    }
}
