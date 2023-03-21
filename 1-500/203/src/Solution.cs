using Common;

namespace src;

public class Solution
{
    
    public ListNode RemoveElements(ListNode head, int val)
    {
        var result = new ListNode();
        var cursor = result;

        while (head != null)
        {
            if (head.val != val)
            {
                cursor.next = head;
                cursor = cursor.next;
            }
            else if (head.val == val && head.next==null)
            {
                  cursor.next = null;
            }

            head = head.next;
        }
        return result?.next;
    }
}