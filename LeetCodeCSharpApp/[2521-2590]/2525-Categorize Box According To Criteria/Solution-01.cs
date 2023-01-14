namespace LeetCodeCSharpApp.CategorizeBoxAccordingToCriteria01;

public class Solution
{
    private const int MaxDimension = 10000;
    private const long MaxVolume = 1000000000;
    private const int MaxMass = 100;

    private static readonly string[] Categories = { "Neither", "Bulky", "Heavy", "Both" };

    public string CategorizeBox(int length, int width, int height, int mass)
    {
        var idx = Convert.ToByte(length >= MaxDimension || width >= MaxDimension || height >= MaxDimension ||
                                  (long)length * width * height >= MaxVolume) + 2 * Convert.ToByte(mass >= MaxMass);

        return Categories[idx];
    }
}
