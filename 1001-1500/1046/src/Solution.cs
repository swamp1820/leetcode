namespace src;

public class Solution
{
    public int LastStoneWeight(int[] stones)
    {
        var queue = new PriorityQueue<int, int>(stones.Select(x => new ValueTuple<int, int>(x, -x)));

        while (queue.Count > 1)
        {
            var first = queue.Dequeue();
            var second = queue.Dequeue();
            var diff = first-second;
            if (diff>0)
            {
                queue.Enqueue(diff,-diff);
            }
        }

        return queue.Count==0 ? 0: queue.Dequeue();
    }
}