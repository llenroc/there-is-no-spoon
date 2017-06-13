using MethodsLibrary.Objects;
using System.Collections.Generic;

namespace MethodsLibrary.Methods
{
    public class BinaryTreeInorderTraversal
    {
        // Recursion
        public static IList<int> InorderTraversal(TreeNode root)
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
            traverse(node.left, list);
            list.Add(node.val);
            traverse(node.right, list);
        }

        // Iterative
        public static IList<int> IterativeInorderTraversal(TreeNode root)
        {
            IList<int> inorder = new List<int>();
            if (root == null)
            {
                return inorder;
            }
            Stack<TreeNode> stack = new Stack<TreeNode>();

            TreeNode curt = root;

            while (curt != null || stack.Count != 0)
            {

                while (curt != null)
                {

                    stack.Push(curt);

                    curt = curt.left;

                }

                curt = stack.Pop();

                inorder.Add(curt.val);

                curt = curt.right;

            }

            return inorder;
        }
    }
}
