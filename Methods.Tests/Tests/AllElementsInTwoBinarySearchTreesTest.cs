namespace Methods.Tests.Tests
{
    using MethodsLibrary.Objects;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Collections.Generic;
    using MethodsLibrary.Methods;

    [TestClass]
    public class AllElementsInTwoBinarySearchTreesTest
    {
        [TestMethod]
        public void GetAllElementsTest()
        {
            int?[] treeNode1 = new int?[] {1, null, 8 };
            int?[] treeNode2 = new int?[] { 8,1 };

            TreeNode root1 = Helper.BuildTreeFromLevelOrderArray(treeNode1, 0);
            TreeNode root2 = Helper.BuildTreeFromLevelOrderArray(treeNode2, 0);

            IList<int> output = AllElementsInTwoBinarySearchTrees.GetAllElements(root1, root2);

            foreach(var n in output)
            {
                System.Console.Write("{0} ", n);
            }

        }
    }
}
