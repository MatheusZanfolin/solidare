using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using Solidare.Core.Architecture.Model;

namespace SolidareWeb.Feature.Donation
{
    public partial class DonationPage : System.Web.UI.Page
    {
        private DonationController controller;

        protected void Page_Load(object sender, EventArgs e)
        {
            controller = new DonationController(this);

            controller.OnPageLoaded(Session[Data.LoggedUser], Session[Data.DonationRecipient]);
        }

        protected void DrpAvailableItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            controller.OnAvailableItemChanged(DrpAvailableItems.SelectedIndex);
        }

        protected void BtnSelect_Click(object sender, EventArgs e)
        {
            controller.OnSelectButtonClicked(DrpAvailableItems.SelectedIndex, TxtQuantity.Text);
        }

        protected void BtnDonate_Click(object sender, EventArgs e)
        {
            controller.OnDonateButtonClicked();
        }

        internal void ShowItems(List<Item> availableItems, List<Item> selectedItems, Dictionary<Item, ItemUnit> measurementUnit, Dictionary<Item, int> donationQuantities)
        {
            ShowItems(DrpAvailableItems, availableItems, (item) => item.Name);
            ShowItems(DrpSelectedItems, selectedItems, (item) => item.Name + " - " + donationQuantities[item] + " " + measurementUnit[item]);
        }

        internal void ShowUnit(ItemUnit unit)
        {
            LblUnit.Text = unit.Name;
        }

        internal void ShowSuccessfulDonation()
        {
            Message.Show(this, "Doação realizada com sucesso!");
        }

        private void ShowItems(DropDownList dropDownList, List<Item> items, Func<Item, string> getDisplayText)
        {
            dropDownList.Items.Clear();

            items.ForEach((item) => dropDownList.Items.Add(getDisplayText(item)));
        }
    }
}