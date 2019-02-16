﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.ComponentModel;

namespace CA3_HorseBetTracking
{
    public class Reports
    {
        public static int ExportBets(string fileName, ref BindingList<HorseBet> bets)
        {
            int numBetsWritten = 0;

            // Saves the binary file via a FileStream 
            FileStream fs = File.Open(fileName, FileMode.OpenOrCreate);

            using (fs)
            {
                using (BinaryWriter writer = new BinaryWriter(fs))
                {                        
                    foreach (HorseBet bet in bets)
                    {
                        writer.Write(bet.RaceCourse);
                        writer.Write(bet.Date.ToBinary());
                        writer.Write(bet.Amount);
                        writer.Write(bet.BetWon);
                        numBetsWritten++;
                    }                        
                }
            }
            return numBetsWritten;
        }

        public static int ImportBets(string fileName, ref BindingList<HorseBet> bets)
        {
            int numBetsRead = 0;

            if (File.Exists(fileName))
            {
                // Opens a binary file via a FileStream  
                FileStream fs = File.Open(fileName, FileMode.Open);

                using (fs)
                {
                    using (BinaryReader reader = new BinaryReader(fs))
                    {
                        int length = (int)reader.BaseStream.Length;
                        while (reader.BaseStream.Position != length)
                        {
                            string raceCourse = reader.ReadString();
                            DateTime date = DateTime.FromBinary((long)reader.ReadUInt64());
                            decimal amount = reader.ReadDecimal();
                            bool betWon = reader.ReadBoolean();
                            bets.Add(new HorseBet(raceCourse, date, amount, betWon));
                            numBetsRead++;
                        }
                    }
                }
            }
            else
            {
                throw new ArgumentException("File does not exist", fileName);
            }
            return numBetsRead;
        }

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
    }
}
