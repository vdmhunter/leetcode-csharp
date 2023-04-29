namespace LeetCodeCSharpApp.TheEmployeeThatWorkedOnTheLongestTask01;

public class Solution
{
    public int HardestWorker(int n, int[][] logs)
    {
        var taskDurations = logs.Skip(1).Zip(logs, (curr, prev) => (Id: curr[0], Duration: curr[1] - prev[1])).ToList();
        taskDurations.Insert(0, (logs[0][0], logs[0][1]));

        var maxDuration = taskDurations.MaxBy(d => d.Duration).Duration;
        var result = taskDurations.Where(d => d.Duration == maxDuration).MinBy(d => d.Id).Id;

        return result;
    }
}
