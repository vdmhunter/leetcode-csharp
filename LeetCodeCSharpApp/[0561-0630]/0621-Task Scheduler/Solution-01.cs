namespace LeetCodeCSharpApp.TaskScheduler01;

public class Solution
{
    public int LeastInterval(char[] tasks, int n)
    {
        var counter = new int[26];
        var max = 0;
        var maxCount = 0;

        foreach (char task in tasks)
        {
            counter[task - 'A']++;

            if (max == counter[task - 'A'])
            {
                maxCount++;
            }
            else if (max < counter[task - 'A'])
            {
                max = counter[task - 'A'];
                maxCount = 1;
            }
        }

        int partCount = max - 1;
        int partLength = n - (maxCount - 1);
        int emptySlots = partCount * partLength;
        int availableTasks = tasks.Length - max * maxCount;
        int idles = Math.Max(0, emptySlots - availableTasks);

        return tasks.Length + idles;
    }
}
