using MethodsLibrary.Methods;


namespace Methods.Tests.Tests
{
    using MethodsLibrary.Objects;
    using Microsoft.VisualStudio.TestTools.UnitTesting;


    [TestClass]
    public class BinaryTreeLevelOrderTraversalIITest
    {
        [TestMethod]
        public void LevelOrderBottomTest()
        {
            int?[] treeNodes = new int?[] { 3, 9, 20, null, null, 15, 7 };

            TreeNode root = Helper.BuildTreeFromLevelOrderArray(treeNodes, 0);

            var output = BinaryTreeLevelOrderTraversalII.LevelOrderBottom(root);

            foreach (var n in output)
            {
                foreach (var x in n)
                {
                    System.Console.Write("{0} ", x);
                }
                System.Console.WriteLine();
            }
        }
    }
}
