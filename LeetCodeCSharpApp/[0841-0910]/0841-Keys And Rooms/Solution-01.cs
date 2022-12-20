namespace LeetCodeCSharpApp.KeysAndRooms01;

/// <summary>
/// BFS + Hash Set
/// </summary>
public class Solution
{
    public bool CanVisitAllRooms(IList<IList<int>> rooms)
    {
        // Edge cases.
        if (!rooms.Any())
            return false;
        if (!rooms[0].Any())
            return false;

        // Keep track of rooms we already checked.
        HashSet<int> searchedRooms = new();

        // Each integer represents the next room(s) to check.
        Queue<int> queue = new();

        // First-time setup. According to the problem, we start in the 0th room.
        queue.Enqueue(0);

        while (queue.Any())
            for (var i = 0; i < queue.Count; i++)
            {
                var room = queue.Dequeue();
                searchedRooms.Add(room);

                // Take all keys in this room and search those next rooms.
                foreach (var key in rooms[room])
                    // If this key belongs to a room we already searched, skip it.
                    CheckRoom(key);
            }

        void CheckRoom(int key1)
        {
            if (!searchedRooms.Contains(key1))
                queue.Enqueue(key1);
        }

        return searchedRooms.Count == rooms.Count;
    }
}
