using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using ContaDAL;
using ContaDAL.Models;
using ContaDAL.Services;

namespace UnitTestAplicatieContabilitate
{
    [TestClass]
    public class DBUnitTest
    {
        [TestMethod]
        public void Point1Services_UnitTest()
        {
            var p1 = new Mock<Point1Services>();

            Assert.AreNotEqual(p1.Object.GetPoint1(), null);
        }

        [TestMethod]
        public void Point2Services_UnitTest()
        {
            var p2 = new Mock<Point2Services>();

            Assert.AreNotEqual(p2.Object.GetPoint2(), null);
        }

        [TestMethod]
        public void Point3Services_UnitTest()
        {
            var p3 = new Mock<Point3Services>();

            Assert.AreNotEqual(p3.Object.GetPoint3(), null);
        }

        [TestMethod]
        public void Point4Services_UnitTest()
        {
            var p4 = new Mock<Point3Services>();

            Assert.AreNotEqual(p4.Object.GetPoint3(), null);
        }

        [TestMethod]
        public void Point5Services_UnitTest()
        {
            var p5 = new Mock<Point3Services>();

            Assert.AreNotEqual(p5.Object.GetPoint3(), null);
        }

        [TestMethod]
        public void Punct5Table_UnitTest()
        {
            var c = new Punct5();
            c.Id = 3;
            c.Profit = 123;
            c.Venituri = 11231;
            c.Cheltuieli = 1200;

            Assert.AreEqual(c.Id, 3);
            Assert.AreNotEqual(c.Profit, 11);
            Assert.AreEqual(c.Venituri, 11231);
            Assert.AreNotEqual(c.Cheltuieli, 429);
        }

        [TestMethod]
        public void Point6Services_UnitTest()
        {
            var p6 = new Mock<Point3Services>();

            Assert.AreNotEqual(p6.Object.GetPoint3(), null);
        }

        [TestMethod]
        public void Punct6Table_UnitTest()
        {
            var c = new Punct6();
            c.Id = 0;
            c.Profit = 10000;
            c.Venituri = 1010;
            c.Cheltuieli = 511;

            Assert.AreNotEqual(c.Id, 3);
            Assert.AreEqual(c.Profit, 10000);
            Assert.AreEqual(c.Venituri, 1010);
            Assert.AreEqual(c.Cheltuieli, 511);
        }

        [TestMethod]
        public void Punct1Table_UnitTest()
        {
            var c = new Punct1();
            c.Id = 1;
            c.Profit = 22;
            c.Venituri = 1111;
            c.Cheltuieli = 2312;

            Assert.AreEqual(c.Id, 1);
            Assert.AreNotEqual(c.Profit, 11);
            Assert.AreEqual(c.Venituri, 1111);
            Assert.AreNotEqual(c.Cheltuieli, 121);
        }

        [TestMethod]
        public void Punct2Table_UnitTest()
        {
            var c = new Punct2();
            c.Id = 1;
            c.Profit = 22;
            c.Venituri = 1111;
            c.Cheltuieli = 2312;

            Assert.AreEqual(c.Id, 1);
            Assert.AreNotEqual(c.Profit, 11);
            Assert.AreEqual(c.Venituri, 1111);
            Assert.AreNotEqual(c.Cheltuieli, 121);
        }

    }
}
