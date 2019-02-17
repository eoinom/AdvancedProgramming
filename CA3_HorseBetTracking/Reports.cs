using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

namespace CA3_HorseBetTracking
{
    public class Reports
    {
        public static BindingList<HorseBet> GetBetsByDateAscending(BindingList<HorseBet> bets)
        {
            IEnumerable<HorseBet> solutionSet = from bet in bets
                                                orderby bet.Date
                                                select bet;

            BindingList<HorseBet> tempBets = new BindingList<HorseBet>();
            foreach (var item in solutionSet)
            {
                tempBets.Add(item);
            }
            return tempBets;
        }

        public static string GetYearTotals(BindingList<HorseBet> bets)
        {
            var yearTotals =
                from bet in bets
                group bet by bet.Date.Year into groupByYear
                orderby groupByYear.Key
                select new {
                    Year = groupByYear.Key.ToString(),
                    WonTotal = groupByYear.AsEnumerable().Where(x => x.BetWon).Sum(x => x.Amount).ToString("0.00"),
                    LostTotal = groupByYear.AsEnumerable().Where(x => !x.BetWon).Sum(x => x.Amount).ToString("0.00")
                };

            string text = String.Format("{0,-11}{1,-15}{2,-15}{3}", "Year", "Total Won", "Total Lost", Environment.NewLine);

            text += string.Join(Environment.NewLine,
                        yearTotals.Select(y => String.Format("{0,-10}€{1,-14}€{2,-14}", y.Year, y.WonTotal, y.LostTotal)));
            
            return text;
        }

        public static string GetMostPopularCourse(BindingList<HorseBet> bets)
        {
            try
            {
                var popularCourses =
                    from bet in bets
                    group bet by bet.RaceCourse into groupByRaceCourse
                    orderby groupByRaceCourse.Count()
                    select new
                    {
                        NumberBets = groupByRaceCourse.Count(),
                        Course = groupByRaceCourse.ElementAt(0).RaceCourse
                    };
                return popularCourses.Select(c => c.Course).Last();
            }
            catch (Exception ex)
            {
                return "Error! " + ex.Message;
            }            
        }

        public static decimal GetHighestAmountLost(BindingList<HorseBet> bets)
        {
            try
            {
                var betsLost =
                    from bet in bets
                    where !bet.BetWon
                    orderby bet.Amount
                    select new
                    {
                        AmountLost = bet.Amount
                    };
                return betsLost.Select(b => b.AmountLost).Last();
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        public static decimal GetHighestAmountWon(BindingList<HorseBet> bets)
        {
            try
            {
                var betsWon =
                    from bet in bets
                    where bet.BetWon
                    orderby bet.Amount
                    select new
                    {
                        AmountWon = bet.Amount
                    };
                return betsWon.Select(b => b.AmountWon).Last();
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        public static int GetTotalNumberOfBets(BindingList<HorseBet> bets)
        {
            return bets.Count;
        }

        public static int GetTotalNumberOfWins(BindingList<HorseBet> bets)
        {
            try
            {
                var betsWon =
                    from bet in bets
                    where bet.BetWon
                    orderby bet.Amount
                    select new
                    {
                        WinningBet = bet
                    };
                return betsWon.Select(b => b.WinningBet).Count();
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
    }
}
