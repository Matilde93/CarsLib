using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarsLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsLib.Tests
{
    [TestClass()]
    public class CarsTests
    {

        private Car carShortModelName = new() { Id = 1, LicensePlate = "WE 567", Model = "he", Price = 30000};
        private Car carPriceZero = new() { Id = 2, LicensePlate = "DA 123", Model = "Volvo", Price = 0};
        private Car carShortLicensePlate = new() { Id = 3, LicensePlate = "H", Model = "Volvo", Price = 23444};
        private Car carLongLicensePlate = new() { Id = 4, LicensePlate = "abcdefghi", Model = "Volvo", Price = 123487};
        private Car carToStringTest = new() { Id = 5, LicensePlate = "12345", Model = "volvo", Price = 12345};
        [TestMethod()]
        public void ValidateModelTest()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => carShortModelName.ValidateModel());
        }

        [TestMethod()]
        public void ValidateLicensePlateTest()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => carLongLicensePlate.ValidateLicensePlate());
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => carShortLicensePlate.ValidateLicensePlate());

        }

        [TestMethod()]
        public void ValidatePriceTest()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => carPriceZero.ValidatePrice());
        }

        [TestMethod()]
        public void ToStringTest()
        {
            Assert.AreEqual("5 volvo 12345 12345", carToStringTest.ToString());
        }

        [TestMethod()]
        public void ValidateTest()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => carPriceZero.Validate());
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => carLongLicensePlate.Validate());
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => carShortLicensePlate.Validate());
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => carShortModelName.Validate());

        }
    }
}