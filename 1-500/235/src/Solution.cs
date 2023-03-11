using Common;
namespace src;

public class Solution
{
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        var s = new Stack<TreeNode>(); //внешний стек
        var t = new Stack<TreeNode>(); // стек для внутреннего прохождения
        var result = root;
        s.Push(root);
        while (s.Count != 0)
        {
            root = s.Pop();
            // внутренний цикл проверки поддеревьев на наличие p и q
            t.Push(root);
            bool pFound = false;
            bool qFound = false;
            while (t.Count != 0)
            {
                var subroot = t.Pop();

                if (subroot.val == p.val)
                {
                    pFound = true;
                }
                if (subroot.val == q.val)
                {
                    qFound = true;
                }

                if (pFound && qFound)
                {
                    result = root;
                    break;
                }

                if (subroot.left != null)
                {
                    t.Push(subroot.left);
                }
                if (subroot.right != null)
                {
                    t.Push(subroot.right);
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

        return result;
    }
}
