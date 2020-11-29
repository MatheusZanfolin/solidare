using Solidare.Core.Architecture.Model;
using System.Collections.Generic;
using System.Data.SqlClient;
using static Solidare.Core.Database;

namespace Solidare.Feature.Profile.Operations
{
    class OrganizationCausesDetails : Operation
    {
        public string Query => "SELECT * FROM Causas WHERE id IN (SELECT id_causa FROM CausasDefendidas WHERE id_ong = @id)";
    }

    class OrganizationCausesDetailsParameters : Parameters
    {
        public Organization Organization { get; }

        public OrganizationCausesDetailsParameters(Organization organization)
        {
            Organization = organization;
        }

        public Dictionary<string, object> List => new Dictionary<string, object>
        {
            { "@id", Organization.ID  }
        };
    }

    class OrganizationCausesMapper : Mapper<Cause>
    {
        public Cause Map(Dictionary<string, object> reader)
        {
            return new Cause
            (
                (int) reader["id"],
                (string) reader["nome"]
            );
        }
    }
}
