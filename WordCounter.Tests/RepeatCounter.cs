using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{
    [TestClass]
    public class RepeatCounterTest
    {
        [TestMethod]
        public void MethodName_Spec_ExpectedOutput()
        {
            RepeatCounter Words123 = new RepeatCounter();
            Assert.AreEqual(ExpectedOutput, Words123.MethodName(inputHere));
        }
    }
}
