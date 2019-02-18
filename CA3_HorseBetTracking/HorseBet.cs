using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA3_HorseBetTracking
{
    public class HorseBet
    {
        public string RaceCourse { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public bool BetWon { get; set; }

        public HorseBet() { }

        public HorseBet(string raceCourse, DateTime date, decimal amount, bool betWon)
        {
            RaceCourse = raceCourse;
            Date = date;
            Amount = amount;
            BetWon = betWon;
        }

        public override string ToString()
        {
            string betSuccess = BetWon ? "Won" : "Lost";
            return RaceCourse + ", " + Date.ToShortDateString() + ", €" + Amount.ToString() +
                ", " + betSuccess + Environment.NewLine;
        }
    }
}
