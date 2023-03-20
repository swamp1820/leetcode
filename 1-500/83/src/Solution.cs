using Common;

namespace src;

public class Solution
{
    public ListNode DeleteDuplicates(ListNode head)
    {
        var result = head;
        var cursor = head;

        while (head!=null)
        {
            if (head.val != head.next?.val)
            {
                cursor.next = head.next;
                cursor = cursor.next;
            }

            head = head.next;
        }
        return result;
    }
}