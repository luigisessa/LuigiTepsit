using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1_LUIGI
{
    [TestClass]
    public class UnitTest1
    {
        //testo la frequenza cardiaca massima
        [TestMethod]
        public void TestFrequenzaCMax()
        {
            string eta = "18";
            string FCMax_Atteso = "202";

            string FCMax_Calcolato = ClassLibrary_LUIGI.Class.FrequenzaCMax(eta);

            Assert.AreEqual(FCMax_Atteso, FCMax_Calcolato);
        }

        //testo la frequenza cardiaca massima
        [TestMethod]
        public void TestFrequenzaCMax2()
        {
            string eta = "50";
            string FCMax_Atteso = "170";

            string FCMax_Calcolato = ClassLibrary_LUIGI.Class.FrequenzaCMax(eta);

            Assert.AreEqual(FCMax_Atteso, FCMax_Calcolato);
        }




      
    }
}
