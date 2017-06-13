using MethodsLibrary.Objects;
using System.Collections.Generic;

namespace MethodsLibrary.Methods
{
    public class BinaryTreePostorderTraversal
    {
        // Recursion
        public static IList<int> PostorderTraversal(TreeNode root)
        {
            IList<int> result = new List<int>();
            if (root == null)
            {
                return result;
            }
            traverse(root, result);
            return result;
        }

        public static void traverse(TreeNode node, IList<int> list)
        {
            if (node == null)
            {
                return;
            }
            traverse(node.left, list);
            traverse(node.right, list);
            list.Add(node.val);
        }

        //Iteration
        public static IList<int> IterativePostorderTraversal(TreeNode root)
        {
            IList<int> postOrder = new List<int>();
            if(root == null)
            {
                return postOrder;
            }
            Stack<TreeNode> stack = new Stack<TreeNode>();

            TreeNode prev = null; // previously traversed node

            TreeNode curr = root;

            stack.Push(root);

            while (stack.Count != 0)
            {

                curr = stack.Peek();

                if (prev == null || prev.left == curr || prev.right == curr)
                { // traverse down the tree

                    if (curr.left != null)
                    {

                        stack.Push(curr.left);

                    }
                    else if (curr.right != null)
                    {

                        stack.Push(curr.right);

                    }

                }
                else if (curr.left == prev)
                { // traverse up the tree from the left

                    if (curr.right != null)
                    {

                        stack.Push(curr.right);

                    }

                }
                else
                { // traverse up the tree from the right

                    postOrder.Add(curr.val);

                    stack.Pop();

                }

                prev = curr;

            }




            return postOrder;
        }
    }
}
