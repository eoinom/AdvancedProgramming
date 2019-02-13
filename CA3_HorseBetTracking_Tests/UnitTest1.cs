using Microsoft.VisualStudio.TestTools.UnitTesting;
using CA3_HorseBetTracking;
using System;
using System.IO;

namespace CA3_HorseBetTracking_Tests
{
    [TestClass]
    public class HorseBetUnitTests
    {
        public HorseBets TestBets { get; set; } = new HorseBets() { };
        
        public HorseBetUnitTests()
        {
            TestBets.Add(new HorseBet("Aintree", new DateTime(2017, 05, 12), 11.58m, true));
            TestBets.Add(new HorseBet("Punchestown", new DateTime(2016, 12, 22), 122.52m, true));
            TestBets.Add(new HorseBet("Sandown", new DateTime(2016, 11, 17), 20.00m, false));
            TestBets.Add(new HorseBet("Ayr", new DateTime(2016, 11, 03), 25.00m, false));
            TestBets.Add(new HorseBet("Fairyhouse", new DateTime(2016, 12, 02), 65.75m, true));
            TestBets.Add(new HorseBet("Ayr", new DateTime(2017, 03, 11), 12.05m, true));
        }

        [TestMethod]
        public void GetBetsByDateAscendingTest()
        {
            var result = Reports.GetBetsByDateAscending(TestBets);
            string checkResult = TestBets[3].ToString() + TestBets[2].ToString() +
                                    TestBets[4].ToString() + TestBets[1].ToString() +
                                    TestBets[5].ToString() + TestBets[0].ToString();

            Assert.AreEqual(checkResult, result);
        }

        [TestMethod]
        public void ExportImportBetsTest()
        {
            string testOutFile = @"C:\Users\eoin.omalley\OneDrive - Dublin Business School (DBS)\B8IT119 Advanced Programming\0. CA\TestBetsOut.bin";

            HorseBets tempBets = TestBets;

            // check the number of bets exported
            var numExported = Reports.ExportBets(testOutFile, ref tempBets);
            Assert.AreEqual(6, numExported);

            // import the exported bets to see that they can be imported again successfully (therefore they're in the correct format)
            var numImported = Reports.ImportBets(testOutFile, ref tempBets);
            Assert.AreEqual(6, numImported);
        }

        [TestMethod]
        public void ImportBetsTest()
        {
            string testFile = @"C:\Users\eoin.omalley\OneDrive - Dublin Business School (DBS)\B8IT119 Advanced Programming\0. CA\TestBets2.bin";

            HorseBets tempBets = TestBets;
            var result = Reports.ImportBets(testFile, ref tempBets);

            Assert.AreEqual(36, result);
        }
    }
}
