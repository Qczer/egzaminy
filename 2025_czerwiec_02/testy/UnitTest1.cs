using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using konsolowa;

namespace testy
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual(Program.Szyfruj("abc", 3), "def");
            Assert.AreEqual(Program.Szyfruj("xyz", 3), "abc");
            Assert.AreEqual(Program.Szyfruj("def", -3), "abc");
            Assert.AreEqual(Program.Szyfruj("abc", 29), "def");
            Assert.AreEqual(Program.Szyfruj("ab cd", 2), "cd ef");
        }
    }
}
