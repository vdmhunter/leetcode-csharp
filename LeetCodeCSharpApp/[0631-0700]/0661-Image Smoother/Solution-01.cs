namespace LeetCodeCSharpApp.ImageSmoother01;

public class Solution
{
    public int[][] ImageSmoother(int[][] img)
    {
        int m = img.Length, n = img[0].Length;

        if (m == 0 || n == 0)
            return Array.Empty<int[]>();

        int[][] dirs =
        {
            new[] { 0, 1 }, new[] { 0, -1 }, new[] { 1, 0 }, new[] { -1, 0 },
            new[] { -1, -1 }, new[] { 1, 1 }, new[] { -1, 1 }, new[] { 1, -1 }
        };

        for (var i = 0; i < m; i++)
        {
            for (var j = 0; j < n; j++)
            {
                SmoothPixel(img, i, j, dirs, m, n);
            }
        }

        for (var i = 0; i < m; i++)
            for (var j = 0; j < n; j++)
                img[i][j] >>= 8;

        return img;
    }

    private static void SmoothPixel(int[][] img, int i, int j, int[][] dirs, int m, int n)
    {
        int sum = img[i][j], cnt = 1;

        foreach (var d in dirs)
        {
            int x = i + d[0], y = j + d[1];

            if (x < 0 || x > m - 1 || y < 0 || y > n - 1)
                continue;

            sum += img[x][y] & 0xFF;
            cnt++;
        }

        img[i][j] |= (sum / cnt) << 8;
    }
}
