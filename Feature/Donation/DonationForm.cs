using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Solidare.Core.Architecture.Model;
using Solidare.Feature.Donations;
using Solidare.Feature.Item;

namespace Solidare.Feature.Donation
{
    public partial class DonationForm : Form
    {
        private DonationController controller;

        private DonationsForm parent;

        public DonationForm(DonationsForm donations, Administrator loggedUser, Core.Architecture.Model.Donation donation)
        {
            InitializeComponent();

            parent = donations;
            controller = new DonationController(this, loggedUser, donation);

            controller.OnScreenCreated();
        }

        private void LstItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            controller.OnSelectedItemChanged(LstItems.SelectedIndex);
        }

        private void BtnConfirmDonation_Click(object sender, EventArgs e)
        {
            controller.OnConfirmDonationButtonClicked();
        }

        private void BtnRateItem_Click(object sender, EventArgs e)
        {
            controller.OnRateItemButtonClicked();
        }

        internal void UpdateScreen()
        {
            controller.OnScreenCreated();
        }

        internal void ShowItems(List<Core.Architecture.Model.Item> items, List<DonatedItem> donatedItems, List<Core.Architecture.Model.Rating> ratings)
        {
            LstItems.Items.Clear();

            foreach (DonatedItem donation in donatedItems)
            {
                var donationRating = ratings.Find((item) => item.DonatedItemID == donation.ID);
                var donatedItem = items.Find((item) => item.ID == donation.ItemID);

                var grade = "Sem avalição";

                if (donationRating == null)
                {
                    grade = donationRating.Grade.ToString();
                }

                LstItems.Items.Add(donatedItem.Name + " (" + grade + ")");
            }
        }

        internal void ShowRatingScreen(Administrator loggedUser, DonatedItem donatedItem)
        {
            ShowDialog(new RatingForm(this, loggedUser, donatedItem));
        }

        internal void ShowUpdatedDonations()
        {
            parent.ShowUpdatedDonations();
        }
    }
}
