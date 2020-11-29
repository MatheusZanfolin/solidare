using Solidare.Core.Architecture.Model;
using System.Collections.Generic;
using static Solidare.Core.Database;

namespace Solidare.Feature.Donation.Operations
{
    class DonationItems : Operation
    {
        public string Query => "SELECT * FROM ItensDoados WHERE id_doacao = @id_doacao";
    }

    class DonationItemsParameters : Parameters
    {
        private Core.Architecture.Model.Donation Donation { get; }

        public DonationItemsParameters(Core.Architecture.Model.Donation donation)
        {
            Donation = donation;
        }

        public Dictionary<string, object> List => new Dictionary<string, object>
        {
            { "@id_doacao", Donation.ID }
        };
    }

    class DonationItemsMapper : Mapper<DonatedItem>
    {
        public DonatedItem Map(Dictionary<string, object> reader)
        {
            return new DonatedItem
            (
                (int) reader["id"],
                (int) reader["id_item"],
                (int) reader["quantidade"],
                (int) reader["id_doacao"]                
            );
        }
    }
}
