using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ChumachenkoZS.Sprint5.Task1.V27.Lib;

namespace Tyuiu.ChumachenkoZS.Sprint5.Task1.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        private static readonly double[] Expected =
        {
            4.34, 4.16, 3.71, 3.27, 2.93, 2.5, 0.71, -47.61, 55.15, 45.17, 14.97
        };

        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            Assert.AreEqual(4.34, ds.Calculate(-5));
            Assert.AreEqual(2.5, ds.Calculate(0));
            Assert.AreEqual(-47.61, ds.Calculate(2));
        }

        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            double[] res = ds.GetMassFunction(-5, 5);

            CollectionAssert.AreEqual(Expected, res);
        }

        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            DataService ds = new DataService();

            string path = ds.SaveToFileTextData(-5, 5);

            Assert.IsTrue(File.Exists(path));
            Assert.AreEqual("OutPutFileTask1.txt", Path.GetFileName(path));

            string[] lines = File.ReadAllLines(path);
            Assert.AreEqual(Expected.Length, lines.Length);
            Assert.AreEqual("4.34", lines[0]);
            Assert.AreEqual("14.97", lines[^1]);
        }
    }
}
