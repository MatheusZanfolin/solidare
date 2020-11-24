using Solidare.Core.Architecture.Model;
using System.Collections.Generic;
using System.Data.SqlClient;
using static Solidare.Core.Database;

namespace Solidare.Feature.Profile.Operations
{
    class OrganizationDetails : Operation
    {
        public string Query => "SELECT * FROM ONGs WHERE id = @id";
    }

    class OrganizationDetailsParameters : Parameters
    {
        private Administrator Administrator { get; }

        public OrganizationDetailsParameters(Administrator administrator)
        {
            Administrator = administrator;
        }

        public Dictionary<string, object> List => new Dictionary<string, object>
        {
            { "@id", Administrator.OrganizationID }
        };
    }

    class OrganizationDetailsMapper : Mapper<Organization>
    {
        public Organization Map(Dictionary<string, object> reader)
        {
            return new Organization
            (
                (int) reader["id"],
                (string) reader["nome"],
                (string) reader["telefone"],
                (string) reader["email"],
                (string) reader["cnpj"],
                (string) reader["endereco"],
                (string) reader["website"],
                (string) reader["app"],
                (string) reader["logotipo"],
                (int) reader["id_cidade"]
            );
        }
    }
}
