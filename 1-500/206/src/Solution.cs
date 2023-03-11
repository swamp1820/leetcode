using Common;
namespace src;

public class Solution
{
    public ListNode ReverseList(ListNode head)
    {
        ListNode prev = null;
        ListNode current = head;
        ListNode next = null;
        while (current != null)
        {
            // запомним следующий элемент
            next = current.next;
            // поставим предыдущий элемент следующим
            current.next = prev;

            // текущий элемент стал предыдущим
            prev = current;
            // следующий элемент стал текущим
            current = next;
        }

        return prev;
    }
}