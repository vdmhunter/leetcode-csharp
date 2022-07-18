namespace LeetCodeCSharpApp.FloodFill01;

public class Solution
{
    public int[][] FloodFill(int[][] image, int sr, int sc, int color)
    {
        if (image[sr][sc] == color)
            return image;
        
        Fill(image, sr, sc, image[sr][sc], color);
        
        return image;
    }

    private void Fill(int[][] image, int sr, int sc, int color, int newColor)
    {
        if (sr < 0 || sr >= image.Length || sc < 0 || sc >= image[0].Length || image[sr][sc] != color)
            return;

        image[sr][sc] = newColor;

        Fill(image, sr + 1, sc, color, newColor);
        Fill(image, sr - 1, sc, color, newColor);
        Fill(image, sr, sc + 1, color, newColor);
        Fill(image, sr, sc - 1, color, newColor);
    }
}
