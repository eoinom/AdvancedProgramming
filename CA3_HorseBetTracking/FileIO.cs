﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;

namespace CA3_HorseBetTracking
{
    public class FileIO
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
    }
}
