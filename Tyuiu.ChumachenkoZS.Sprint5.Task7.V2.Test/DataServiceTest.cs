
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.ChumachenkoZS.Sprint5.Task7.V2.Lib;

namespace Tyuiu.ChumachenkoZS.Sprint5.Task7.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadDataAndSave()
        {
            DataService ds = new DataService();

            string inputPath = Path.Combine(
                Path.GetTempPath(),
                "InPutDataFileTask7V2.txt"
            );

            File.WriteAllText(inputPath, "abc123def456");

            string path = ds.LoadDataAndSave(inputPath);

            Assert.IsTrue(File.Exists(path));
            Assert.AreEqual(
                "OutPutDataFileTask7V2.txt",
                Path.GetFileName(path)
            );

            Assert.AreEqual("abc###def###", File.ReadAllText(path));

            File.Delete(inputPath);
            File.Delete(path);
        }
    }
}
