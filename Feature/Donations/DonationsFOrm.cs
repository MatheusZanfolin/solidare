using Solidare.Core.Architecture.Model;
using Solidare.Feature.Donation;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Solidare.Feature.Donations
{
    public partial class DonationsForm : Form
    {
        private DonationsController controller;

        public DonationsForm(Administrator loggedUser)
        {
            InitializeComponent();

            controller = new DonationsController(this, loggedUser);

            controller.OnScreenCreated();
        }

        private void LstPendingDonations_SelectedIndexChanged(object sender, EventArgs e)
        {
            controller.OnDonationSelected(LstPendingDonations.SelectedIndex);
        }

        private void BtnRateDonation_Click(object sender, EventArgs e)
        {
            controller.OnRateDonationButtonClicked();
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            controller.OnReturnButtonClicked();
        }

        internal void ShowDonations(List<Core.Architecture.Model.Donation> donations)
        {
            LstPendingDonations.Items.Clear();
            LstPendingDonations.Items.AddRange(donations.ToArray());
        }

        internal void ShowRatingScreen(Administrator loggedUser, Core.Architecture.Model.Donation donation)
        {
            ShowDialog(new DonationForm(this, loggedUser, donation));
        }

        internal void CloseScreen()
        {
            Close();
        }

        internal void ShowConfirmedDonation(Core.Architecture.Model.Donation confirmed)
        {
            throw new NotImplementedException();
        }
    }
}
