// ReSharper disable CollectionNeverQueried.Local

namespace LeetCodeCSharpApp.SeatReservationManager01;

public class SeatManager
{
    private readonly HashSet<int> _reserved;
    private readonly PriorityQueue<int, int> _unreserved;

    public SeatManager(int n)
    {
        _unreserved = new PriorityQueue<int, int>();
        _reserved = new HashSet<int>();

        for (var i = 1; i <= n; i++)
            _unreserved.Enqueue(i, i);
    }

    public int Reserve()
    {
        var reserveSeat = _unreserved.Dequeue();
        _reserved.Add(reserveSeat);

        return reserveSeat;
    }

    public void Unreserve(int seatNumber)
    {
        _unreserved.Enqueue(seatNumber, seatNumber);
        _reserved.Remove(seatNumber);
    }
}
