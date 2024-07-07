namespace LeetCodeCSharpApp.WaterBottles01;

public class Solution
{
    public int NumWaterBottles(int numBottles, int numExchange)
    {
        var result = 0;

        while (numBottles >= numExchange)
        {
            int r = numBottles % numExchange;
            result += numBottles - r;
            numBottles = numBottles / numExchange + r;
        }

        return result + numBottles;
    }
}
