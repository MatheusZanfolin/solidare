namespace Solidare.Core.Architecture.Model
{
    public class Rating
    {

        public int DonatedItemID { get; private set; }

        public int Grade { get; private set; }

        public int ReviewerID { get; private set; }

        public Rating(int donationID, int grade, int reviewerID)
        {
            DonatedItemID = donationID;
            Grade = grade;
            ReviewerID = reviewerID;
        }
    }
}