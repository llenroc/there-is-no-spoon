using Microsoft.VisualStudio.TestTools.UnitTesting;
using MethodsLibrary.Objects;
using MethodsLibrary.Methods;
using System;

namespace Methods.Tests.Tests
{
    [TestClass]
    public class BinaryTreeTraversalTest
    {
        private TreeNode root;

        [TestInitialize]
        public void Initialization()
        {
            root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);
            root.left.left = new TreeNode(4);
            root.left.right = new TreeNode(5);
            root.right.left = new TreeNode(6);
            root.right.right = new TreeNode(7);
        }

        [TestMethod]
        public void binaryTreePreorderTraversalTest()
        {
            var result = BinaryTreePreorderTraversal.PreorderTraversal(root);
            Console.WriteLine("Preorder Traversal: ");
            foreach (int i in result)
            {
                Console.Write(i + ", ");
            }

            Console.WriteLine();
            var iterativePreorder = BinaryTreePreorderTraversal.IterativePreorderTraversal(root);
            Console.WriteLine("Preorder Traversal: ");
            foreach (int i in iterativePreorder)
            {
                Console.Write(i + ", ");
            }

        }

        [TestMethod]
        public void binaryTreeInorderTraversalTest()
        {
            var result = BinaryTreeInorderTraversal.InorderTraversal(root);
            Console.WriteLine("Inorder Traversal: ");
            foreach (int i in result)
            {
                Console.Write(i + ", ");
            }

            Console.WriteLine();
            var iterativeInorder = BinaryTreeInorderTraversal.IterativeInorderTraversal(root);
            Console.WriteLine("Inorder Traversal: ");
            foreach (int i in iterativeInorder)
            {
                Console.Write(i + ", ");
            }
        }

        [TestMethod]
        public void binaryTreePostorderTraversalTest()
        {
            var result = BinaryTreePostorderTraversal.PostorderTraversal(root);
            Console.WriteLine("Postorder Traversal: ");
            foreach (int i in result)
            {
                Console.Write(i + ", ");
            }

            Console.WriteLine();
            var iterativePostorder = BinaryTreePostorderTraversal.IterativePostorderTraversal(root);
            Console.WriteLine("Inorder Traversal: ");
            foreach (int i in iterativePostorder)
            {
                Console.Write(i + ", ");
            }
        }
    }
}