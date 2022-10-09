namespace LeetCodeCSharpApp.TheEmployeeThatWorkedOnTheLongestTask02;

public class Solution
{
    public int HardestWorker(int n, int[][] logs)
    {
        var result = logs[0][0];
        var longestTask = logs[0][1];

        for (var i = 1; i < logs.Length; i++)
            if (logs[i][1] - logs[i - 1][1] > longestTask)
            {
                longestTask = logs[i][1] - logs[i - 1][1];
                result = logs[i][0];
            }
            else if (logs[i][1] - logs[i - 1][1] == longestTask)
                result = Math.Min(result, logs[i][0]);

        return result;
    }
}
