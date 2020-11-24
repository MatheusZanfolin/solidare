using Solidare.Core.Architecture.Model;
using System.Collections.Generic;
using static Solidare.Core.Database;

namespace Solidare.Feature.Donation.Operations
{
    class ItemDetails : Operation
    {
        public string Query => "SELECT * FROM Itens WHERE id = @id";
    }

    class ItemDetailsParameters : Parameters
    {
        private DonatedItem DonatedItem { get; }

        public ItemDetailsParameters(DonatedItem donatedItem)
        {
            DonatedItem = donatedItem;
        }

        public Dictionary<string, object> List => new Dictionary<string, object>
        {
            { "@id", DonatedItem.ID }
        };
    }

    class ItemDetailsMapper : Mapper<Core.Architecture.Model.Item>
    {
        public Core.Architecture.Model.Item Map(Dictionary<string, object> reader)
        {
            return new Core.Architecture.Model.Item
            (
                (int) reader["id"],
                (string) reader["nome"],
                (int) reader["id_categoria"],
                (int) reader["id_unidade_de_medida"]
            );
        }
    }
}
