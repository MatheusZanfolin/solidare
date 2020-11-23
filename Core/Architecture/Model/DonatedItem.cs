namespace Solidare.Core.Architecture.Model
{
    public class DonatedItem
    {
        public string ID { get; private set; }

        public Item Item { get; private set; }

        public int Quantity { get; private set; }

        public Donation Donation { get; private set; }

        public Rating Rating { get; private set; }

        public DonatedItem(string id, Item item, int quantity, Donation donation, Rating rating)
        {
            ID = id;
            Item = item;
            Quantity = quantity;
            Donation = donation;
            Rating = rating;
        }
    }
}