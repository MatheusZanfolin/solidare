using Solidare.Core.Architecture.Model;
using System;
using System.Collections.Generic;
using static Solidare.Core.Database;

namespace SolidareWeb.Feature.Donation.Operations
{
    public class SaveDonation : Operation
    {
        public string Query => "INSERT INTO Doacoes (data, id_doador, id_ong) VALUES (@data, @id_doador, @id_ong)";
    }

    public class SaveDonationParameters : Parameters
    {
        private DateTime Date;
        private Donor Donor;
        private Organization Organization;

        public SaveDonationParameters(DateTime date, Donor donor, Organization organization)
        {
            Date = date;
            Donor = donor;
            Organization = organization;
        }

        public Dictionary<string, object> List => new Dictionary<string, object>
        {
            { "@data", Date },
            { "@id_doador", Donor.ID },
            { "@id_ong", Organization.ID }
        };
    }
}