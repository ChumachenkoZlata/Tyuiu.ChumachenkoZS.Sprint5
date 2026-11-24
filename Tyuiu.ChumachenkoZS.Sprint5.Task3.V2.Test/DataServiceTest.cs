
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.ChumachenkoZS.Sprint5.Task3.V2.Lib;

namespace Tyuiu.ChumachenkoZS.Sprint5.Task3.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            double res = ds.Calculate(3);

            Assert.AreEqual(6.695, res);
        }

        [TestMethod]
        public void ValidSaveToFileBinaryData()
        {
            DataService ds = new DataService();

            string path = ds.SaveToFileBinaryData(3);

            Assert.IsTrue(File.Exists(path));

            Assert.AreEqual(
                "OutPutFileTask3.bin",
                Path.GetFileName(path)
            );

            using (BinaryReader reader = new BinaryReader(File.OpenRead(path)))
            {
                double res = reader.ReadDouble();

                Assert.AreEqual(6.695, res);
            }
        }
    }
}
