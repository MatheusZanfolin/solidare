namespace Solidare.Feature.Menu
{
    partial class MenuForm
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
            this.BtnProfile = new System.Windows.Forms.Button();
            this.BtnDonations = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnProfile
            // 
            this.BtnProfile.Location = new System.Drawing.Point(12, 12);
            this.BtnProfile.Name = "BtnProfile";
            this.BtnProfile.Size = new System.Drawing.Size(259, 23);
            this.BtnProfile.TabIndex = 0;
            this.BtnProfile.Text = "Editar perfil da ONG";
            this.BtnProfile.UseVisualStyleBackColor = true;
            this.BtnProfile.Click += new System.EventHandler(this.BtnProfile_Click);
            // 
            // BtnDonations
            // 
            this.BtnDonations.Location = new System.Drawing.Point(12, 41);
            this.BtnDonations.Name = "BtnDonations";
            this.BtnDonations.Size = new System.Drawing.Size(259, 23);
            this.BtnDonations.TabIndex = 1;
            this.BtnDonations.Text = "Avaliar doações pendentes";
            this.BtnDonations.UseVisualStyleBackColor = true;
            this.BtnDonations.Click += new System.EventHandler(this.BtnDonations_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(12, 70);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(259, 23);
            this.BtnExit.TabIndex = 2;
            this.BtnExit.Text = "Sair";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 107);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnDonations);
            this.Controls.Add(this.BtnProfile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MenuForm";
            this.Text = "Solidare - Menu Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnProfile;
        private System.Windows.Forms.Button BtnDonations;
        private System.Windows.Forms.Button BtnExit;
    }
}