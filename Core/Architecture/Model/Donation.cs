using System;
using System.Collections.Generic;

namespace Solidare.Core.Architecture.Model
{
    public class Donation
    {
        public string ID { get; private set; }

        public DateTime Date { get; private set; }

        public Donor Donor { get; private set; }

        public Organization Recipient { get; private set; }

        public List<DonatedItem> Donations { get; private set; }
        
        public Confirmation Confirmation { get; private set; }

        public Donation(string id, DateTime date, Donor donor, Organization recipient, List<DonatedItem> donations, Confirmation confirmation)
        {
            ID = id;
            Date = date;
            Donor = donor;
            Recipient = recipient;
            Donations = donations;
            Confirmation = confirmation;
        }
    }
}
