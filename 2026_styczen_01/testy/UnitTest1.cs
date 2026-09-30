using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using konsolowa;

namespace testy
{
    [TestClass]
    public class UnitTest1
    {
        public List<Kosc> kosci = new List<Kosc>();

        [TestMethod]
        public void Rzucanie()
        {
            for (int i = 0; i < 20; i++)
                kosci.Add(new Kosc());

            foreach (Kosc kosc in kosci)
            {
                Assert.IsTrue(kosc.value >= 1 && kosc.value <= 6);
            }
        }

        [TestMethod]
        public void WartoscSieNieZmienia()
        {
            foreach (Kosc kosc in kosci)
            {
                int oldValue = kosc.value;

                kosc.available = false;
                kosc.Rzuc();

                Assert.IsTrue(kosc.value == oldValue);
            }
        }
    }
}
