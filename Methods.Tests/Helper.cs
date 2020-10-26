
namespace Methods.Tests
{
    using MethodsLibrary.Objects;
    using System.Collections.Generic;
    using System;

    public class Helper
    {
        public static TreeNode BuildTreeFromLevelOrderArray(int?[] treeNodes, int i)
        {
            if (i >= treeNodes.Length || treeNodes[i] == null) return null;
            TreeNode next = new TreeNode((int)treeNodes[i]);
            next.left = BuildTreeFromLevelOrderArray(treeNodes, 2 * i + 1);
            next.right = BuildTreeFromLevelOrderArray(treeNodes, 2 * i + 2);
            return next;
        }

        public static void PrintTreeByLevelOrder (TreeNode root)
        {
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while(queue.Count != 0)
            {
                int size = queue.Count;
                while(size > 0)
                {
                    TreeNode node = queue.Dequeue();
                    System.Console.Write(node.val + " ");
                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }
                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }
                    size--;
                }

                System.Console.WriteLine();
            }

        }

        public static ListNode CreateListFromArray(int[] nums)
        {
            ListNode builder = new ListNode();
            ListNode head = builder;

            foreach (var n in nums)
            {
                builder.next = new ListNode(n);
                builder = builder.next;
            }
            return head.next;
        }

        public static void PrintArray(int[] nums)
        {
            Console.WriteLine("The array is: ");
            if (nums == null || nums.Length == 0)
            {
                Console.Write("");
            }
            foreach(var n in nums)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();
        }

        public static void PrintList(ListNode head)
        {
            Console.WriteLine("The List is;");
            if (head == null)
            {
                Console.Write("");
            }

            while(head != null)
            {
                Console.Write(head.val + " -> ");
                head = head.next;
            }
            Console.WriteLine();
        }
    }
}
