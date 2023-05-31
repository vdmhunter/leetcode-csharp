namespace LeetCodeCSharpApp.DesignUndergroundSystem01;

public class UndergroundSystem
{
    private readonly Dictionary<int, (string, int)> _checkIns = new();
    private readonly Dictionary<(string, string), int[]> _times = new();

    public void CheckIn(int id, string stationName, int t)
    {
        _checkIns[id] = (stationName, t);
    }

    public void CheckOut(int id, string stationName, int t)
    {
        var (startStation, startTime) = _checkIns[id];
        _checkIns.Remove(id);

        var pair = (startStation, stationName);
        var arr = _times.GetValueOrDefault(pair, new[] { 0, 0 });
        var totalTime = arr[0];
        var dataPoints = arr[1];

        _times[pair] = new[] { totalTime + t - startTime, dataPoints + 1 };
    }

    public double GetAverageTime(string startStation, string endStation)
    {
        var pair = (startStation, endStation);

        return (double)_times[pair][0] / _times[pair][1];
    }
}
