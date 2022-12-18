namespace LeetCodeCSharpApp.DailyTemperatures01;

public class Solution
{
    public int[] DailyTemperatures(int[] temperatures)
    {
        var result = new int[temperatures.Length];
        var tempIndex = new Stack<int>();

        tempIndex.Push(0);

        for (var i = 1; i < temperatures.Length; i++)
        {
            while (tempIndex.Count != 0)
                if (temperatures[tempIndex.Peek()] < temperatures[i])
                    result[tempIndex.Peek()] = i - tempIndex.Pop();
                else
                    break;

            tempIndex.Push(i);
        }

        return result;
    }
}
