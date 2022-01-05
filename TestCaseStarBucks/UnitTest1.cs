using CoffeMaker;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace TestCaseStarBucks
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void OrderCoffeeShouldReturnMessage()
        {
            StarBucksStore store = new StarBucksStore(new FakeStarbucksStore());
            string result = store.OrderCoffee(2, 6);
            Assert.AreEqual("your order is recieved", result);

        }
        public void Ordercofee_should_return_amessage()
        {
            StarBucksStore store = new StarBucksStore(new StubStarbucks());
            string result = store.OrderCoffee(2, 9);
            Assert.AreEqual("your order is recieved", result);
        }
    }
}