using System;
using System.Collections.Generic;

namespace Solidare.Core.Architecture.Model
{
    public class Donation
    {
        public int ID { get; private set; }

        public DateTime Date { get; private set; }

        public int DonorID { get; private set; }

        public int RecipientID { get; private set; }

        public Donation(int id, DateTime date, int donorID, int recipientID)
        {
            ID = id;
            Date = date;
            DonorID = donorID;
            RecipientID = recipientID;
        }
    }
}
