
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.ChumachenkoZS.Sprint5.Task6.V5.Lib;

namespace Tyuiu.ChumachenkoZS.Sprint5.Task6.V5.Test
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
                "InPutDataFileTask6V5.txt"
            );

            File.WriteAllText(path, "Hello WORLD! AbCd EfG");

            int res = ds.Calculate(path);

            Assert.AreEqual(10, res);
        }

        [TestMethod]
        public void ValidCalculateWithoutUppercase()
        {
            DataService ds = new DataService();

            string path = Path.Combine(
                Path.GetTempPath(),
                "TestTask6V5.txt"
            );

            File.WriteAllText(path, "hello world 123");

            int res = ds.Calculate(path);

            Assert.AreEqual(0, res);
        }
    }
}
