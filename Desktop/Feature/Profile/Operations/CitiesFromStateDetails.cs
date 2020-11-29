using Solidare.Core.Architecture.Model;
using System.Collections.Generic;
using static Solidare.Core.Database;

namespace Solidare.Feature.Profile.Operations
{
    class CitiesFromStateDetails : Operation
    {
        public string Query => "SELECT * FROM Cidades WHERE id_estado = @id_estado";
    }

    class CitiesFromStateDetailsParameters : Parameters
    {
        private State State { get; }

        public CitiesFromStateDetailsParameters(State state)
        {
            State = state;
        }

        public Dictionary<string, object> List => new Dictionary<string, object>
        {
            { "@id_estado", State.ID }
        };
    }
}
