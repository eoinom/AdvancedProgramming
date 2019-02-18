using System;
using System.IO;
using System.ComponentModel;

namespace CA3_HorseBetTracking
{
    public class FileIO
    {
        public static int ExportBetsToBinaryFile(string fileName, ref BindingList<HorseBet> bets)
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

        public static int ExportBetsToCsvFile(string fileName, ref BindingList<HorseBet> bets)
        {
            int numBetsWritten = 0;

            // Saves the CSV file via a FileStream 
            FileStream fs = File.Open(fileName, FileMode.OpenOrCreate);

            using (fs)
            {
                using (StreamWriter writer = new StreamWriter(fs))
                {
                    foreach (HorseBet bet in bets)
                    {
                        writer.Write(bet.RaceCourse + ",");
                        writer.Write(bet.Date + ",");
                        writer.Write(bet.Amount + ",");
                        writer.Write(bet.BetWon + Environment.NewLine);
                        numBetsWritten++;
                    }
                }
            }
            return numBetsWritten;
        }

        public static int ImportBetsFromBinaryFile(string fileName, ref BindingList<HorseBet> bets)
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

        public static int ImportBetsFromCsvFile(string fileName, ref BindingList<HorseBet> bets)
        {
            int numBetsRead = 0;

            if (File.Exists(fileName))
            {
                // Opens a CSV file via a FileStream  
                FileStream fs = File.Open(fileName, FileMode.Open);

                using (fs)
                {
                    using (StreamReader reader = new StreamReader(fs))
                    {
                        //string[] lines = reader.EndOfStream(fileName);
                        while (!reader.EndOfStream)
                        {
                            string[] field = reader.ReadLine().Split(',');
                            string raceCourse = field[0];
                            bool dateInSuccess = DateTime.TryParse(field[1], out DateTime date);
                            bool amountInSuccess = decimal.TryParse(field[2], out decimal amount);
                            bool betWonInSuccess = bool.TryParse(field[3], out bool betWon);

                            if (raceCourse.Length > 1 && dateInSuccess && amountInSuccess && betWonInSuccess)
                            {
                                bets.Add(new HorseBet(raceCourse, date, amount, betWon));
                                numBetsRead++;
                            }                            
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
