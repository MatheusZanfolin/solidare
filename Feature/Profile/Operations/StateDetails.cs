using Solidare.Core.Architecture.Model;
using System.Collections.Generic;
using static Solidare.Core.Database;

namespace Solidare.Feature.Profile.Operations
{
    class StateDetails : Operation
    {
        public string Query => "SELECT * FROM Estados WHERE id = @id";
    }

    class StateDetailsParameters : Parameters
    {
        private string ID { get; }

        public StateDetailsParameters(string id)
        {
            ID = id;
        }

        public Dictionary<string, object> List => new Dictionary<string, object>
        {
            { "@id", ID }
        };
    }

    class StateDetailsMapper : Mapper<State>
    {
        public State Map(Dictionary<string, object> reader)
        {
            return new State
            (
                (int) reader["id"],
                (string) reader["nome"]
            );
        }
    }
}
