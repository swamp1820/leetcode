using Common;
namespace src;

public class Solution
{
    public IList<IList<int>> LevelOrder(TreeNode root)
    {
        var result = new List<List<int>>();
        if (root != null)
        {
            var q = new Queue<List<TreeNode>>();

            result.Add(new List<int>() { root.val });
            q.Enqueue(new List<TreeNode>() { root });
            while (q.Count > 0)
            {
                var n = q.Dequeue();
                List<TreeNode> subNodes = new List<TreeNode>();
                foreach (TreeNode node in n)
                {
                    if (node.left != null)
                    {
                        subNodes.Add(node.left);
                    }

                    if (node.right != null)
                    {
                        subNodes.Add(node.right);
                    }
                }
              
                if (subNodes.Count > 0)
                {
                    q.Enqueue(subNodes);
                    result.Add(subNodes.Select(x=>x.val).ToList());
                }
            }
        }

        return result.ToArray();
    }
}

//  1  procedure BFS(G, root) is
//  2      let Q be a queue
//  3      label root as explored
//  4      Q.enqueue(root)
//  5      while Q is not empty do
//  6          v := Q.dequeue()
//  7          if v is the goal then
//  8              return v
//  9          for all edges from v to w in G.adjacentEdges(v) do
// 10              if w is not labeled as explored then
// 11                  label w as explored
// 12                  w.parent := v
// 13                  Q.enqueue(w)