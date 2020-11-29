using Solidare.Core.Architecture.Model;
using System;
using System.Collections.Generic;
using static Solidare.Core.Database;

namespace SolidareWeb.Feature.Donation.Operations
{
    public class ItemsDetails : Operation
    {
        public string Query => "SELECT * FROM Itens";
    }

    public class ItemsDetailsMapper : Mapper<Item>
    {
        public Item Map(Dictionary<string, object> reader)
        {
            return new Item
            (
                (int) reader["id"],
                (string) reader["nome"],
                (int) reader["id_categoria"],
                (int) reader["id_unidade_de_medida"]
            );
        }
    }
}