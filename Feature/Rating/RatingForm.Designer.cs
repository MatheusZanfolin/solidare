namespace Solidare.Feature.Item
{
    partial class RatingForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BtnConfirmRating = new System.Windows.Forms.Button();
            this.LblItemName = new System.Windows.Forms.Label();
            this.LblItemQuantity = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item doado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Avaliação";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(86, 90);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(186, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // BtnConfirmRating
            // 
            this.BtnConfirmRating.Location = new System.Drawing.Point(15, 131);
            this.BtnConfirmRating.Name = "BtnConfirmRating";
            this.BtnConfirmRating.Size = new System.Drawing.Size(257, 23);
            this.BtnConfirmRating.TabIndex = 4;
            this.BtnConfirmRating.Text = "Confirmar avaliação";
            this.BtnConfirmRating.UseVisualStyleBackColor = true;
            // 
            // LblItemName
            // 
            this.LblItemName.AutoSize = true;
            this.LblItemName.Location = new System.Drawing.Point(83, 22);
            this.LblItemName.Name = "LblItemName";
            this.LblItemName.Size = new System.Drawing.Size(60, 13);
            this.LblItemName.TabIndex = 5;
            this.LblItemName.Text = "Item doado";
            // 
            // LblItemQuantity
            // 
            this.LblItemQuantity.AutoSize = true;
            this.LblItemQuantity.Location = new System.Drawing.Point(83, 57);
            this.LblItemQuantity.Name = "LblItemQuantity";
            this.LblItemQuantity.Size = new System.Drawing.Size(60, 13);
            this.LblItemQuantity.TabIndex = 6;
            this.LblItemQuantity.Text = "Item doado";
            // 
            // DonatedItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 167);
            this.Controls.Add(this.LblItemQuantity);
            this.Controls.Add(this.LblItemName);
            this.Controls.Add(this.BtnConfirmRating);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DonatedItemForm";
            this.Text = "Solidare - Avaliação";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button BtnConfirmRating;
        private System.Windows.Forms.Label LblItemName;
        private System.Windows.Forms.Label LblItemQuantity;
    }
}