namespace LeetCodeCSharpApp.ExcelSheetColumnTitle02;

public class Solution
{
    public string ConvertToTitle(int columnNumber)
    {
        var result = "";

        while (columnNumber > 0)
        {
            columnNumber--;
            var c = (char)('A' + columnNumber % 26);
            result = c + result;
            columnNumber /= 26;
        }

        return result;
    }
}
