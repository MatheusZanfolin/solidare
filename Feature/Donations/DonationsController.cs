using System.Collections.Generic;
using Solidare.Core;
using Solidare.Core.Architecture;
using Solidare.Core.Architecture.Model;
using Solidare.Feature.Donations.Operations;

namespace Solidare.Feature.Donations
{
    class DonationsController : Controller<DonationsForm>
    {
        private Administrator user;

        private List<Core.Architecture.Model.Donation> donations = new List<Core.Architecture.Model.Donation>();

        private Core.Architecture.Model.Donation donation;

        public DonationsController(DonationsForm form, Administrator loggedUser) : base(form)
        {
            user = loggedUser; 
        }

        internal void OnScreenCreated()
        {
            donations = Database.GetAll(new PendingDonations(), new PendingDonationsMapper(), new PendingDonationsParameters(user));

            view.ShowDonations(donations);
        }

        internal void OnDonationSelected(int selectedIndex)
        {
            donation = donations[selectedIndex];
        }

        internal void OnRateDonationButtonClicked()
        {
            view.ShowRatingScreen(user, donation);
        }

        internal void OnReturnButtonClicked()
        {
            view.CloseScreen();
        }
    }
}
