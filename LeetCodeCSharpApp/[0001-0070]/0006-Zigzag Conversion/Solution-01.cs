namespace LeetCodeCSharpApp.ZigzagConversion01;

public class Solution
{
    public string Convert(string s, int numRows)
    {
        if (numRows == 1)
            return s;

        var eachRow = new string[numRows];
        var target = 0;
        var vec = 1;
        
        foreach (var c in s)
        {
            eachRow[target] += c;
            target += vec;
            
            if (target >= numRows)
            {
                vec = -1;
                target = numRows - 2;
            }
            else if (target < 0)
            {
                vec = 1;
                target = 1;
            }
        }

        return string.Join("", eachRow);
    }
}
