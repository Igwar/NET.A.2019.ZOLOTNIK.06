using Microsoft.VisualStudio.TestTools.UnitTesting;
using JaggedArrayLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArrayLib.Tests
{
    [TestClass()]
    public class ExtenTests
    {
        [TestMethod()]
        public void SortBySumOfTheElementsTest()
        {
            int[][] b = new int[3][];

            b[0] = new int[2] { 3, 5 };

            b[1] = new int[4] { 8, 5, 3, 2 };
            b[2] = new int[3] { 2, 9, 1 };
            JaggedArray a = new JaggedArray(b);
            int[][] f = new int[3][];

            b[0] = new int[2] { 3, 5 };

            b[1] = new int[3] { 2, 9, 1 };

            b[2] = new int[4] { 8, 5, 3, 2 };
            JaggedArray expect = new JaggedArray(f);
            a.SortByMinimumOfTheElements();
            for (int i = 0; i < expect.Array.Length; i++)
            {
                for (int j = 0; j < expect.Array[i].Length; j++)
                {
                    Assert.AreEqual(expect.Array[i][j], a.Array[i][j]);
                }
            }

        }

        [TestMethod()]
        public void SortByMaximumOfTheElementsTest()
        {
            int[][] b = new int[3][];

            b[0] = new int[2] { 3, 5 };

            b[1] = new int[3] { 2, 9, 1 };

            b[2] = new int[4] { 8, 5, 3, 2 };
            JaggedArray a = new JaggedArray(b);
            int[][] f = new int[3][];

            b[0] = new int[2] { 3, 5 };
           
            b[1] = new int[4] { 8, 5, 3, 2 };

            b[2] = new int[3] { 2, 9, 1 };
            JaggedArray expect = new JaggedArray(f);
            a.SortByMinimumOfTheElements();
            for (int i = 0; i < expect.Array.Length; i++)
            {
                for (int j = 0; j < expect.Array[i].Length; j++)
                {
                    Assert.AreEqual(expect.Array[i][j], a.Array[i][j]);
                }
            }
        }

        [TestMethod()]
        public void SortByMinimumOfTheElementsTest()
        {
            int[][] b = new int[3][];

            b[0] = new int[2] { 3, 5 };

            b[1] = new int[3] { 2, 9, 1 };

            b[2] = new int[4] { 8, 5, 3, 2 };
            JaggedArray a = new JaggedArray(b);
            int[][] f = new int[3][];

            b[2] = new int[2] { 3, 5 };

            b[0] = new int[3] { 2, 9, 1 };

            b[1] = new int[4] { 8, 5, 3, 2 };
            JaggedArray expect = new JaggedArray(f);
            a.SortByMinimumOfTheElements();
            for (int i = 0; i < expect.Array.Length; i++)
            {
                for (int j = 0; j < expect.Array[i].Length; j++)
                {
                    Assert.AreEqual(expect.Array[i][j], a.Array[i][j]);
                }
            }
        }
    }
}