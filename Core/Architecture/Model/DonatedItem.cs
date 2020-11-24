namespace Solidare.Core.Architecture.Model
{
    public class DonatedItem
    {
        public int ID { get; private set; }

        public int ItemID { get; private set; }

        public int Quantity { get; private set; }

        public int DonationID { get; private set; }

        public DonatedItem(int id, int itemID, int quantity, int donationID)
        {
            ID = id;
            ItemID = itemID;
            Quantity = quantity;
            DonationID = donationID;
        }
    }
}