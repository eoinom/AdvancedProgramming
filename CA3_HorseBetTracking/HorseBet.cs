using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA3_HorseBetTracking
{
    class HorseBet
    {
        public string RaceCourse { get; set; }
        public DateTime Date { get; set; }
        public decimal Price { get; set; }
        public bool BetWon { get; set; }

        public HorseBet() { }

        public HorseBet(string raceCourse, DateTime date, decimal price, bool betWon)
        {
            RaceCourse = raceCourse;
            Date = date;
            Price = price;
            BetWon = betWon;
        }

        public override string ToString()
        {
            string betSuccess = BetWon ? "Won" : "Lost";
            return RaceCourse + ", " + Date.ToShortDateString() + ", " + Price.ToString() +
                ", " + betSuccess;
        }
    }
}
