namespace LeetCodeCSharpApp.ConvertTheTemperature01;

public class Solution
{
    public double[] ConvertTemperature(double celsius)
    {
        return new[] { celsius + 273.15, celsius * 1.80 + 32.00 };
    }
}
