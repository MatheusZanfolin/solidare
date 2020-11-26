namespace Solidare.Feature.Donations
{
    partial class DonationsForm
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
            this.LstPendingDonations = new System.Windows.Forms.ListBox();
            this.BtnReturn = new System.Windows.Forms.Button();
            this.BtnRateDonation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LstPendingDonations
            // 
            this.LstPendingDonations.FormattingEnabled = true;
            this.LstPendingDonations.Location = new System.Drawing.Point(12, 12);
            this.LstPendingDonations.Name = "LstPendingDonations";
            this.LstPendingDonations.Size = new System.Drawing.Size(250, 277);
            this.LstPendingDonations.TabIndex = 0;
            this.LstPendingDonations.SelectedIndexChanged += new System.EventHandler(this.LstPendingDonations_SelectedIndexChanged);
            // 
            // BtnReturn
            // 
            this.BtnReturn.Location = new System.Drawing.Point(12, 328);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(250, 23);
            this.BtnReturn.TabIndex = 1;
            this.BtnReturn.Text = "Voltar";
            this.BtnReturn.UseVisualStyleBackColor = true;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // BtnRateDonation
            // 
            this.BtnRateDonation.Enabled = false;
            this.BtnRateDonation.Location = new System.Drawing.Point(12, 299);
            this.BtnRateDonation.Name = "BtnRateDonation";
            this.BtnRateDonation.Size = new System.Drawing.Size(250, 23);
            this.BtnRateDonation.TabIndex = 2;
            this.BtnRateDonation.Text = "Avaliar doação";
            this.BtnRateDonation.UseVisualStyleBackColor = true;
            this.BtnRateDonation.Click += new System.EventHandler(this.BtnRateDonation_Click);
            // 
            // DonationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 363);
            this.Controls.Add(this.BtnRateDonation);
            this.Controls.Add(this.BtnReturn);
            this.Controls.Add(this.LstPendingDonations);
            this.Name = "DonationsForm";
            this.Text = "Solidare - Doações";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LstPendingDonations;
        private System.Windows.Forms.Button BtnReturn;
        private System.Windows.Forms.Button BtnRateDonation;
    }
}