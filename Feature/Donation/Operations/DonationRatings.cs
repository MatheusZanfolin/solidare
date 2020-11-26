using System.Collections.Generic;
using static Solidare.Core.Database;

namespace Solidare.Feature.Donation.Operations
{
    class DonationRatings : Operation
    {
        public string Query => "SELECT * FROM Avaliacoes WHERE id_item_doado IN (SELECT id FROM ItensDoados WHERE id_doacao = (SELECT id FROM Doacoes WHERE id = @id))";
    }

    class DonationRatingsParameters : Parameters
    {
        private Core.Architecture.Model.Donation Donation { get; }

        public DonationRatingsParameters(Core.Architecture.Model.Donation donation)
        {
            Donation = donation;
        }
        
        public Dictionary<string, object> List => new Dictionary<string, object>
        {
            { "@id", Donation.ID }
        };
    }

    class DonationRatingsMapper : Mapper<Core.Architecture.Model.Rating>
    {
        public Core.Architecture.Model.Rating Map(Dictionary<string, object> reader)
        {
            return new Core.Architecture.Model.Rating
            (
                (int)reader["id_item_doado"],
                (int)reader["nota"],
                (int)reader["id_administrador"]
            );
        }
    }
}
