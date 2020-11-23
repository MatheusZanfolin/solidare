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
            this.LblDoador = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.LblDate = new System.Windows.Forms.Label();
            this.LstItems = new System.Windows.Forms.ListBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Doador";
            // 
            // LblDoador
            // 
            this.LblDoador.AutoSize = true;
            this.LblDoador.Location = new System.Drawing.Point(95, 23);
            this.LblDoador.Name = "LblDoador";
            this.LblDoador.Size = new System.Drawing.Size(86, 13);
            this.LblDoador.TabIndex = 2;
            this.LblDoador.TabStop = true;
            this.LblDoador.Text = "Nome do doador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Realizada em";
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.Location = new System.Drawing.Point(95, 54);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(84, 13);
            this.LblDate.TabIndex = 4;
            this.LblDate.Text = "Data da doação";
            // 
            // LstItems
            // 
            this.LstItems.FormattingEnabled = true;
            this.LstItems.Location = new System.Drawing.Point(12, 87);
            this.LstItems.Name = "LstItems";
            this.LstItems.Size = new System.Drawing.Size(253, 160);
            this.LstItems.TabIndex = 5;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(15, 262);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(250, 23);
            this.BtnSave.TabIndex = 6;
            this.BtnSave.Text = "Salvar avaliação";
            this.BtnSave.UseVisualStyleBackColor = true;
            // 
            // DonationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 299);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.LstItems);
            this.Controls.Add(this.LblDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblDoador);
            this.Controls.Add(this.label1);
            this.Name = "DonationForm";
            this.Text = "Solidare - Doação";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel LblDoador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.ListBox LstItems;
        private System.Windows.Forms.Button BtnSave;
    }
}