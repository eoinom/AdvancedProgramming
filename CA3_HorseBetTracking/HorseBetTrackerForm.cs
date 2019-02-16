using System;
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
        public BindingList<HorseBet> TipstersBets = new BindingList<HorseBet>();

        public HorseBetTrackerForm()
        {
            InitializeComponent();
        }
        
        private void HorseBetTrackerForm_Load(object sender, EventArgs e)
        {
            dgvBets.DataSource = new BindingSource(TipstersBets, null);
        }

        private void btnAddBet_Click(object sender, EventArgs e)
        {
            AddBetForm addBetForm = new AddBetForm();
            var result = addBetForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                TipstersBets.Add(addBetForm.newBet);
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
                    int numBetsExported = Reports.ExportBets(saveFileDialog1.FileName, ref TipstersBets);
                    MessageBox.Show($"Binary file created and {numBetsExported} bets saved successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnImportBets_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Binary File|*.bin";
                openFileDialog1.Title = "Open Binary File";
                openFileDialog1.ShowDialog();

                if (openFileDialog1.FileName != "")
                {
                    int numBetsImported = Reports.ImportBets(openFileDialog1.FileName, ref TipstersBets);
                    if (numBetsImported > 0)
                    {
                        MessageBox.Show($"Binary file opened and {numBetsImported} bets read successfully.");
                        HorseBetTrackerForm_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show($"Binary file opened however no bets were found.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        private void btnYearTotals_Click(object sender, EventArgs e)
        {
            rtbReports.Text = Reports.GetYearTotals(TipstersBets);
        }

        private void btnShowBetsByDate_Click(object sender, EventArgs e)
        {
            TipstersBets = Reports.GetBetsByDateAscending(TipstersBets);
            HorseBetTrackerForm_Load(sender, e);
        }

        private void btnMostPopularCourse_Click(object sender, EventArgs e)
        {
            switch (TipstersBets.Count)
            {
                case 0:
                    rtbReports.Text = "Can't get most popular course as no bets have been entered";
                    break;
                default:
                    rtbReports.Text = "Most Popular Race Course is: " + Reports.GetMostPopularCourse(TipstersBets);
                    break;
            }
        }
    }
}
