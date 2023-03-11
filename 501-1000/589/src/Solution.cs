using Common;
namespace src;

public class Solution
{
    List<int> result = new List<int>();
    public IList<int> Preorder(NaryTreeNode root)
    {
        var s = new Stack<NaryTreeNode>();
        if (root==null)
        {
            return result;
        }
        s.Push(root);
        while (s.Count != 0)
        {
            root = s.Pop();
            result.Add(root.val);
            if (root.childrens != null)
            {
                for (int i = root.childrens.Count-1; i >= 0 ; i--)
                {
                    s.Push(root.childrens[i]);
                }
            }
        }

        return result;
    }

    public IList<int> PreorderRecursive(NaryTreeNode root)
    {
        if (root == null)
        {
            return result;
        }
        result.Add(root.val);
        if (root.childrens != null)
        {

            for (int i = 0; i < root.childrens.Count; i++)
            {
                PreorderRecursive(root.childrens[i]);
            }

        }

        return result;
    }

    // procedure DFS_iterative(G, v) is
    // let S be a stack
    // S.push(v)
    // while S is not empty do
    //     v = S.pop()
    //     if v is not labeled as discovered then
    //         label v as discovered
    //         for all edges from v to w in G.adjacentEdges(v) do 
    //             S.push(w)
}
