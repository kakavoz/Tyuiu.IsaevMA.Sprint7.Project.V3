using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.IsaevMA.Sprint7.Project.V3.Lib;

namespace Tyuiu.IsaevMA.Sprint7.Project.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ProjectTestGetData()
        {
            DataService ds = new DataService();

            string path =
                $@"C:\Users\max\source\repos\Tyuiu.IsaevMA.Sprint7.Project.V3\Tyuiu.IsaevMA.Sprint7.Project.V3\bin\DataSprint7\Classroom.csv";
            string[,] res = ds.GetData(path);

            string[,] wait =
            {
                { "1", "101", "Кабинет Физики" },
                { "2", "102", "Кабинет Алгебры" },
                { "3", "103", "Кабинет Истории" },
                { "4", "104", "Кабинет  Русского язфка" },
                { "5", "105", "Кабинет Геометрии" },
                { "6", "106", "Кабинет Информатики" },
                { "7", "107", "Кабинет Физ.Культуры" },
            };
            CollectionAssert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ProjectTestGetCountRows()
        {
            DataService ds = new DataService();

            string path =
                $@"C:\Users\max\source\repos\Tyuiu.IsaevMA.Sprint7.Project.V3\Tyuiu.IsaevMA.Sprint7.Project.V3\bin\DataSprint7\Classroom.csv";
            int res = ds.GetCountRows(path);

            int wait = 4;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ProjectTestGetAllHours()
        {
            DataService ds = new DataService();

            string[,] matrix =
            {
                { "123", "456", "123456" },
                { "123", "456", "123456" },
                { "123", "456", "123456" }
            };
            int[] res = ds.GetAllHours(matrix);

            int[] wait = { 123456, 123456, 123456 };

            CollectionAssert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ProjectTestMinValue()
        {
            DataService ds = new DataService();

            int[] Hours = { 1, 2, 3 };

            int min = ds.MinValue(Hours);

            int wait = 1;

            Assert.AreEqual(wait, min);
        }

        [TestMethod]
        public void ProjectTestMaxValue()
        {
            DataService ds = new DataService();

            int[] Hours = { 1, 2, 3 };

            int min = ds.MaxValue(Hours);

            int wait = 3;

            Assert.AreEqual(wait, min);
        }
    }
}
