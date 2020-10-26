


namespace MethodsLibrary.Methods
{
    using MethodsLibrary.Objects;
    using System;
    using System.Collections.Generic;

    public class MinimumAbsoluteDifferenceInBST
    {
        public int GetMinimumDifference(TreeNode root)
        {
            int min = int.MaxValue;
            int preVal = -1;
            Stack<TreeNode> stack = new Stack<TreeNode>();
            while (root != null || stack.Count != 0)
            {
                while (root != null)
                {
                    stack.Push(root);
                    root = root.left;
                }
                root = stack.Pop();
                if (preVal != -1)
                {
                    min = Math.Min(Math.Abs(root.val - preVal), min);
                }

                preVal = root.val;
                root = root.right;
            }

            return min;
        }
    }
}
