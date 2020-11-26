namespace Solidare.Feature.Donation
{
    partial class DonationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblDate = new System.Windows.Forms.Label();
            this.LstItems = new System.Windows.Forms.ListBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.LblDonor = new System.Windows.Forms.Label();
            this.BtnRateItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Doador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Realizada em";
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.Location = new System.Drawing.Point(95, 50);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(84, 13);
            this.LblDate.TabIndex = 4;
            this.LblDate.Text = "Data da doação";
            // 
            // LstItems
            // 
            this.LstItems.FormattingEnabled = true;
            this.LstItems.Location = new System.Drawing.Point(12, 79);
            this.LstItems.Name = "LstItems";
            this.LstItems.Size = new System.Drawing.Size(253, 160);
            this.LstItems.TabIndex = 5;
            this.LstItems.SelectedIndexChanged += new System.EventHandler(this.LstItems_SelectedIndexChanged);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(12, 285);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(253, 23);
            this.BtnSave.TabIndex = 6;
            this.BtnSave.Text = "Confirmar doação";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnConfirmDonation_Click);
            // 
            // LblDonor
            // 
            this.LblDonor.AutoSize = true;
            this.LblDonor.Location = new System.Drawing.Point(95, 19);
            this.LblDonor.Name = "LblDonor";
            this.LblDonor.Size = new System.Drawing.Size(86, 13);
            this.LblDonor.TabIndex = 7;
            this.LblDonor.Text = "Nome do doador";
            // 
            // BtnRateItem
            // 
            this.BtnRateItem.Location = new System.Drawing.Point(12, 256);
            this.BtnRateItem.Name = "BtnRateItem";
            this.BtnRateItem.Size = new System.Drawing.Size(253, 23);
            this.BtnRateItem.TabIndex = 8;
            this.BtnRateItem.Text = "Avaliar item";
            this.BtnRateItem.UseVisualStyleBackColor = true;
            this.BtnRateItem.Click += new System.EventHandler(this.BtnRateItem_Click);
            // 
            // DonationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 320);
            this.Controls.Add(this.BtnRateItem);
            this.Controls.Add(this.LblDonor);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.LstItems);
            this.Controls.Add(this.LblDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DonationForm";
            this.Text = "Solidare - Doação";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.ListBox LstItems;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label LblDonor;
        private System.Windows.Forms.Button BtnRateItem;
    }
}