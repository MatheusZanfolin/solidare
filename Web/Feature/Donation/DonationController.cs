using Solidare.Core;
using Solidare.Core.Architecture;
using Solidare.Core.Architecture.Model;
using Solidare.Feature.Donation.Operations;
using SolidareWeb.Feature.Donation.Operations;
using System.Collections.Generic;
using System;

namespace SolidareWeb.Feature.Donation
{
    public class DonationController : Controller<DonationPage>
    {
        private Donor user;
        private Organization recipient;

        private List<Item> availableItems;
        private Dictionary<Item, ItemUnit> measurementUnit;

        private List<Item> selectedItems;
        private Dictionary<Item, int> donationQuantities;

        public DonationController(DonationPage toAttach) : base(toAttach)
        {
            availableItems = new List<Item>();

            selectedItems = new List<Item>();
            donationQuantities = new Dictionary<Item, int>();
            measurementUnit = new Dictionary<Item, ItemUnit>();
        }

        public void OnPageLoaded(object loggedUser, object donationRecipient)
        {
            user = Get<Donor>(loggedUser);
            recipient = Get<Organization>(donationRecipient);

            availableItems = Database.GetAll(new ItemsDetails(), new ItemsDetailsMapper());

            foreach (Item item in availableItems)
            {
                var unit = Database.Get(new UnitDetails(), new UnitDetailsMapper(), new UnitDetailsParameters(item));

                measurementUnit[item] = unit;
            }

            view.ShowItems(availableItems, selectedItems, measurementUnit, donationQuantities);
        }

        internal void OnAvailableItemChanged(int selectedIndex)
        {
            view.ShowUnit(measurementUnit[availableItems[selectedIndex]]); 
        }

        internal void OnSelectButtonClicked(int selectedIndex, string quantity)
        {
            var donatedItem = availableItems[selectedIndex];
            var donatedQuantity = Get<int>(quantity);

            availableItems.Remove(donatedItem);

            selectedItems.Add(donatedItem);
            donationQuantities[donatedItem] = donatedQuantity;

            view.ShowItems(availableItems, selectedItems, measurementUnit, donationQuantities);
        }

        internal void OnDonateButtonClicked()
        {
            var donationTimestamp = DateTime.Now;

            Database.Update(new SaveDonation(), new SaveDonationParameters(donationTimestamp, user, recipient));

            var donation = Database.Get(new DatedDonationDetails(), new DatedDonationMapper(), new DatedDonationParameters(donationTimestamp));

            foreach (Item item in selectedItems)
            {
                Database.Update(new SaveDonatedItem(), new SaveDonatedItemParameters(donationQuantities[item], donation, item));
            }

            view.ShowSuccessfulDonation();
        }

        private D Get<D>(object data) => (D) data;
    }
}