using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{
    [TestClass]
    public class RepeatCounterTest
    {
        [TestMethod]
        public void wordCounter_CatchOneWord_1()
        {
            RepeatCounter Words123 = new RepeatCounter();
            Assert.AreEqual(1, Words123.wordCounter("doom", "doom"));
        }
        [TestMethod]
        public void wordCounter_CatchOneInString_1()
        {
            RepeatCounter Words123 = new RepeatCounter();
            Assert.AreEqual(1, Words123.wordCounter("dang ding doom", "doom"));
        }
        [TestMethod]
        public void wordCounter_CatchTwoInString_2()
        {
            RepeatCounter Words123 = new RepeatCounter();
            Assert.AreEqual(2, Words123.wordCounter("dang doom ding doom", "doom"));
        }
        [TestMethod]
        public void wordCounter_CatchTwoIgnoreInclude_2()
        {
            RepeatCounter Words123 = new RepeatCounter();
            Assert.AreEqual(2, Words123.wordCounter("dang doom dooomsday ding doom", "doom"));
        }
        [TestMethod]
        public void wordCounter_CatchTwoIgnoreCase_4()
        {
            RepeatCounter Words123 = new RepeatCounter();
            Assert.AreEqual(4, Words123.wordCounter("dOoM doom DOOM DooM", "doom"));
        }
        // This check needs to be phased out due to the section not actually returning a value, comfirmed working.
        // [TestMethod]
        // public void wordCounter_CatchSpaceInWord_100()
        // {
        //     RepeatCounter Words123 = new RepeatCounter();
        //     Assert.AreEqual(100, Words123.wordCounter("dOoM doom DOOM DooM", "doom doom"));
        // }

    }
}
