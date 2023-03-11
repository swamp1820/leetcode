using Common;
namespace src;

public class Solution
{
    public bool IsValidBST(TreeNode root)
    {
        var s = new Stack<TreeNode>();
        var l = new Stack<TreeNode>();
        var r = new Stack<TreeNode>();
        s.Push(root);
        while (s.Count != 0)
        {
            root = s.Pop();
            if (root.left != null)
            {
                l.Push(root.left);
            }
            if (root.right != null)
            {
                r.Push(root.right);
            }
            // все левое поддерево меньше
            while (l.Count != 0)
            {
                var lsubroot = l.Pop();

                if (lsubroot.val >= root.val)
                {
                    return false;
                }

                if (lsubroot.left != null)
                {
                    l.Push(lsubroot.left);
                }
                if (lsubroot.right != null)
                {
                    l.Push(lsubroot.right);
                }
            }

            // все правое поддерево больше
            while (r.Count != 0)
            {
                var rsubroot = r.Pop();

                if (rsubroot.val <= root.val)
                {
                    return false;
                }

                if (rsubroot.left != null)
                {
                    r.Push(rsubroot.left);
                }
                if (rsubroot.right != null)
                {
                    r.Push(rsubroot.right);
                }
            }

            if (root.left != null)
            {
                s.Push(root.left);
            }
            if (root.right != null)
            {
                s.Push(root.right);
            }

        }

        return true;
    }
}
