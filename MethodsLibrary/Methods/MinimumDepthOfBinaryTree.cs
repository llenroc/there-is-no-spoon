


namespace MethodsLibrary.Methods
{
    using MethodsLibrary.Objects;
    using System;
    using System.Collections.Generic;


    public class MinimumDepthOfBinaryTree
    {

        // Test cases:
        // [3,9,20,null,null,15,7]
        // [1,2]
        // [1,2,3,4,5]

        // Level order traverse to find the leaf 
        // then compare the depth (level) of this leaf with current minimum depth.
        public int MinDepthLevelOrderTraverse(TreeNode root)
        {
            if (root == null) return 0;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            int min = int.MaxValue;
            int level = 0;
            while (queue.Count != 0)
            {
                int size = queue.Count;
                level++;
                while (size > 0)
                {
                    TreeNode temp = queue.Dequeue();
                    if (temp.left == null && temp.right == null) { min = Math.Min(min, level); }
                    if (temp.left != null) { queue.Enqueue(temp.left); }
                    if (temp.right != null) { queue.Enqueue(temp.right); }
                    size--;
                }
            }
            return min;
        }


        public int MinDepth(TreeNode root)
        {
            if (root == null) return 0;
            if (root.left == null) return MinDepth(root.right) + 1;
            if (root.right == null) return MinDepth(root.left) + 1;

            return Math.Min(MinDepth(root.left), MinDepth(root.right)) + 1;
        }
    }
}
