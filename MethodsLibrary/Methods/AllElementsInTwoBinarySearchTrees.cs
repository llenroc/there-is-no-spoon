


namespace MethodsLibrary.Methods
{
    using MethodsLibrary.Objects;
    using System.Collections.Generic;

    public class AllElementsInTwoBinarySearchTrees
    {
        public static IList<int> GetAllElements(TreeNode root1, TreeNode root2)
        {
            IList<int> result = new List<int>();
            if (root1 == null && root2 == null)
            {
                return result;
            }

            IList<int> result1 = new List<int>();
            InOrderTraverse(root1, result1);

            IList<int> result2 = new List<int>();
            InOrderTraverse(root2, result2);

            result = MergeTwoSortedLists(result1, result2);


            return result;
        }

        private static void InOrderTraverse(TreeNode node, IList<int> list)
        {
            if (node == null)
            {
                return;
            }

            InOrderTraverse(node.left, list);
            list.Add(node.val);
            InOrderTraverse(node.right, list);

        }

        private static IList<int> MergeTwoSortedLists(IList<int> list1, IList<int> list2)
        {
            IList<int> result = new List<int>();
            int i1 = 0;
            int i2 = 0;
            while (i1 < list1.Count && i2 < list2.Count)
            {
                if (list1[i1] <= list2[i2])
                {
                    result.Add(list1[i1]);
                    i1++;
                }
                else
                {
                    result.Add(list2[i2]);
                    i2++;
                }
            }


            if (i1 == list1.Count)
            {
                while (i2 < list2.Count)
                {
                    result.Add(list2[i2]);
                    i2++;
                }
            }
            if (i2 == list2.Count)
            {
                while (i1 < list1.Count)
                {
                    result.Add(list1[i1]);
                    i1++;
                }
            }

            return result;
        }


        public IList<int> GetAllElementsIteration(TreeNode root1, TreeNode root2)
        {
            IList<int> result = new List<int>();

            Stack<TreeNode> stack1 = new Stack<TreeNode>();
            Stack<TreeNode> stack2 = new Stack<TreeNode>();

            while (root1 != null || root2 != null || stack1.Count > 0 || stack2.Count > 0)
            {
                while (root1 != null)
                {
                    stack1.Push(root1);
                    root1 = root1.left;
                }

                while (root2 != null)
                {
                    stack2.Push(root2);
                    root2 = root2.left;
                }

                if (stack1.Count > 0 && stack2.Count > 0)
                {
                    if (stack1.Peek().val < stack2.Peek().val)
                    {
                        root1 = stack1.Pop();
                        result.Add(root1.val);
                        root1 = root1.right;
                    }
                    else
                    {
                        root2 = stack2.Pop();
                        result.Add(root2.val);
                        root2 = root2.right;
                    }
                }
                else if (stack1.Count > 0)
                {
                    root1 = stack1.Pop();
                    result.Add(root1.val);
                    root1 = root1.right;
                }
                else
                {
                    root2 = stack2.Pop();
                    result.Add(root2.val);
                    root2 = root2.right;
                }
            }

            return result;
        }
    }
}
