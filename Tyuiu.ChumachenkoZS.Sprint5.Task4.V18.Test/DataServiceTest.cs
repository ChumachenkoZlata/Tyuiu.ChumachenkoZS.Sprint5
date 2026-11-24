using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ChumachenkoZS.Sprint5.Task4.V18.Lib;
using System;
using System.IO;

namespace Tyuiu.ChumachenkoZS.Sprint5.Task4.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            string path = Path.Combine(Path.GetTempPath(), "InPutData.txt");

            File.WriteAllText(path, "4");

            double res = ds.Calculate(path);

            double wait = Math.Round(Math.Cos(4) + Math.Pow(4, 2) / 2, 3);

            Assert.AreEqual(wait, res);
        }
    }
}
