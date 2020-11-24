using Solidare.Core.Architecture.Model;
using System.Collections.Generic;
using static Solidare.Core.Database;

namespace Solidare.Feature.Donation.Operations
{

    class ItemCategoryDetails : Operation
    {
        public string Query => "SELECT * FROM Categorias WHERE id = @id";
    }

    class ItemCategoryDetailsParameters : Parameters
    {
        private Core.Architecture.Model.Item Item { get; }

        public ItemCategoryDetailsParameters(Core.Architecture.Model.Item item)
        {
            Item = item;
        }

        public Dictionary<string, object> List => new Dictionary<string, object>
        {
            { "@id", Item.ID }
        };
    }

    class ItemCategoryMapper : Mapper<ItemCategory>
    {
        public ItemCategory Map(Dictionary<string, object> reader)
        {
            return new ItemCategory
            (
                (int) reader["id"],
                (string) reader["name"]
            );
        }
    }
}
