using MethodsLibrary.Objects;
using System.Collections.Generic;

namespace MethodsLibrary.Methods
{
    public class BinaryTreeInorderTraversal
    {
        public static IList<int> InorderTraversal(TreeNode root)
        {
            IList<int> result = new List<int>();
            if (root == null)
            {
                return null;
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

    }
}
