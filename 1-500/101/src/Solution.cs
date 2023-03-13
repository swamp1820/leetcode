using Common;
namespace src;

public class Solution
{
    public bool IsSymmetric(TreeNode root)
    {
        if (root != null)
        {
            var q = new Queue<List<TreeNode>>();
            q.Enqueue(new List<TreeNode>() { root });
            while (q.Count > 0)
            {
                var n = q.Dequeue();
                List<TreeNode> subNodes = new List<TreeNode>();

                if (n.Count > 1)
                {
                    for (int i = 0; i < n.Count / 2; i++)
                    {
                        if (n[i]?.val != n[n.Count - 1 - i]?.val)
                        {
                            return false;
                        }
                    }

                }

                foreach (TreeNode node in n)
                {
                    if (node != null)
                    {
                        subNodes.Add(node.left);
                        subNodes.Add(node.right);
                    }
                }

                // если нечетное кол-во, то точно нет симметрии
                if (subNodes.Count % 2 != 0)
                {
                    return false;
                }

                if (subNodes.Count > 0)
                {
                    q.Enqueue(subNodes);
                }
            }
        }
        return true;
    }

    public bool IsSymmetricRecursive(TreeNode root)
    {
        var q = new Queue<List<TreeNode>>();
        q.Enqueue(new List<TreeNode>() { root });
        return recursiveBFS(q);
    }

    private bool recursiveBFS(Queue<List<TreeNode>> q)
    {
        if (q.Count == 0)
        {
            return true;
        }

        var nodes = q.Dequeue();

        if (nodes.Count > 1)
        {
            for (int i = 0; i < nodes.Count / 2; i++)
            {
                if (nodes[i]?.val != nodes[nodes.Count - 1 - i]?.val)
                {
                    return false;
                }
            }
        }
        
        List<TreeNode> subNodes = new List<TreeNode>();
        foreach (TreeNode node in nodes)
        {
            if (node != null)
            {
                subNodes.Add(node.left);
                subNodes.Add(node.right);
            }
        }

        // если нечетное кол-во, то точно нет симметрии
        if (subNodes.Count % 2 != 0)
        {
            return false;
        }

        if (subNodes.Count > 0)
        {
            q.Enqueue(subNodes);
        }

        return recursiveBFS(q);
    }
}
    

// def recursiveBFS(graph, q, discovered):
 
//     if not q:
//         return
 
//     # dequeue front node and print it
//     v = q.popleft()
//     print(v, end=' ')
 
//     # do for every edge (v, u)
//     for u in graph.adjList[v]:
//         if not discovered[u]:
//             # mark it as discovered and enqueue it
//             discovered[u] = True
//             q.append(u)
 
//     recursiveBFS(graph, q, discovered)
