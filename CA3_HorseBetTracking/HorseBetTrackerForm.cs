using System;
using System.ComponentModel;
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
                saveFileDialog1.Filter = "Binary File|*.bin|CSV File|*.csv";
                saveFileDialog1.Title = "Save File";
                saveFileDialog1.ShowDialog();
                string fileName = saveFileDialog1.FileName;

                if (fileName != "")
                {
                    string fileType = GetFileType( Path.GetExtension(fileName) );
                    int numBetsExported = 0;

                    if (fileType == "Binary")
                    {
                        numBetsExported = FileIO.ExportBetsToBinaryFile(fileName, ref TipstersBets);
                    }
                    else if (fileType == "CSV")
                    {
                        numBetsExported = FileIO.ExportBetsToCsvFile(fileName, ref TipstersBets);
                    }
                    MessageBox.Show($"{fileType} file created and {numBetsExported} bets saved successfully.");
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
                openFileDialog1.Filter = "Binary File|*.bin|CSV File|*.csv";
                openFileDialog1.Title = "Import File";
                openFileDialog1.ShowDialog();
                string fileName = openFileDialog1.FileName;
                
                if (fileName != "")
                {
                    string fileType = GetFileType(Path.GetExtension(fileName));
                    int numBetsImported = 0;

                    if (fileType == "Binary")
                    {
                        numBetsImported = FileIO.ImportBetsFromBinaryFile(fileName, ref TipstersBets);
                    }
                    else if (fileType == "CSV")
                    {
                        numBetsImported = FileIO.ImportBetsFromCsvFile(fileName, ref TipstersBets);
                    }
                    
                    if (numBetsImported > 0)
                    {
                        MessageBox.Show($"{fileType} file opened and {numBetsImported} bets read successfully.");
                        HorseBetTrackerForm_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show($"{fileType} file opened however no bets were found.");
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

        private void btnHighestWonAndLost_Click(object sender, EventArgs e)
        {
            switch (TipstersBets.Count)
            {
                case 0:
                    rtbReports.Text = "Can't get highest amount won and lost as no bets have been entered";
                    break;
                default:
                    string MostWon = Reports.GetHighestAmountWon(TipstersBets).ToString("0.00");
                    string MostLost = Reports.GetHighestAmountLost(TipstersBets).ToString("0.00");
                    rtbReports.Text = $"Highest amount won for a bet laid: €{MostWon}{Environment.NewLine}" +
                                        $"Most amount lost for a bet laid: €{MostLost}";
                    break;
            }
        }

        private void btnHowSuccessful_Click(object sender, EventArgs e)
        {
            switch (TipstersBets.Count)
            {
                case 0:
                    rtbReports.Text = "Can't output report as no bets have been entered";
                    break;
                default:
                    int numOfBets = Reports.GetNumberOfBets(TipstersBets);
                    int numOfWins = Reports.GetTotalNumberOfWins(TipstersBets);
                    double winRatioPercentage = Reports.GetWinningPercentage(TipstersBets);
                    rtbReports.Text = $"Total number of bets laid: {numOfBets.ToString()}{Environment.NewLine}" +
                                        $"Total number of bets won: {numOfWins.ToString()}{Environment.NewLine}" +
                                        $"Therefore, win ratio = {winRatioPercentage.ToString("0.0")}%";
                    break;
            }
        }

        private static string GetFileType(string fileExt)
        {
            switch (fileExt)
            {
                case ".bin":
                    return "Binary";
                case ".csv":
                    return "CSV";
                default:
                    return fileExt;
            }
        }
    }
}
