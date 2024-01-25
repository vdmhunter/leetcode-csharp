namespace LeetCodeCSharpApp.KeysAndRooms01;

public class Solution
{
    public bool CanVisitAllRooms(IList<IList<int>> rooms)
    {
        if (rooms.Count == 0 || rooms[0].Count == 0)
            return false;

        var visitedRooms = new HashSet<int>();
        var queue = new Queue<int>();
        queue.Enqueue(0);

        while (queue.Count > 0)
        {
            var room = queue.Dequeue();
            visitedRooms.Add(room);

            foreach (var key in rooms[room])
                if (!visitedRooms.Contains(key))
                    queue.Enqueue(key);
        }

        return visitedRooms.Count == rooms.Count;
    }
}
