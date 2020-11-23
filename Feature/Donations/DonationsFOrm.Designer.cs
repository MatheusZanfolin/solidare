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
            this.BtnRate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LstPendingDonations
            // 
            this.LstPendingDonations.FormattingEnabled = true;
            this.LstPendingDonations.Location = new System.Drawing.Point(12, 12);
            this.LstPendingDonations.Name = "LstPendingDonations";
            this.LstPendingDonations.Size = new System.Drawing.Size(250, 277);
            this.LstPendingDonations.TabIndex = 0;
            // 
            // BtnRate
            // 
            this.BtnRate.Location = new System.Drawing.Point(12, 298);
            this.BtnRate.Name = "BtnRate";
            this.BtnRate.Size = new System.Drawing.Size(250, 23);
            this.BtnRate.TabIndex = 1;
            this.BtnRate.Text = "Avaliar";
            this.BtnRate.UseVisualStyleBackColor = true;
            // 
            // DonationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 333);
            this.Controls.Add(this.BtnRate);
            this.Controls.Add(this.LstPendingDonations);
            this.Name = "DonationsForm";
            this.Text = "Solidare - Doações";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LstPendingDonations;
        private System.Windows.Forms.Button BtnRate;
    }
}