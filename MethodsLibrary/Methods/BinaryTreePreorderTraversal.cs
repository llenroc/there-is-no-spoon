using MethodsLibrary.Objects;
using System.Collections.Generic;

namespace MethodsLibrary.Methods
{
    public class BinaryTreePreorderTraversal
    {
        // Recursive
        public static IList<int> PreorderTraversal(TreeNode root)
        {
            IList<int> result = new List<int>();
            if (root == null)
            {
                return result;
            }
            traverse(root, result);
            return result;
        }

        public static void traverse (TreeNode node, IList<int> list)
        {
            if (node == null)
            {
                return;
            }
            list.Add(node.val);
            traverse(node.left, list);
            traverse(node.right, list);
        }

        // Iterative
        public static IList<int> IterativePreorderTraversal(TreeNode root)
        {
            IList<int> preorder = new List<int>();
            if (root == null)
            {
                return preorder;
            }
            Stack<TreeNode> stack = new Stack<TreeNode>();

            stack.Push(root);

            while (stack.Count != 0)
            {

                TreeNode node = stack.Pop();

                preorder.Add(node.val);

                if (node.right != null)
                {

                    stack.Push(node.right);

                }

                if (node.left != null)
                {

                    stack.Push(node.left);

                }

            }
            return preorder;
        }
    }
}
