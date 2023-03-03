using Common;
namespace src;

public class Solution
{
    public ListNode MiddleNode(ListNode head)
    {
        int i = 0;
        ListNode result = head;
        while (head.next != null)
        {
            i++;
            head = head.next;
        }
        int m = (int)Math.Ceiling((decimal)i/2);
        // int m = i%2 >0 ? (i/2)+1 :i/2; // или через остаток от деления
        for (int j = 0; j < m; j++)
        {
            result = result.next;
        }
        return result;
    }
}