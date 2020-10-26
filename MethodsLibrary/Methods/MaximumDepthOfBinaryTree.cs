
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
            // This is more like a bottom to top approach.

            // Devide the problem to left and right tree
            // and find the depth of each tree
            int left = MaxDepth(root.left);
            int right = MaxDepth(root.right);
            // Return the maximum depth of the child tree and 
            // then back to the root and compare again
            return Math.Max(left, right) + 1;
        }


        /// <summary>
        /// Recursive traversal to find the maximum depth of the tree
        /// </summary>
        /// <param name="root"> The root of the tree </param>
        /// <returns> The maximum depth of the tree </returns>
        public static int maxDepth(TreeNode root)
        {
            if(root == null)
            {
                return 0;
            }
            
            // This is a top to bottom approach. More intuitive I think.
            return FindingMax(root, 1, 0);
        }

        private static int FindingMax(TreeNode root, int level, int max)
        {
            if (root == null)
            {
                return max;
            }
            if (level >= max)
            {
                max = level;
            }
            max = FindingMax(root.left, level + 1, max);
            max = FindingMax(root.right, level + 1, max);
            return max;
        }
    }
}
