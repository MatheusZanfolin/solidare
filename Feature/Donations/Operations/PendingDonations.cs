using Solidare.Core.Architecture.Model;
using System;
using System.Collections.Generic;
using static Solidare.Core.Database;

namespace Solidare.Feature.Donations.Operations
{
    class PendingDonations : Operation
    {
        public string Query => "SELECT * FROM Doacoes WHERE id_ong = @id_ong AND id NOT IN (SELECT id_doacao FROM Confirmacoes)";
    }

    class PendingDonationsParameters : Parameters
    {
        private Administrator Administrator { get; }

        public PendingDonationsParameters(Administrator administrator)
        {
            Administrator = administrator;
        }

        public Dictionary<string, object> List => new Dictionary<string, object>
        {
            { "@id_ong", Administrator.OrganizationID }
        };
    }

    class PendingDonationsMapper : Mapper<Core.Architecture.Model.Donation>
    {
        public Core.Architecture.Model.Donation Map(Dictionary<string, object> reader)
        {
            return new Core.Architecture.Model.Donation
            (
                (int) reader["id"],
                (DateTime) reader["data"],
                (int) reader["id_doador"],
                (int) reader["id_ong"]
            );
        }
    }
}
