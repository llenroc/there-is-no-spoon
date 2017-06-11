using MethodsLibrary.Objects;
using System.Collections.Generic;

namespace MethodsLibrary.Methods
{
    public class BinaryTreePreorderTraversal
    {
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

    }
}
