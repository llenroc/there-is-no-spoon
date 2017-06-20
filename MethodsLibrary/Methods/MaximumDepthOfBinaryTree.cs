
using MethodsLibrary.Objects;
using System;

namespace MethodsLibrary.Methods
{
    public class MaximumDepthOfBinaryTree
    {
        /// <summary>
        /// Divide Conquer 
        /// </summary>
        /// <param name="root"> Root of the tree</param>
        /// <returns> The maximum depth of the tree </returns>
        public static int MaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            // Devide the problem to left and right tree
            // and find the depth of each tree
            int left = MaxDepth(root.left);
            int right = MaxDepth(root.right);
            // Return the maximum depth of the child tree and 
            // then back to the root and compare again
            return Math.Max(left, right) + 1;
        }

        private static int depth;
        /// <summary>
        /// Recursive traversal to find the maximum depth of the tree
        /// </summary>
        /// <param name="root"> The root of the tree </param>
        /// <returns> The maximum depth of the tree </returns>
        public static int maxDepth(TreeNode root)
        {
            depth = 0;
            helper(root, 1);
            return depth;
        }
        
        private static void helper(TreeNode node, int curtDepth)
        {
            if (node == null)
            {
                return;
            }
            if (curtDepth > depth)
            {
                depth = curtDepth;
            }
            helper(node.left, curtDepth + 1);
            helper(node.right, curtDepth + 1);
        }
    }
}
