namespace LeetCodeCSharpApp.CategorizeBoxAccordingToCriteria02;

public class Solution
{
    private const int MaxDimension = 10000;
    private const long MaxVolume = 1000000000;
    private const int MaxMass = 100;

    public string CategorizeBox(int length, int width, int height, int mass)
    {
        bool h = false, b = false;

        if (length >= MaxDimension || height >= MaxDimension || width >= MaxDimension)
            b = true;

        if ((long)length * width * height >= MaxVolume)
            b = true;

        if (mass >= MaxMass)
            h = true;

        return h switch
        {
            true when b => "Both",
            true when !b => "Heavy",
            false when b => "Bulky",
            _ => "Neither"
        };
    }
}
