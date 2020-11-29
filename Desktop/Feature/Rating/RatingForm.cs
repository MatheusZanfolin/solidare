using System;
using System.Windows.Forms;
using Solidare.Core.Architecture.Model;
using Solidare.Feature.Donation;

namespace Solidare.Feature.Item
{
    public partial class RatingForm : Form
    {
        private RatingController controller;

        private DonatedItem donatedItem;

        private DonationForm parent;

        public RatingForm(DonationForm donation, Administrator loggedUser, DonatedItem donatedItem)
        {
            this.donatedItem = donatedItem;

            parent = donation;
            controller = new RatingController(this, loggedUser, donatedItem);

            controller.OnScreenCreated();
        }

        private void CmbGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            controller.OnGradeChanged(CmbGrade.SelectedText);
        }

        private void BtnConfirmRating_Click(object sender, EventArgs e)
        {
            controller.OnConfirmButtonClicked();
        }

        internal void ShowItemDetails(string name, string quantity)
        {
            LblItemName.Text = Name;
            LblItemQuantity.Text = quantity;

            for (int grade = 0; grade <= 10; grade++)
            {
                CmbGrade.Items.Add(grade.ToString());
            }
        }

        internal void ShowUpdatedDonationScreen()
        {
            parent.UpdateScreen();

            Close();
        }
    }
}
