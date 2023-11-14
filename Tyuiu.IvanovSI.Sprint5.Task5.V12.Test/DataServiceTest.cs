using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IvanovSI.Sprint5.Task5.V12.Lib;
using System.IO;
namespace Tyuiu.IvanovSI.Sprint5.Task5.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\seemoon\source\repos\Tyuiu.IvanovSI.Sprint5\Tyuiu.IvanovSI.Sprint5.Task5.V12\bin\Debug\OutPutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
