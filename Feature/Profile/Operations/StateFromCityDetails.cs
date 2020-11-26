using Solidare.Core.Architecture.Model;
using System.Collections.Generic;
using static Solidare.Core.Database;

namespace Solidare.Feature.Profile.Operations
{
    class StateFromCityDetails : Operation
    {
        public string Query => "SELECT * FROM Estados WHERE id = (SELECT id_estado FROM Cidades WHERE id = @id)";
    }

    class StateFromCityDetailsParameters : Parameters
    {
        private City City { get; }

        public StateFromCityDetailsParameters(City city)
        {
            City = city;
        }

        public Dictionary<string, object> List => new Dictionary<string, object>
        {
            { "@id", City.ID }
        };
    }
}
