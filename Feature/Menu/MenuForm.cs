using Solidare.Core.Architecture.Model;
using Solidare.Feature.Donations;
using Solidare.Feature.Profile;
using System;
using System.Windows.Forms;

namespace Solidare.Feature.Menu
{
    public partial class MenuForm : Form
    {
        private MenuController controller;

        public MenuForm(Administrator user)
        {
            InitializeComponent();

            controller = new MenuController(this, user);
        }

        private void BtnProfile_Click(object sender, EventArgs e)
        {
            controller.OnProfileButtonClicked();
        }

        private void BtnDonations_Click(object sender, EventArgs e)
        {
            controller.OnDonationsButtonClicked();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            controller.OnLogoutButtonClicked();
        }

        internal void ShowProfileEditScreen(Administrator loggedUser)
        {
            ShowDialog(new ProfileForm(loggedUser));
        }

        internal void ShowPendingDonationsScreen(Administrator loggedUser)
        {
            ShowDialog(new DonationsForm(loggedUser));
        }

        internal void CloseApp()
        {
            Environment.Exit(0);
        }
    }
}
