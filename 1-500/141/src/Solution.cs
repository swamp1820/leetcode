using Common;
namespace src;

public class Solution
{
    public bool HasCycle(ListNode head)
    {
        HashSet<ListNode> list = new HashSet<ListNode>();
        if (head != null)
        {
            list.Add(head);

            while (head.next != null)
            {
                if (!list.Add(head.next))
                {
                    return true;
                }
                head = head.next;
            }
        }

        return false;
    }
}