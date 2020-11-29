using Solidare.Core.Architecture.Model;
using System.Collections.Generic;
using static Solidare.Core.Database;

namespace Solidare.Feature.Profile.Operations
{
    class StatesDetails : Operation
    {
        public string Query => "SELECT * FROM Estados";
    }

    class StatesDetailsMapper : Mapper<State>
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
