using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdditionOfTwoNumber;
namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        // create a instance for our program class 
        private readonly AdditionOfTwoNumber.Program program;
        public UnitTest1()
        {
            program = new AdditionOfTwoNumber.Program();
            //assign object to it by using new keyword
        }
        [TestMethod]


        public void TestMethod1()
        {
            int valueone = 4;
            int valuetwo = 5;
            var result=program.add(valueone, valuetwo);
            Assert.AreEqual(9,result);
        }

        public void TestMethod2()
        {
            var result = program.add(3, 6);
            Assert.AreEqual(10, result);

        }




    }
}