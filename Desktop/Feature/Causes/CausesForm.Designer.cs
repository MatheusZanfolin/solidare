namespace Solidare.Feature.Causes
{
    partial class CausesForm
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
            this.LstAvailableCauses = new System.Windows.Forms.ListBox();
            this.LstOrganizationCauses = new System.Windows.Forms.ListBox();
            this.BtnAddCause = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnRemoveCause = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LstAvailableCauses
            // 
            this.LstAvailableCauses.FormattingEnabled = true;
            this.LstAvailableCauses.Location = new System.Drawing.Point(12, 43);
            this.LstAvailableCauses.Name = "LstAvailableCauses";
            this.LstAvailableCauses.Size = new System.Drawing.Size(153, 186);
            this.LstAvailableCauses.TabIndex = 0;
            this.LstAvailableCauses.SelectedIndexChanged += new System.EventHandler(this.LstAvailableCauses_SelectedIndexChanged);
            // 
            // LstOrganizationCauses
            // 
            this.LstOrganizationCauses.FormattingEnabled = true;
            this.LstOrganizationCauses.Location = new System.Drawing.Point(252, 43);
            this.LstOrganizationCauses.Name = "LstOrganizationCauses";
            this.LstOrganizationCauses.Size = new System.Drawing.Size(153, 186);
            this.LstOrganizationCauses.TabIndex = 1;
            this.LstOrganizationCauses.SelectedIndexChanged += new System.EventHandler(this.LstOrganizationCauses_SelectedIndexChanged);
            // 
            // BtnAddCause
            // 
            this.BtnAddCause.Location = new System.Drawing.Point(171, 96);
            this.BtnAddCause.Name = "BtnAddCause";
            this.BtnAddCause.Size = new System.Drawing.Size(75, 23);
            this.BtnAddCause.TabIndex = 2;
            this.BtnAddCause.Text = "> >";
            this.BtnAddCause.UseVisualStyleBackColor = true;
            this.BtnAddCause.Click += new System.EventHandler(this.BtnAddCause_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Causas disponíveis";
            // 
            // BtnRemoveCause
            // 
            this.BtnRemoveCause.Location = new System.Drawing.Point(171, 145);
            this.BtnRemoveCause.Name = "BtnRemoveCause";
            this.BtnRemoveCause.Size = new System.Drawing.Size(75, 23);
            this.BtnRemoveCause.TabIndex = 4;
            this.BtnRemoveCause.Text = "< <";
            this.BtnRemoveCause.UseVisualStyleBackColor = true;
            this.BtnRemoveCause.Click += new System.EventHandler(this.BtnRemoveCause_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Causas defendidas";
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.Location = new System.Drawing.Point(12, 245);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(192, 23);
            this.BtnConfirm.TabIndex = 6;
            this.BtnConfirm.Text = "Confirmar alterações";
            this.BtnConfirm.UseVisualStyleBackColor = true;
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(213, 245);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(192, 23);
            this.BtnCancel.TabIndex = 7;
            this.BtnCancel.Text = "Cancelar";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // CausesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 281);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnConfirm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnRemoveCause);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnAddCause);
            this.Controls.Add(this.LstOrganizationCauses);
            this.Controls.Add(this.LstAvailableCauses);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CausesForm";
            this.Text = "Solidare - Causas defendidas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LstAvailableCauses;
        private System.Windows.Forms.ListBox LstOrganizationCauses;
        private System.Windows.Forms.Button BtnAddCause;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnRemoveCause;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnConfirm;
        private System.Windows.Forms.Button BtnCancel;
    }
}