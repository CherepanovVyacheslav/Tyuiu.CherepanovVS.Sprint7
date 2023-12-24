using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.CherepanovVS.Sprint7.Lib;

namespace Tyuiu.CherepanovVS.Sprint7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ReadData()
        {
            string path = $@"C:\Users\Вячеслав\source\repos\Tyuiu.CherepanovVS.Sprint7\Tyuiu.CherepanovVS.Sprint7\bin\Debug\InputFileTaskProject.V11.csv";
            FileInfo file = new FileInfo(path);
            bool res = file.Exists;
            bool wait = true;
            Assert.AreEqual(res, wait);
        }

        [TestMethod]
        public void Arithmeticmean()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\Вячеслав\source\repos\Tyuiu.CherepanovVS.Sprint7\Tyuiu.CherepanovVS.Sprint7\bin\Debug\InputFileTaskProject.V11(числа).csv";
            double result = ds.LoadFromDataFile(path);
            double wait = 57098.16;
            Assert.AreEqual(result, wait);


        }
    }
}
