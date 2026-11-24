
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.ChumachenkoZS.Sprint5.Task5.V17.Lib;

namespace Tyuiu.ChumachenkoZS.Sprint5.Task5.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            string path = Path.Combine(
                Path.GetTempPath(),
                "InPutDataFileTask5V17.txt"
            );

            File.WriteAllText(path, "2 3 4 5 6 7 8 9 10 11");

            int res = ds.Calculate(path);

            Assert.AreEqual(28, res);
        }

        [TestMethod]
        public void ValidCalculateWithRealNumbers()
        {
            DataService ds = new DataService();

            string path = Path.Combine(
                Path.GetTempPath(),
                "TestTask5V17.txt"
            );

            File.WriteAllText(path, "2.5 3.0 5.123 7.8 11.0");

            int res = ds.Calculate(path);

            Assert.AreEqual(14, res);
        }
    }
}
