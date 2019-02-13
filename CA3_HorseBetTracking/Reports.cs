using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA3_HorseBetTracking
{
    public class Reports
    {
        public static string GetBetsByDateAscending(HorseBets bets)
        {
            IEnumerable<HorseBet> solutionSet = from bet in bets
                                                orderby bet.Date
                                                select bet;

            string text = "";
            foreach (var item in solutionSet)
            {
                text += (item.ToString());
            }
            return text;
        }
    }
}
