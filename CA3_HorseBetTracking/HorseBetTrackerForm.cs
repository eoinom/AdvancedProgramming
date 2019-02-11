﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CA3_HorseBetTracking
{
    public partial class HorseBetTrackerForm : Form
    {
        public HorseBets BetsList = new HorseBets();
        public int MyProperty { get; set; }

        public HorseBetTrackerForm()
        {
            InitializeComponent();
            AddInitialBets(BetsList);
        }

        private void AddInitialBets( HorseBets list)
        {
            list.Add(new HorseBet("Aintree", new DateTime(2017, 05, 12), 11.58m, true));
            list.Add(new HorseBet("Punchestown", new DateTime(2016, 12, 22), 122.52m, true));
            list.Add(new HorseBet("Sandown", new DateTime(2016, 11, 17), 20.00m, false));
            list.Add(new HorseBet("Ayr", new DateTime(2016, 11, 03), 25.00m, false));
            list.Add(new HorseBet("Fairyhouse", new DateTime(2016, 12, 02), 65.75m, true));
            list.Add(new HorseBet("Ayr", new DateTime(2017, 03, 11), 12.05m, true));
            list.Add(new HorseBet("Doncaster", new DateTime(2017, 12, 02), 10.00m, false));
            list.Add(new HorseBet("Towcester", new DateTime(2016, 03, 12), 50.00m, false));
            list.Add(new HorseBet("Goodwood", new DateTime(2017, 10, 07), 525.74m, true));
            list.Add(new HorseBet("Kelso", new DateTime(2016, 09, 13), 43.21m, true));
            list.Add(new HorseBet("Punchestown", new DateTime(2017, 07, 05), 35.00m, false));
            list.Add(new HorseBet("Ascot", new DateTime(2016, 02, 04), 23.65m, true));
            list.Add(new HorseBet("Kelso", new DateTime(2017, 08, 02), 30.00m, false));
            list.Add(new HorseBet("Towcester", new DateTime(2017, 05, 01), 104.33m, true));
            list.Add(new HorseBet("Ascot", new DateTime(2017, 06, 21), 25.00m, false));
            list.Add(new HorseBet("Bangor", new DateTime(2016, 12, 22), 30.00m, false));
            list.Add(new HorseBet("Ayr", new DateTime(2017, 05, 22), 11.50m, true));
            list.Add(new HorseBet("Ascot", new DateTime(2017, 06, 23), 30.00m, false));
            list.Add(new HorseBet("Ascot", new DateTime(2017, 06, 23), 374.27m, true));
            list.Add(new HorseBet("Goodwood", new DateTime(2016, 10, 05), 34.12m, true));
            list.Add(new HorseBet("Dundalk", new DateTime(2016, 11, 09), 20.00m, false));
            list.Add(new HorseBet("Haydock", new DateTime(2016, 11, 12), 87.00m, true));
            list.Add(new HorseBet("Perth", new DateTime(2017, 01, 20), 15.00m, false));
            list.Add(new HorseBet("York", new DateTime(2017, 11, 11), 101.25m, true));
            list.Add(new HorseBet("Punchestown", new DateTime(2016, 12, 22), 11.50m, true));
            list.Add(new HorseBet("Chester", new DateTime(2016, 08, 14), 10.00m, false));
            list.Add(new HorseBet("Kelso", new DateTime(2016, 09, 18), 10.00m, false));
            list.Add(new HorseBet("Kilbeggan", new DateTime(2017, 03, 03), 20.00m, false));
            list.Add(new HorseBet("Fairyhouse", new DateTime(2017, 03, 11), 55.50m, true));
            list.Add(new HorseBet("Punchestown", new DateTime(2016, 11, 15), 10.00m, false));
            list.Add(new HorseBet("Towcester", new DateTime(2016, 05, 08), 16.55m, true));
            list.Add(new HorseBet("Punchestown", new DateTime(2016, 05, 23), 13.71m, true));
            list.Add(new HorseBet("Cork", new DateTime(2016, 11, 30), 20.00m, false));
            list.Add(new HorseBet("Punchestown", new DateTime(2016, 04, 25), 13.45m, true));
            list.Add(new HorseBet("Bangor", new DateTime(2016, 01, 23), 10.00m, false));
            list.Add(new HorseBet("Sandown", new DateTime(2017, 08, 07), 25.00m, false));
        }

        private void HorseBetTrackerForm_Load(object sender, EventArgs e)
        {
            rtbBets.Clear();
            foreach (var bet in BetsList)
            {
                rtbBets.AppendText(bet.ToString());
            }
        }

        private void btnAddBet_Click(object sender, EventArgs e)
        {
            AddBetForm addBetForm = new AddBetForm();
            var result = addBetForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                BetsList.Add(addBetForm.newBet);
                HorseBetTrackerForm_Load(sender, e);
            }
        }

        private void btnExportBets_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Binary File|*.bin";
                saveFileDialog1.Title = "Save Binary File";
                saveFileDialog1.ShowDialog();

                if (saveFileDialog1.FileName != "")
                {
                    // Saves the binary file via a FileStream created by the OpenFile method  
                    System.IO.FileStream fs =
                       (System.IO.FileStream)saveFileDialog1.OpenFile();

                    using (fs)
                    {
                        using (BinaryWriter writer = new BinaryWriter(fs))
                        {
                            int numBetsWritten = 0;
                            foreach (HorseBet bet in BetsList)
                            {
                                //writer.Write(bet.ToString());
                                writer.Write(bet.RaceCourse);
                                writer.Write(bet.Date.ToBinary());
                                writer.Write(bet.Amount);
                                writer.Write(bet.BetWon);
                                numBetsWritten++;
                            }
                            MessageBox.Show($"Binary file created and {numBetsWritten} bets saved successfully.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
