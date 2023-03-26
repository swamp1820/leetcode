using Common;
namespace src;

public class Solution
{
    public bool FindTarget(TreeNode root, int k)
    {
        if (root==null)
        {
            return false;
        }

        var s = new Stack<TreeNode>();
        var visited = new HashSet<int>();
        s.Push(root);
        while (s.Count != 0)
        {
            var n = s.Pop();
            
            visited.Add(n.val);
            // нечетные, либо четные делим на 2 (т.к. повтора быть не может)
            if (visited.Contains(k - n.val) && (k%2!=0 || n.val!=k/2))
            {
                return true;
            }

            if (n.left != null)
            {
                s.Push(n.left);
            }
            if (n.right != null)
            {
                s.Push(n.right);
            }
        }

        return false;
    }
}