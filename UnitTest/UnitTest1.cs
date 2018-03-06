using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CCodeParser;

namespace UnitTestCCodeParser
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSplitTextWithNullText()
        {

            csWordSplitter wordSplitterClass = new csWordSplitter();
            Assert.IsNull(wordSplitterClass.SplitText(""));

        }

        [TestMethod]
        public void TestSplitTextWithNotNullText()
        {

            csWordSplitter wordSplitterClass = new csWordSplitter();
            Assert.IsNotNull(wordSplitterClass.SplitText(" "));

        }
    }
}
