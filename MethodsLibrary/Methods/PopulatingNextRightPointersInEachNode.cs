namespace MethodsLibrary.Methods
{
    using MethodsLibrary.Objects;
    using System.Collections.Generic;

    public class PopulatingNextRightPointersInEachNode
    {
        public Node Connect(Node root)
        {
            if (root == null)
            {
                return root;
            }
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);
            while (queue.Count != 0)
            {
                Node pre = null;
                int levelSize = queue.Count;
                while (levelSize > 0)
                {
                    Node temp = queue.Dequeue();
                    temp.next = pre;
                    pre = temp;
                    if (temp.right != null)
                    {
                        queue.Enqueue(temp.right);
                    }
                    if (temp.left != null)
                    {
                        queue.Enqueue(temp.left);
                    }
                    levelSize--;
                }

            }

            return root;
        }

        public Node ConnectRecursion(Node root)
        {
            //利用上一层的next指针 O(1)
            if (root == null) return null;
            if (root.left != null) root.left.next = root.right;
            if (root.right != null) root.right.next = root.next?.left;
            root.left = Connect(root.left);
            root.right = Connect(root.right);
            return root;
        }

        public Node ConnectList(Node root)
        {
            if (root == null)
            {
                return root;
            }

            // 从根节点开始
            Node leftmost = root;

            while (leftmost.left != null)
            {

                // 遍历这一层节点组织成的链表，为下一层的节点更新 next 指针
                Node head = leftmost;

                while (head != null)
                {

                    // CONNECTION 1
                    head.left.next = head.right;

                    // CONNECTION 2
                    if (head.next != null)
                    {
                        head.right.next = head.next.left;
                    }

                    // 指针向后移动
                    head = head.next;
                }

                // 去下一层的最左的节点
                leftmost = leftmost.left;
            }

            return root;
        }
    }
}
