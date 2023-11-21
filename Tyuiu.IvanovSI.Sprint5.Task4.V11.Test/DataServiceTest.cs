using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IvanovSI.Sprint5.Task4.V11.Lib;
using System.IO;
namespace Tyuiu.IvanovSI.Sprint5.Task4.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask4V11.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
        [TestMethod]
        public void TestMethod2()
        {
            double x = 2.61;
            double y = Math.Round((Math.Sin(x) + (Math.Pow(x,2) / 2)), 3);
            double res = 3.913;
            Assert.AreEqual(y, res);
        }
    }
}
