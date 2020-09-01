using CoffeeShopConsoleApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Latteprice()
        {
            Coffee lat = new Latte(0);

            Assert.AreEqual(40, lat.price());
        }
        [TestMethod]
        public void CofeePrice()
        {
            Coffee bla = new BlackCoffee(0);

            Assert.AreEqual(20, bla.price());
        }
        [TestMethod]
        public void CortadoPrice()
        {
            Coffee cor = new Cortado(0);

            Assert.AreEqual(25, cor.price());
        }
    }
}
