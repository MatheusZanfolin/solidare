using Solidare.Core.Architecture.Model;
using System.Collections.Generic;
using static Solidare.Core.Database;

namespace Solidare.Feature.Donation.Operations
{
    class UnitDetails : Operation
    {
        public string Query => "SELECT * FROM UnidadesDeMedida WHERE id = @id";
    }

    class UnitDetailsParameters : Parameters
    {
        private Core.Architecture.Model.Item Item { get; }

        public UnitDetailsParameters(Core.Architecture.Model.Item item)
        {
            Item = item;
        }

        public Dictionary<string, object> List => new Dictionary<string, object>
        {
            { "@id", Item.UnitID }
        };
    }

    class UnitDetailsMapper : Mapper<ItemUnit>
    {
        public ItemUnit Map(Dictionary<string, object> reader)
        {
            return new ItemUnit
            (
                (int) reader["id"],
                (string) reader["name"]
            );
        }
    }
}
