using Solidare.Core.Architecture.Model;
using System.Collections.Generic;
using static Solidare.Core.Database;

namespace Solidare.Feature.Profile.Operations
{
    class OrganizationSaving : Operation
    {
        public string Query => "UPDATE ONGs SET nome = @nome, telefone = @telefone, email = @email, endereco = @endereco, cnpj = @cnpj, website = @website, app = @app, id_cidade = @id_cidade WHERE id = @id";
    }

    class OrganizationSavingParameters : Parameters
    {
        private Organization Organization { get; }

        public OrganizationSavingParameters(Organization organization)
        {
            Organization = organization;
        }

        public Dictionary<string, object> List => new Dictionary<string, object>
        {
            { "@id", Organization.ID },
            { "@nome", Organization.Name },
            { "@telefone", Organization.Phone },
            { "@email", Organization.Email },
            { "@endereco", Organization.Address },
            { "@cnpj", Organization.CNPJ },
            { "@website", Organization.Website },
            { "@app", Organization.App },
            { "@id_cidade", Organization.CityID }
        };
    }
}
