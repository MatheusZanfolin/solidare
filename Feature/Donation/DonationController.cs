using Solidare.Core;
using Solidare.Core.Architecture;
using Solidare.Core.Architecture.Model;
using Solidare.Feature.Donation.Operations;
using System;
using System.Collections.Generic;

namespace Solidare.Feature.Donation
{
    class DonationController : Controller<DonationForm>
    {
        private Administrator user;

        private Core.Architecture.Model.Donation donation;

        private DonatedItem donatedItem;

        private List<DonatedItem> donatedItems = new List<DonatedItem>();

        private List<Core.Architecture.Model.Rating> ratings = new List<Core.Architecture.Model.Rating>();

        public DonationController(DonationForm form, Administrator loggedUser, Core.Architecture.Model.Donation ratedDonation) : base(form)
        {
            donation = ratedDonation;
            user = loggedUser; 
        }

        internal void OnScreenCreated()
        {
            donatedItems = Database.GetAll(new DonationItems(), new DonationItemsMapper(), new DonationItemsParameters(donation));

            ratings = Database.GetAll(new DonationRatings(), new DonationRatingsMapper(), new DonationRatingsParameters(donation));
            
            view.ShowItems(donatedItems, ratings);
        }

        internal void OnConfirmDonationButtonClicked()
        {
            Database.Update(new DonationConfirmation(), new DonationConfirmationParameters(donation, DateTime.Now, user));

            view.ShowDonationsScreen(donation);
        }

        internal void OnSelectedItemChanged(int selectedIndex)
        {
            donatedItem = donatedItems[selectedIndex];
        }

        internal void OnRateItemButtonClicked()
        {
            view.ShowRatingScreen(user, donatedItem);
        }
    }
}
