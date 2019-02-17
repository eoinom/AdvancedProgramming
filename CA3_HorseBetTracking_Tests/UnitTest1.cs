using Microsoft.VisualStudio.TestTools.UnitTesting;
using CA3_HorseBetTracking;
using System;
using System.IO;
using System.ComponentModel;

namespace CA3_HorseBetTracking_Tests
{
    [TestClass]
    public class HorseBetUnitTests
    {
        public BindingList<HorseBet> TestBets { get; set; } = new BindingList<HorseBet>() { };
        
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
            BindingList<HorseBet> result = Reports.GetBetsByDateAscending(TestBets);

            BindingList<HorseBet> expectedResult = new BindingList<HorseBet>();
            expectedResult.Add(TestBets[3]);
            expectedResult.Add(TestBets[2]);
            expectedResult.Add(TestBets[4]);
            expectedResult.Add(TestBets[1]);
            expectedResult.Add(TestBets[5]);
            expectedResult.Add(TestBets[0]);

            CollectionAssert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void GetMostPopularCourseTest()
        {
            var result = Reports.GetMostPopularCourse(TestBets);
            Assert.AreEqual("Ayr", result);
        }

        [TestMethod]
        public void GetHighestAmountLostTest()
        {
            var result = Reports.GetHighestAmountLost(TestBets);            
            Assert.AreEqual(25.00m, result);
        }

        [TestMethod]
        public void GetHighestAmountWonTest()
        {
            var result = Reports.GetHighestAmountWon(TestBets);
            Assert.AreEqual(122.52m, result);
        }

        [TestMethod]
        public void GetTotalNumberOfBetsTest()
        {
            var result = Reports.GetTotalNumberOfBets(TestBets);
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void GetTotalNumberOfWinsTest()
        {
            var result = Reports.GetTotalNumberOfWins(TestBets);
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void GetYearTotalsTest()
        {
            var result = Reports.GetYearTotals(TestBets);

            string expectedResult = 
                string.Join(Environment.NewLine,
                        new[]{String.Format("{0,-11}{1,-15}{2,-15}", "Year", "Total Won", "Total Lost"),
                                String.Format("{0,-10}€{1,-14}€{2,-14}", "2016", "188.27", "45.00"),
                                String.Format("{0,-10}€{1,-14}€{2,-14}", "2017", "23.63", "0.00") });

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void ExportImportBetsTest()
        {
            // Output file to following directory: "[Project Path]\CA3_HorseBetTracking_Tests\TestFiles"
            string testOutFile = @"..\..\..\.\TestFiles\TestBetsOut.bin";

            BindingList<HorseBet> tempBets = TestBets;

            // check the number of bets exported
            var numExported = FileIO.ExportBets(testOutFile, ref tempBets);
            Assert.AreEqual(6, numExported);

            // import the exported bets to see that they can be imported again successfully (therefore they're in the correct format)
            var numImported = FileIO.ImportBets(testOutFile, ref tempBets);
            Assert.AreEqual(6, numImported);
        }

        [TestMethod]
        public void ImportBetsTest()
        {
            // Import file from following directory: "[Project Path]\CA3_HorseBetTracking_Tests\TestFiles"
            string testFile = @"..\..\..\.\TestFiles\TestBetsImport.bin";

            BindingList<HorseBet> tempBets = TestBets;
            var result = FileIO.ImportBets(testFile, ref tempBets);

            Assert.AreEqual(36, result);
        }
    }
}
