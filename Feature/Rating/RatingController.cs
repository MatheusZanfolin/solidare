using System;
using Solidare.Core;
using Solidare.Core.Architecture;
using Solidare.Core.Architecture.Model;
using Solidare.Feature.Donation.Operations;
using Solidare.Feature.Rating.Operations;

namespace Solidare.Feature.Item
{
    class RatingController : Controller<RatingForm>
    {
        private Administrator user;

        private DonatedItem donation;

        private int grade;

        public RatingController(RatingForm form, Administrator loggedUser, DonatedItem donatedItem) : base(form)
        {
            user = loggedUser;
            donation = donatedItem;
        }

        internal void OnScreenCreated()
        {
            var item = Database.Get(new ItemDetails(), new ItemDetailsMapper(), new ItemDetailsParameters(donation));

            view.ShowItemDetails(item.Name, donation.Quantity.ToString());
        }

        internal void OnGradeChanged(string itemGrade)
        {
            grade = Convert.ToInt32(itemGrade);
        }

        internal void OnConfirmButtonClicked()
        {
            Database.Update(new DonatedItemRating(), new DonatedItemRatingParameters(donation, grade, user));

            view.ShowDonationScreen(donation, grade);
        }
    }
}
