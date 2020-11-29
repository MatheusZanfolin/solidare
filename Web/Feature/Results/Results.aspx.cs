using System;
using System.Collections.Generic;
using Solidare.Core.Architecture.Model;

namespace SolidareWeb.Feature.Results
{
    public partial class ResultsPage : System.Web.UI.Page
    {
        private ResultsController controller;

        protected void Page_Load(object sender, EventArgs e)
        {
            controller = new ResultsController(this);

            controller.OnPageLoaded(Session[Data.SearchResults]);
        }

        protected void DrpResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            controller.OnResultSelected(DrpResults.SelectedIndex);
        }

        protected void BtnDonate_Click(object sender, EventArgs e)
        {
            controller.OnDonateButtonClicked();
        }

        internal void ShowResults(List<Organization> organizations)
        {
            DrpResults.Items.Clear();

            foreach (Organization organization in organizations)
            {
                DrpResults.Items.Add(organization.Name);
            }
        }

        internal void ShowDonationScreen(Organization recipient)
        {
            Session[Data.DonationRecipient] = recipient;

            Response.Redirect(AppPage.Donation);
        }
    }
}