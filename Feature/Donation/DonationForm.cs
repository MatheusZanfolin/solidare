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

        public DonationForm(Donations.DonationsForm donations, Administrator loggedUser, Core.Architecture.Model.Donation donation)
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

        internal void ShowItems(List<DonatedItem> donatedItems, List<Core.Architecture.Model.Rating> ratings)
        {
            throw new NotImplementedException();
        }

        internal void ShowRatingScreen(Administrator loggedUser, DonatedItem donatedItem)
        {
            ShowDialog(new RatingForm(this, loggedUser, donatedItem));
        }

        internal void ShowGradedDonation(DonatedItem donation, int grade)
        {
            
        }

        internal void ShowDonationsScreen(Core.Architecture.Model.Donation confirmed)
        {
            parent.ShowConfirmedDonation(confirmed);
        }
    }
}
