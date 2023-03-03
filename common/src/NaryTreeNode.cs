namespace Common;
public class NaryTreeNode
{
    public int val;
    public IList<NaryTreeNode> childrens;

    public NaryTreeNode(int val = 0)
    {
        this.val = val;
    }
    
    public NaryTreeNode(int val, IList<NaryTreeNode> childrens)
    {
        this.val = val;
        this.childrens = childrens;
    }
}