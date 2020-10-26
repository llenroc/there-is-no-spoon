namespace MethodsLibrary.Methods
{
    using MethodsLibrary.Objects;
    using System.Collections.Generic;
    using System.Linq;

    public class BinaryTreeLevelOrderTraversalII
    {
        public static IList<IList<int>> LevelOrderBottom(TreeNode root)
        {
            List<IList<int>> result = new List<IList<int>>();
            if(root == null)
            {
                return result;
            }

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            //Stack<IList<int>> stack = new Stack<IList<int>>();

            while(queue.Count != 0)
            {
                IList<int> level = new List<int>(); // list to store all the val on each level
                int levelSize = queue.Count; // number of node on this level
                while (levelSize > 0)
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
                    
                    levelSize--;
                }
                result.Add(level);
            }
            result.Reverse();

            return result;
        }


    }
}
