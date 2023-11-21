using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IvanovSI.Sprint5.Task3.V3.Lib;
using System.IO;
namespace Tyuiu.IvanovSI.Sprint5.Task3.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\seemoon\source\repos\Tyuiu.IvanovSI.Sprint5\Tyuiu.IvanovSI.Sprint5.Task3.V3\bin\Debug\OutPutFileTask3.bin";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
