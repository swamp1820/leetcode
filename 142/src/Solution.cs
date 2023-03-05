using Common;
namespace src;

public class Solution
{
    public ListNode DetectCycle(ListNode head)
    {
        HashSet<ListNode> list = new HashSet<ListNode>();
        if (head != null)
        {
            list.Add(head);

            while (head.next != null)
            {
                var isExist = !list.Add(head.next);
                if (isExist)
                {
                    return head.next;
                }
                head = head.next;
            }
        }

        return null;
    }
}