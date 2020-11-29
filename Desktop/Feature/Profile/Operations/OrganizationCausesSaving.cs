using Solidare.Core.Architecture.Model;
using System.Collections.Generic;
using static Solidare.Core.Database;

namespace Solidare.Feature.Profile.Operations
{
    class OrganizationCausesSaving : Operation
    {
        public string Query => "INSERT INTO CausasDefendidas (id_causa, id_ong) VALUES (@id_causa, @id_ong)";
    }

    class OrganizationCausesSavingParameters : Parameters
    {
        private Organization Organization;
        private Cause Cause;

        public OrganizationCausesSavingParameters(Organization organization, Cause cause)
        {
            Organization = organization;
            Cause = cause;
        }

        public Dictionary<string, object> List => new Dictionary<string, object>
        {
            { "@id_causa", Cause.ID },
            { "@id_ong", Organization.ID }
        };
    }
}
