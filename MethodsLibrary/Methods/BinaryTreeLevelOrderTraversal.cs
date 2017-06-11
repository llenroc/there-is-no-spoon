using MethodsLibrary.Objects;
using System.Collections.Generic;

namespace MethodsLibrary.Methods
{
    public class BinaryTreeLevelOrderTraversal
    {
        public static IList<IList<int>> LevelOrder(TreeNode root)
        {
            IList<IList<int>> result = new List<IList<int>>();
            if (root == null)
            {
                return result;
            }

            Queue<TreeNode> queue = new Queue<TreeNode>();
            
            queue.Enqueue(root);
            while (queue.Count != 0)
            {
                IList<int> level = new List<int>();
                int size = queue.Count;
                while (size > 0)
                {
                    TreeNode node = queue.Dequeue();
                    level.Add(node.val);
                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }
                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }
                    size--;
                }
                result.Add(level);
            }
            return result;
        }
    }
}
