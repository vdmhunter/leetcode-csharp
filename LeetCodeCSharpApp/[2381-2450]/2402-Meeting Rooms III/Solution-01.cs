namespace LeetCodeCSharpApp.MeetingRoomsIII01;

public class Solution
{
    public int MostBooked(int n, int[][] meetings)
    {
        var busy = new PriorityQueue<Room, Room>(new RoomComparer());
        var empty = new PriorityQueue<int, int>();

        for (var i = 0; i < n; i++)
            empty.Enqueue(i, i);

        Array.Sort(meetings, (a, b) => a[0] - b[0]);

        var arr = new int[n];

        foreach (var meeting in meetings)
        {
            var start = meeting[0];
            var end = meeting[1];

            while (busy.Count > 0 && busy.Peek().EndTime <= start)
                empty.Enqueue(busy.Peek().RoomNumber, busy.Dequeue().RoomNumber);

            if (empty.Count > 0)
            {
                arr[empty.Peek()]++;
                var room = new Room { RoomNumber = empty.Dequeue(), EndTime = end };
                busy.Enqueue(room, room);
            }
            else
            {
                arr[busy.Peek().RoomNumber]++;
                var room = new Room
                {
                    RoomNumber = busy.Peek().RoomNumber, EndTime = end + busy.Dequeue().EndTime - start
                };
                busy.Enqueue(room, room);
            }
        }

        var res = 0;

        for (var i = 0; i < arr.Length; i++)
            if (arr[i] > arr[res])
                res = i;

        return res;
    }

    private class Room
    {
        public int RoomNumber { get; init; }
        public long EndTime { get; init; }
    }

    private class RoomComparer : IComparer<Room>
    {
        public int Compare(Room? a, Room? b)
        {
            return a!.EndTime == b!.EndTime
                ? a.RoomNumber.CompareTo(b.RoomNumber)
                : a.EndTime.CompareTo(b.EndTime);
        }
    }
}
