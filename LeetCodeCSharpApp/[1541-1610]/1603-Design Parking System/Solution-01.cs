namespace LeetCodeCSharpApp.DesignParkingSystem01;

public class ParkingSystem
{
    private readonly int[] _parking;

    public ParkingSystem(int big, int medium, int small)
    {
        _parking = new[] { 0, big, medium, small };
    }

    public bool AddCar(int carType)
    {
        if (_parking[carType] <= 0)
            return false;
        
        _parking[carType]--;
        
        return true;
    }
}
