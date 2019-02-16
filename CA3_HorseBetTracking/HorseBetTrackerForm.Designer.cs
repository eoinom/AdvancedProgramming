namespace CA3_HorseBetTracking
{
    partial class HorseBetTrackerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnImportBets = new System.Windows.Forms.Button();
            this.btnExportBets = new System.Windows.Forms.Button();
            this.btnAddBet = new System.Windows.Forms.Button();
            this.rtbReports = new System.Windows.Forms.RichTextBox();
            this.btnYearTotals = new System.Windows.Forms.Button();
            this.btnMostPopularCourse = new System.Windows.Forms.Button();
            this.btnShowBetsByDate = new System.Windows.Forms.Button();
            this.btnHighestWonAndLost = new System.Windows.Forms.Button();
            this.btnHowSuccessful = new System.Windows.Forms.Button();
            this.dgvBets = new System.Windows.Forms.DataGridView();
            this.horseBetsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horseBetsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImportBets
            // 
            this.btnImportBets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportBets.Location = new System.Drawing.Point(629, 75);
            this.btnImportBets.Margin = new System.Windows.Forms.Padding(4);
            this.btnImportBets.Name = "btnImportBets";
            this.btnImportBets.Size = new System.Drawing.Size(144, 59);
            this.btnImportBets.TabIndex = 1;
            this.btnImportBets.Text = "Import Bets";
            this.btnImportBets.UseVisualStyleBackColor = true;
            this.btnImportBets.Click += new System.EventHandler(this.btnImportBets_Click);
            // 
            // btnExportBets
            // 
            this.btnExportBets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportBets.Location = new System.Drawing.Point(629, 141);
            this.btnExportBets.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportBets.Name = "btnExportBets";
            this.btnExportBets.Size = new System.Drawing.Size(144, 59);
            this.btnExportBets.TabIndex = 2;
            this.btnExportBets.Text = "Export Bets";
            this.btnExportBets.UseVisualStyleBackColor = true;
            this.btnExportBets.Click += new System.EventHandler(this.btnExportBets_Click);
            // 
            // btnAddBet
            // 
            this.btnAddBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBet.Location = new System.Drawing.Point(629, 8);
            this.btnAddBet.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddBet.Name = "btnAddBet";
            this.btnAddBet.Size = new System.Drawing.Size(144, 59);
            this.btnAddBet.TabIndex = 3;
            this.btnAddBet.Text = "Add Bet";
            this.btnAddBet.UseVisualStyleBackColor = true;
            this.btnAddBet.Click += new System.EventHandler(this.btnAddBet_Click);
            // 
            // rtbReports
            // 
            this.rtbReports.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbReports.Location = new System.Drawing.Point(7, 340);
            this.rtbReports.Margin = new System.Windows.Forms.Padding(1);
            this.rtbReports.Name = "rtbReports";
            this.rtbReports.Size = new System.Drawing.Size(615, 192);
            this.rtbReports.TabIndex = 4;
            this.rtbReports.Text = "";
            // 
            // btnYearTotals
            // 
            this.btnYearTotals.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYearTotals.Location = new System.Drawing.Point(627, 273);
            this.btnYearTotals.Margin = new System.Windows.Forms.Padding(4);
            this.btnYearTotals.Name = "btnYearTotals";
            this.btnYearTotals.Size = new System.Drawing.Size(144, 59);
            this.btnYearTotals.TabIndex = 5;
            this.btnYearTotals.Text = "Year Totals";
            this.btnYearTotals.UseVisualStyleBackColor = true;
            this.btnYearTotals.Click += new System.EventHandler(this.btnYearTotals_Click);
            // 
            // btnMostPopularCourse
            // 
            this.btnMostPopularCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostPopularCourse.Location = new System.Drawing.Point(627, 340);
            this.btnMostPopularCourse.Margin = new System.Windows.Forms.Padding(4);
            this.btnMostPopularCourse.Name = "btnMostPopularCourse";
            this.btnMostPopularCourse.Size = new System.Drawing.Size(144, 59);
            this.btnMostPopularCourse.TabIndex = 6;
            this.btnMostPopularCourse.Text = "Most Popular Course";
            this.btnMostPopularCourse.UseVisualStyleBackColor = true;
            // 
            // btnShowBetsByDate
            // 
            this.btnShowBetsByDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowBetsByDate.Location = new System.Drawing.Point(629, 206);
            this.btnShowBetsByDate.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowBetsByDate.Name = "btnShowBetsByDate";
            this.btnShowBetsByDate.Size = new System.Drawing.Size(144, 59);
            this.btnShowBetsByDate.TabIndex = 7;
            this.btnShowBetsByDate.Text = "Sort Bets by Date";
            this.btnShowBetsByDate.UseVisualStyleBackColor = true;
            this.btnShowBetsByDate.Click += new System.EventHandler(this.btnShowBetsByDate_Click);
            // 
            // btnHighestWonAndLost
            // 
            this.btnHighestWonAndLost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHighestWonAndLost.Location = new System.Drawing.Point(629, 407);
            this.btnHighestWonAndLost.Margin = new System.Windows.Forms.Padding(4);
            this.btnHighestWonAndLost.Name = "btnHighestWonAndLost";
            this.btnHighestWonAndLost.Size = new System.Drawing.Size(144, 59);
            this.btnHighestWonAndLost.TabIndex = 8;
            this.btnHighestWonAndLost.Text = "Highest Won and Lost";
            this.btnHighestWonAndLost.UseVisualStyleBackColor = true;
            // 
            // btnHowSuccessful
            // 
            this.btnHowSuccessful.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHowSuccessful.Location = new System.Drawing.Point(629, 473);
            this.btnHowSuccessful.Margin = new System.Windows.Forms.Padding(4);
            this.btnHowSuccessful.Name = "btnHowSuccessful";
            this.btnHowSuccessful.Size = new System.Drawing.Size(144, 59);
            this.btnHowSuccessful.TabIndex = 9;
            this.btnHowSuccessful.Text = "How Successful";
            this.btnHowSuccessful.UseVisualStyleBackColor = true;
            // 
            // dgvBets
            // 
            this.dgvBets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBets.Location = new System.Drawing.Point(7, 6);
            this.dgvBets.Name = "dgvBets";
            this.dgvBets.RowTemplate.Height = 24;
            this.dgvBets.Size = new System.Drawing.Size(615, 327);
            this.dgvBets.TabIndex = 10;
            // 
            // HorseBetTrackerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 539);
            this.Controls.Add(this.dgvBets);
            this.Controls.Add(this.btnHowSuccessful);
            this.Controls.Add(this.btnHighestWonAndLost);
            this.Controls.Add(this.btnShowBetsByDate);
            this.Controls.Add(this.btnMostPopularCourse);
            this.Controls.Add(this.btnYearTotals);
            this.Controls.Add(this.rtbReports);
            this.Controls.Add(this.btnAddBet);
            this.Controls.Add(this.btnExportBets);
            this.Controls.Add(this.btnImportBets);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximizeBox = false;
            this.Name = "HorseBetTrackerForm";
            this.Text = "Horse Bet Tracker";
            this.Load += new System.EventHandler(this.HorseBetTrackerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horseBetsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnImportBets;
        private System.Windows.Forms.Button btnExportBets;
        private System.Windows.Forms.Button btnAddBet;
        private System.Windows.Forms.RichTextBox rtbReports;
        private System.Windows.Forms.Button btnYearTotals;
        private System.Windows.Forms.Button btnMostPopularCourse;
        private System.Windows.Forms.Button btnShowBetsByDate;
        private System.Windows.Forms.Button btnHighestWonAndLost;
        private System.Windows.Forms.Button btnHowSuccessful;
        private System.Windows.Forms.DataGridView dgvBets;
        private System.Windows.Forms.BindingSource horseBetsBindingSource;
    }
}

