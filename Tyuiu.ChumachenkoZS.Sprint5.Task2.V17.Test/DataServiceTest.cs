
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.ChumachenkoZS.Sprint5.Task2.V17.Lib;

namespace Tyuiu.ChumachenkoZS.Sprint5.Task2.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] matrix =
            {
                { 2, 1, 7 },
                { 1, 2, 4 },
                { 2, 3, 4 }
            };

            int[,] res = ds.Calculate(matrix);

            int[,] expected =
            {
                { 2, 0, 0 },
                { 0, 2, 4 },
                { 2, 0, 4 }
            };

            CollectionAssert.AreEqual(
                expected.Cast<int>().ToArray(),
                res.Cast<int>().ToArray()
            );
        }

        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            DataService ds = new DataService();

            int[,] matrix =
            {
                { 2, 1, 7 },
                { 1, 2, 4 },
                { 2, 3, 4 }
            };

            string path = ds.SaveToFileTextData(matrix);

            Assert.IsTrue(File.Exists(path));

            Assert.AreEqual(
                "OutPutFileTask2.csv",
                Path.GetFileName(path)
            );

            string expected =
                "2;0;0" + Environment.NewLine +
                "0;2;4" + Environment.NewLine +
                "2;0;4";

            Assert.AreEqual(expected, File.ReadAllText(path));
        }
    }
}
