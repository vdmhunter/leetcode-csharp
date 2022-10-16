namespace LeetCodeCSharpApp.NumberOfValidClockTimes01;

public class Solution
{
    public int CountTime(string time)
    {
        return HoursCount(time[..2]) * MinutesCount(time[3..5]);
    }

    private static int HoursCount(string hh)
    {
        var result = 1;
        
        if (hh == "??")
            result = 24;
        else if (hh[0] == '?' && hh[1] != '?')
        {
            if (hh[1] == '0' || hh[1] == '1' || hh[1] == '2' || hh[1] == '3')
                result = 3;
            else
                result = 2;
        }
        else if (hh[0] != '?' && hh[1] == '?')
            result = hh[0] == '2' ? 4 : 10;

        return result;
    }
    
    private static int MinutesCount(string mm)
    {
        var result = 1;
        
        if (mm == "??")
            result = 60;
        else if (mm[0] == '?' && mm[1] != '?')
            result =  6;
        else if (mm[0] != '?' && mm[1] == '?')
            result = 10;
        
        return result;
    }
}
