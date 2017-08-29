using System;
using System.Collections.Generic;
using Methods.Tests.Objects;
using MethodsLibrary.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Methods.Tests.Tests
{
    [TestClass]
    public class SudokuSolverTest
    {
        /// <summary>
        /// List to store test data set
        /// </summary>
        public List<ValidSudokuTestData> TestDataList { set; get; }

        /// <summary>
        /// Initialize test data for TwoSum
        /// </summary>
        [TestInitialize]
        public void SetUp()
        {
            TestDataList = new List<ValidSudokuTestData>
            {
                new ValidSudokuTestData
                {
                    InputArray = new[,]
                    {
                        {'5', '3', '.', '.', '7', '.', '.', '.', '.' },
                        {'6', '.', '.', '1', '9', '5', '.', '.', '.' },
                        {'.', '9', '8', '.', '.', '.', '.', '6', '.' },
                        {'8', '.', '.', '.', '6', '.', '.', '.', '3' },
                        {'4', '.', '.', '8', '.', '3', '.', '.', '1' },
                        {'7', '.', '.', '.', '2', '.', '.', '.', '6' },
                        {'.', '6', '.', '.', '.', '.', '2', '8', '.' },
                        {'.', '.', '.', '4', '1', '9', '.', '.', '5' },
                        {'.', '.', '.', '.', '8', '.', '.', '7', '9' }
                    },
                    OutputBool = true
                }
            };
        }

        /// <summary>
        /// Test method to verify if the method works
        /// </summary>
        [TestMethod]
        public void sudokuSolverTest()
        {
            foreach (ValidSudokuTestData testData in TestDataList)
            {
                Console.WriteLine("Test input matrix: ");
                char[,] matrix = testData.InputArray;
                for (int i = 0; i <= matrix.GetUpperBound(0); i++)
                {
                    for (int j = 0; j <= matrix.GetUpperBound(1); j++)
                    {
                        Console.Write(matrix[i, j] + ", ");
                    }
                    Console.WriteLine();
                }
                SudokuSolver.SolveSudoku(matrix);
                Console.WriteLine("Actual output: " );
                for (int i = 0; i <= matrix.GetUpperBound(0); i++)
                {
                    for (int j = 0; j <= matrix.GetUpperBound(1); j++)
                    {
                        Console.Write(matrix[i, j] + ", ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
