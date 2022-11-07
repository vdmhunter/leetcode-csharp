namespace LeetCodeCSharpApp.Maximum69Number01;

public class Solution
{
    public int Maximum69Number(int num)
    {
        var numStr = num.ToString();
        var idx = numStr.IndexOf('6');
        var arr = numStr.ToCharArray();

        if (idx == -1)
            return num;
        
        arr[idx] = '9';
            
        return Convert.ToInt32(new string(arr));
    }
}