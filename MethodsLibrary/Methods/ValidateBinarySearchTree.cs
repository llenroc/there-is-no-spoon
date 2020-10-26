
namespace MethodsLibrary.Methods
{
    using MethodsLibrary.Objects;
    using System.Collections.Generic;

    public class ValidateBinarySearchTree
    {

        static long preVal = long.MinValue;

        public static bool IsValidBST(TreeNode root)
        {
            return InOrderTraverse(root);
        }

        private static bool InOrderTraverse(TreeNode node)
        {
            if (node == null)
            {
                return true;
            }

            bool left = InOrderTraverse(node.left);
            if (preVal>=node.val)
            {
                return false;
            }
            preVal=node.val;
            bool right = InOrderTraverse(node.right);
            return left && right;
        }

        
        public static bool IsValidBSTIteration(TreeNode root)
        {
            if(root == null)
            {
                return true;
            }
            long preVal = long.MinValue;

            Stack<TreeNode> stack = new Stack<TreeNode>();
            while (root != null || stack.Count != 0)
            {
                while (root != null)
                {
                    stack.Push(root);
                    root = root.left;
                }
                root = stack.Pop();
                if (preVal >= root.val)
                {
                    return false;
                }
                preVal = root.val;
                root = root.right;                
            }
            return true;
        }
    }
}
