using Solidare.Core.Architecture.Model;
using System.Collections.Generic;
using static Solidare.Core.Database;

namespace Solidare.Feature.Profile.Operations
{
    class OrganizationCausesReset : Operation
    {
        public string Query => "DELETE FROM CausasDefendidas WHERE id_ong = @id_ong";
    }

    class OrganizationCausesResetParameters : Parameters
    {
        private Organization Organization { get; }

        public OrganizationCausesResetParameters(Organization organization)
        {
            Organization = organization;
        }

        public Dictionary<string, object> List => new Dictionary<string, object>
        {
            { "@id_ong", Organization.ID }
        };
    }
}
