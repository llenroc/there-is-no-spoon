using Microsoft.VisualStudio.TestTools.UnitTesting;
using MethodsLibrary.Objects;
using MethodsLibrary.Methods;
using System;

namespace Methods.Tests.Tests
{
    [TestClass]
    public class MaximumDepthofBinaryTreeTest
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
        public void maximumDepthofBinaryTreeTest()
        {
            var dcResult = MaximumDepthOfBinaryTree.MaxDepth(root);
            Console.WriteLine("Max depth of the tree is (Divide & Conquer): " + dcResult);
            
            Console.WriteLine();
            var recursiveResult = MaximumDepthOfBinaryTree.maxDepth(root);
            Console.WriteLine("Max depth of the tree is (Recursive): " + recursiveResult);
        }
    }
}