using Solidare.Core.Architecture.Model;
using System.Collections.Generic;
using static Solidare.Core.Database;

namespace Solidare.Feature.Donations.Operations
{
    class PendingDonationsDonors : Operation
    {
        public string Query => "SELECT * FROM Doadores WHERE id IN (SELECT id_doador FROM Doacoes WHERE id_ong = @id_ong AND id NOT IN (SELECT id_doacao FROM Confirmacoes))";
    }

    class PendingDonationsDonorsParameters : Parameters
    {
        private Organization Organization { get; }

        public PendingDonationsDonorsParameters(Organization organization)
        {
            Organization = organization;
        }

        public Dictionary<string, object> List => new Dictionary<string, object>
        {
            { "@id_ong", Organization.ID }
        };
    }

    class PendingDonationsDonorsMapper : Mapper<Donor>
    {
        public Donor Map(Dictionary<string, object> reader)
        {
            return new Donor
            (
                (int) reader["id"],
                (string) reader["nome"],
                (string) reader["email"],
                (string) reader["cpf"],
                (string) reader["telefone"],
                (string) reader["celular"],
                (string) reader["username"],
                (int) reader["id_cidade"]
            );
        }
    }
}
