namespace Solidare.Core.Architecture.Model
{
    public class Rating
    {
        public DonatedItem Donation { get; private set; }

        public int Grade { get; private set; }

        public Administrator Reviewer { get; private set; }
    }
}