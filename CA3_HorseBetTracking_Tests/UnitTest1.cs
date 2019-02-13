using Microsoft.VisualStudio.TestTools.UnitTesting;
using CA3_HorseBetTracking;
using System;

namespace CA3_HorseBetTracking_Tests
{
    [TestClass]
    public class UnitTest1
    {
        public HorseBets TestBets { get; set; } = new HorseBets() { };
        
        public UnitTest1()
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
    }
}
