namespace Common;
public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }

    public ListNode(IEnumerable<int> input)
    {
        var inputArray = input.ToArray();
        this.val = inputArray[0];
        for (int i = 1; i <= inputArray.Count() - 1; i++)
        {
            this.AddNode(inputArray[i]);
        }
    }


    public void AddNode(int value)
    {
        ListNode lastNode = this;
        bool islastNode = lastNode.next == null;
        while (!islastNode)
        {
            lastNode = this.next;
            islastNode = lastNode.next == null;
        }

        lastNode.next = new ListNode(value);
    }

    public IEnumerable<int> ToIEnumerable()
    {
        var result = new List<int>();
        var currentNode = this;
        result.Add(currentNode.val);
        while (currentNode.next != null)
        {
            currentNode = currentNode.next;
            result.Add(currentNode.val);
        }

        return result.AsEnumerable();
    }

}
