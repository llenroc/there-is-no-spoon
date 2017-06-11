using MethodsLibrary.Methods;
using MethodsLibrary.Objects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Methods.Tests.Tests
{
    [TestClass]
    public class BinaryTreeLevelOrderTraversalTest
    {
        private TreeNode root;

        [TestInitialize]
        public void Initialization()
        {
            /*
             *     3
             *    / \
             *   9  20
             *     /  \
             *    15   7
             */
            root = new TreeNode(3);
            root.left = new TreeNode(9);
            root.right = new TreeNode(20);
            root.right.left = new TreeNode(15);
            root.right.right = new TreeNode(7);
        }

        [TestMethod]
        public void binaryTreeLevelOrderTraversalTest()
        {
            /*
             * [
             *   [3],
             *   [9,20],
             *   [15,7]
             * ]
             */
            var result = BinaryTreeLevelOrderTraversal.LevelOrder(root);
            Console.WriteLine("Level Order Traversal: ");
            for(int i=0; i<result.Count; i++)
            {
                foreach(int node in result[i])
                {
                    Console.Write(node + ", ");
                }
                Console.WriteLine();
            }
            
        }
    }
}
