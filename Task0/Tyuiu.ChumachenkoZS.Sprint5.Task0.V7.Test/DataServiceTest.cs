using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ChumachenkoZS.Sprint5.Task0.V7.Lib;

namespace Tyuiu.ChumachenkoZS.Sprint5.Task0.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            double res = ds.Calculate(4);

            Assert.AreEqual(-6, res);
        }

        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            DataService ds = new DataService();

            string path = ds.SaveToFileTextData(4);

            Assert.IsTrue(File.Exists(path));
            Assert.AreEqual("OutPutFileTask0.txt", Path.GetFileName(path));
            Assert.AreEqual("-6", File.ReadAllText(path));
        }
    }
}
