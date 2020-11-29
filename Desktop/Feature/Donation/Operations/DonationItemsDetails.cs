using System.Collections.Generic;
using Solidare.Core.Architecture.Model;
using static Solidare.Core.Database;

namespace Solidare.Feature.Donation.Operations
{
    class DonationItemsDetails : Operation
    {
        public string Query => "SELECT * FROM Itens WHERE id IN (SELECT id FROM ItensDoados WHERE id_doacao = @id_doacao)";
    }

    class DonationItemsDetailsParameters : Parameters
    {
        private Core.Architecture.Model.Donation Donation;

        public DonationItemsDetailsParameters(Core.Architecture.Model.Donation donation)
        {
            Donation = donation;
        }

        public Dictionary<string, object> List => new Dictionary<string, object>
        {
            { "@id_doacao",  Donation.ID }
        };
    }
}
