using Common;
namespace src;

public class Solution
{

    public int MaxDepth(TreeNode root)
    {
        int result = 0;
        if (root == null)
        {
            return result;
        }

        var s = new Stack<List<TreeNode>>();
        s.Push(new List<TreeNode>() { root });

        while (s.Count != 0)
        {
            var rootList = s.Pop();

            var l = new List<TreeNode>();
            for (int i = 0; i < rootList.Count; i++)
            {
                if (rootList[i].left != null)
                {
                    l.Add(rootList[i].left);
                }
                if (rootList[i].right != null)
                {
                    l.Add(rootList[i].right);
                }
            }
            if (l.Count > 0)
            {

                s.Push(l);
            }
            result++;
        }

        return result;
    }
}