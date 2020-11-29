using Solidare.Core.Architecture.Model;
using System;
using System.Collections.Generic;
using static Solidare.Core.Database;

namespace SolidareWeb.Feature.Donation.Operations
{
    public class SaveDonatedItem : Operation
    {
        public string Query => "INSERT INTO ItensDoados (quantidade, id_doacao, id_item) VALUES (@quantidade, @id_doacao, @id_item)";
    }

    public class SaveDonatedItemParameters : Parameters
    {
        public int Quantity;
        public Solidare.Core.Architecture.Model.Donation Donation;
        public Item Item;

        public SaveDonatedItemParameters(int quantity, Solidare.Core.Architecture.Model.Donation donation, Item item)
        {
            Quantity = quantity;
            Donation = donation;
            Item = item;
        }

        public Dictionary<string, object> List => new Dictionary<string, object>
        {
            { "@quantidade", Quantity },
            { "@id_doacao", Donation.ID },
            { "@id_item", Item.ID }
        };
    }
}