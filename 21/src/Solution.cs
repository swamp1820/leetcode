using Common;
namespace src;

public class Solution
{
    ListNode head = new ListNode();
    ListNode lastNode = new ListNode();

    /// <summary>
    /// Решение задачи "в лоб" за O(n)
    /// </summary>
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        head.next=lastNode;
        return Merge(list1, list2).next.next; // 
    }

    private ListNode Merge(ListNode list1, ListNode list2)
    {
        if (list1 is null && list2 is null)
        {
            return head;
        }
        else if (list2 is null || (list1 != null && list1.val < list2.val)  )
        {
            lastNode.next = list1;
            lastNode = lastNode.next;
            list1 = list1.next;
        }
        else if (list1 is null || (list2 != null && list2.val < list1.val) )
        {
            lastNode.next = list2;
            lastNode = lastNode.next;
            list2 = list2.next;
        }
        else if (list1.val==list2.val)
        {
            lastNode.next = list1;
            lastNode = lastNode.next;
            list1 = list1.next;
            lastNode.next = list2;
            lastNode = lastNode.next;
            list2 = list2.next;
        }

        return Merge(list1,list2);
    }

}