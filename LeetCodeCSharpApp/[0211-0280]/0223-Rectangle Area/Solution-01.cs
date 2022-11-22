namespace LeetCodeCSharpApp.RectangleArea01;

public class Solution
{
    public int ComputeArea(int ax1, int ay1, int ax2, int ay2, int bx1, int by1, int bx2, int by2)
    {
        int left = Math.Max(ax1, bx1), right = Math.Max(Math.Min(ax2, bx2), left);
        int bottom = Math.Max(ay1, by1), top = Math.Max(Math.Min(ay2, by2), bottom);

        return (ax2 - ax1) * (ay2 - ay1) - (right - left) * (top - bottom) + (bx2 - bx1) * (by2 - by1);
    }
}
