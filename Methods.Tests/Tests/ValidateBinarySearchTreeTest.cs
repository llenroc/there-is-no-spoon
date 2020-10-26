




namespace Methods.Tests.Tests
{
    using MethodsLibrary.Methods;
    using MethodsLibrary.Objects;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ValidateBinarySearchTreeTest
    {
        [TestMethod]
        public void IsValidBSTTest()
        {
            int?[] treeNodes1 = new int?[] {4, 1, 5, null, null, 3, 6 }; //false  //{ 2, 1, 3 }; //truee

            int?[] treeNodes2 = new int?[] { 5, 1, 4, null, null, 3, 6 }; // false

            TreeNode root1 = Helper.BuildTreeFromLevelOrderArray(treeNodes1, 0);

            TreeNode root2 = Helper.BuildTreeFromLevelOrderArray(treeNodes2, 0);

            System.Console.WriteLine(ValidateBinarySearchTree.IsValidBSTIteration(root1));
            //System.Console.WriteLine(ValidateBinarySearchTree.IsValidBST(root2));

        }
    }
}
