using System;
using System.Collections.Generic;
using Solidare.Core.Architecture.Model;
using static Solidare.Core.Database;

namespace SolidareWeb.Feature.Donation.Operations
{
    public class DatedDonationDetails : Operation
    {
        public string Query => "SELECT * FROM Doacoes WHERE data = @data";
    }

    public class DatedDonationParameters : Parameters
    {
        private DateTime Date;

        public DatedDonationParameters(DateTime date)
        {
            Date = date;
        }

        public Dictionary<string, object> List => new Dictionary<string, object>
        {
            { "@data", Date }
        };
    }

    public class DatedDonationMapper : Mapper<Solidare.Core.Architecture.Model.Donation>
    {
        public Solidare.Core.Architecture.Model.Donation Map(Dictionary<string, object> reader)
        {
            return new Solidare.Core.Architecture.Model.Donation
            (
                (int) reader["id"],
                (DateTime) reader["data"],
                (int) reader["id_doador"],
                (int) reader["id_ong"]
            );
        }
    }
}