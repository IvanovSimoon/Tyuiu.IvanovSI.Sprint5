using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IvanovSI.Sprint5.Task7.V5.Lib;
using System.IO;
namespace Tyuiu.IvanovSI.Sprint5.Task7.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\seemoon\source\repos\Tyuiu.IvanovSI.Sprint5\Tyuiu.IvanovSI.Sprint5.Task7.V5\bin\Debug\OutPutDataFileTask7.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
