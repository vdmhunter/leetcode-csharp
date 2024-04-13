namespace LeetCodeCSharpApp.MaximalRectangle01;

public class Solution
{
    public int MaximalRectangle(char[][] matrix)
    {
        if (matrix == null! || matrix.Length == 0 || matrix[0].Length == 0)
            return 0;

        var height = new int[matrix[0].Length];

        for (var i = 0; i < matrix[0].Length; i++)
            if (matrix[0][i] == '1')
                height[i] = 1;

        int result = LargestInLine(height);

        for (var i = 1; i < matrix.Length; i++)
        {
            ResetHeight(matrix, height, i);
            result = Math.Max(result, LargestInLine(height));
        }

        return result;
    }

    private static void ResetHeight(char[][] matrix, int[] height, int idx)
    {
        for (var i = 0; i < matrix[0].Length; i++)
            if (matrix[idx][i] == '1')
                height[i] += 1;
            else
                height[i] = 0;
    }

    private static int LargestInLine(int[] height)
    {
        if (height == null! || height.Length == 0)
            return 0;

        int len = height.Length;
        var s = new Stack<int>();
        var maxArea = 0;

        for (var i = 0; i <= len; i++)
        {
            int h = i == len ? 0 : height[i];

            if (s.Count == 0 || h >= height[s.Peek()])
            {
                s.Push(i);
            }
            else
            {
                int tp = s.Pop();

                maxArea = Math.Max(
                    maxArea,
                    height[tp] * (s.Count == 0 ? i : i - 1 - s.Peek()));

                i--;
            }
        }

        return maxArea;
    }
}
