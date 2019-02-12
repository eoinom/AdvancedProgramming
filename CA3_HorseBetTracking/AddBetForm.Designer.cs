namespace CA3_HorseBetTracking
{
    partial class AddBetForm
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
            this.lblRaceCourse = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtRaceCourse = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpBetDate = new System.Windows.Forms.DateTimePicker();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtBetAmount = new System.Windows.Forms.TextBox();
            this.rbWon = new System.Windows.Forms.RadioButton();
            this.rbLost = new System.Windows.Forms.RadioButton();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRaceCourse
            // 
            this.lblRaceCourse.AutoSize = true;
            this.lblRaceCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRaceCourse.Location = new System.Drawing.Point(32, 150);
            this.lblRaceCourse.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblRaceCourse.Name = "lblRaceCourse";
            this.lblRaceCourse.Size = new System.Drawing.Size(203, 35);
            this.lblRaceCourse.TabIndex = 0;
            this.lblRaceCourse.Text = "Race Course:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(181, 50);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(223, 48);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Bet Details";
            // 
            // txtRaceCourse
            // 
            this.txtRaceCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRaceCourse.Location = new System.Drawing.Point(40, 196);
            this.txtRaceCourse.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtRaceCourse.Name = "txtRaceCourse";
            this.txtRaceCourse.Size = new System.Drawing.Size(556, 42);
            this.txtRaceCourse.TabIndex = 2;
            this.txtRaceCourse.Validating += new System.ComponentModel.CancelEventHandler(this.txtRaceCourse_Validating);
            this.txtRaceCourse.Validated += new System.EventHandler(this.txtRaceCourse_Validated);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(32, 286);
            this.lblDate.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(89, 35);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Date:";
            // 
            // dtpBetDate
            // 
            this.dtpBetDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBetDate.Location = new System.Drawing.Point(224, 277);
            this.dtpBetDate.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dtpBetDate.Name = "dtpBetDate";
            this.dtpBetDate.Size = new System.Drawing.Size(372, 42);
            this.dtpBetDate.TabIndex = 4;
            this.dtpBetDate.Validating += new System.ComponentModel.CancelEventHandler(this.dtpBetDate_Validating);
            this.dtpBetDate.Validated += new System.EventHandler(this.dtpBetDate_Validated);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(32, 370);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(155, 35);
            this.lblAmount.TabIndex = 5;
            this.lblAmount.Text = "Amount: €";
            // 
            // txtBetAmount
            // 
            this.txtBetAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBetAmount.Location = new System.Drawing.Point(224, 362);
            this.txtBetAmount.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtBetAmount.Name = "txtBetAmount";
            this.txtBetAmount.Size = new System.Drawing.Size(372, 42);
            this.txtBetAmount.TabIndex = 7;
            this.txtBetAmount.Validating += new System.ComponentModel.CancelEventHandler(this.txtBetAmount_Validating);
            this.txtBetAmount.Validated += new System.EventHandler(this.txtBetAmount_Validated);
            // 
            // rbWon
            // 
            this.rbWon.AutoSize = true;
            this.rbWon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbWon.Location = new System.Drawing.Point(144, 455);
            this.rbWon.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.rbWon.Name = "rbWon";
            this.rbWon.Size = new System.Drawing.Size(115, 39);
            this.rbWon.TabIndex = 8;
            this.rbWon.TabStop = true;
            this.rbWon.Text = "Won";
            this.rbWon.UseVisualStyleBackColor = true;
            this.rbWon.Validating += new System.ComponentModel.CancelEventHandler(this.rbWonLost_Validating);
            this.rbWon.Validated += new System.EventHandler(this.rbWonLost_Validated);
            // 
            // rbLost
            // 
            this.rbLost.AutoSize = true;
            this.rbLost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLost.Location = new System.Drawing.Point(336, 455);
            this.rbLost.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.rbLost.Name = "rbLost";
            this.rbLost.Size = new System.Drawing.Size(111, 39);
            this.rbLost.TabIndex = 10;
            this.rbLost.TabStop = true;
            this.rbLost.Text = "Lost";
            this.rbLost.UseVisualStyleBackColor = true;
            this.rbLost.Validating += new System.ComponentModel.CancelEventHandler(this.rbWonLost_Validating);
            this.rbLost.Validated += new System.EventHandler(this.rbWonLost_Validated);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(72, 553);
            this.btnOK.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(200, 83);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(336, 553);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(200, 83);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // epError
            // 
            this.epError.ContainerControl = this;
            // 
            // AddBetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 678);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.rbLost);
            this.Controls.Add(this.rbWon);
            this.Controls.Add(this.txtBetAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.dtpBetDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtRaceCourse);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblRaceCourse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddBetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Bet";
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRaceCourse;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtRaceCourse;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpBetDate;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtBetAmount;
        private System.Windows.Forms.RadioButton rbWon;
        private System.Windows.Forms.RadioButton rbLost;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider epError;
    }
}