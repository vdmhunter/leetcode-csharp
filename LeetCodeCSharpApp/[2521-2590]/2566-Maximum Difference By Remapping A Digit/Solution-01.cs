using System;

namespace LeetCodeCSharpApp.MaximumDifferenceByRemappingADigit01;

public class Solution
{
    public int MinMaxDifference(int num)
    {
        // Convert the input number to a string
        var numStr = num.ToString();

        // Initialize the minimum and maximum values to the input number
        var minNum = num;
        var maxNum = num;

        // Loop through all possible digits to remap
        for (var d = 0; d <= 9; d++)
        {
            // Skip the current digit if it is not present in the input number
            if (!numStr.Contains(d.ToString()))
                continue;

            // Create a new number by replacing all occurrences of the current digit with the digit 9
            var maxNumStr = numStr.Replace(d.ToString(), "9");
            var newMaxNum = int.Parse(maxNumStr);

            // Create a new number by replacing all occurrences of the current digit with the digit 0
            // (except if the current digit is 0 and the first character of the number)
            var minNumStr = numStr.Replace(d.ToString(), "0");

            if (d == 0 && numStr[0] == '0')
                minNumStr = string.Concat("0", minNumStr.AsSpan(1));

            var newMinNum = int.Parse(minNumStr);

            // Update the minimum and maximum values if the new numbers are smaller or larger, respectively
            if (newMaxNum > maxNum)
                maxNum = newMaxNum;

            if (newMinNum < minNum)
                minNum = newMinNum;
        }

        // Return the difference between the maximum and minimum values
        return maxNum - minNum;
    }
}
