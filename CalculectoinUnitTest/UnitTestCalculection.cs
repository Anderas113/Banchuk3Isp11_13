using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalculectoinUnitTest
{
    [TestClass]
    public class UnitTestCalculection
    {
        [TestMethod]
        public void PriceOneProduct10and12return120 ()
        {
            double price=12;
            double count=10;
            double res=120;
            double assert=CalculationsLibrary.Сheck.PriseOfProduct(count,price);

            Assert.AreEqual(res,assert);
        }
        [TestMethod]
        public void PriceOneProduct12and20return240()
        {
            double price = 20;
            double count = 12;
            double res = 240;
            double assert = CalculationsLibrary.Сheck.PriseOfProduct(count, price);

            Assert.AreEqual(res, assert);
        }
        [TestMethod]
        public void PriceOneProductm50andm20return0()
        {
            double price = -50;
            double count = -20;
            double res = 0;
            double assert = CalculationsLibrary.Сheck.PriseOfProduct(count, price);

            Assert.AreEqual(res, assert);
        }
        [TestMethod]
        public void PriceOneProduct25and20return500()
        {
            int price = 25;
            int count = 20;
            double res = 500;
            double assert = CalculationsLibrary.Сheck.PriseOfProduct(count, price);

            Assert.AreEqual(res, assert);
        }
        [TestMethod]
        public void PriceOneProductm25and20return500()
        {
            double price = -25;
            double count = 20;
            double res = 0;
            double assert = CalculationsLibrary.Сheck.PriseOfProduct(count, price);

            Assert.AreEqual(res, assert);
        }
        [TestMethod]
        public void PriceOneProduct10t2andm20t3return0()
        {
            double price = 10.2;
            double count = 20.3;
            double res = 0;
            double assert = CalculationsLibrary.Сheck.PriseOfProduct(count, price);

            Assert.AreEqual(res, assert);
        }
        [TestMethod]
        public void PriceOneProduct20t3andm10return203()
        {
            double price = 20.3;
            int count = 10;
            double res = 203;
            double assert = CalculationsLibrary.Сheck.PriseOfProduct(count, price);

            Assert.AreEqual(res, assert);
        }
        [TestMethod]
        public void PriceOneProductf25andf20return500()
        {
            float price = 25;
            float count = 20;
            double res = 500;
            double assert = CalculationsLibrary.Сheck.PriseOfProduct(count, price);

            Assert.AreEqual(res, assert);
        }
        [TestMethod]
        public void PriceOneProducti25andf20return500()
        {
            int price = 25;
            float count = 20;
            double res = 500;
            double assert = CalculationsLibrary.Сheck.PriseOfProduct(count, price);

            Assert.AreEqual(res, assert);
        }
        [TestMethod]
        public void PriceOneProduct0and0return0()
        {
            int price = 0;
            float count = 0;
            double res = 0;
            double assert = CalculationsLibrary.Сheck.PriseOfProduct(count, price);

            Assert.AreEqual(res, assert);
        }
    }
}
