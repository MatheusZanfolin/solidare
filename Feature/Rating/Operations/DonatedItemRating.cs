using System.Collections.Generic;
using Solidare.Core.Architecture.Model;
using static Solidare.Core.Database;

namespace Solidare.Feature.Rating.Operations
{
    class DonatedItemRating : Operation
    {
        public string Query => "INSERT INTO Avaliacoes (id_item_doado, nota, id_administrador) VALUES (@id_item_doado, @nota, @id_administrador)";
    }

    class DonatedItemRatingParameters : Parameters
    {
        private DonatedItem DonatedItem { get; }
        private int Rating { get; }
        private Administrator Administrator { get; }

        public DonatedItemRatingParameters(DonatedItem donatedItem, int rating, Administrator administrator)
        {
            DonatedItem = donatedItem;
            Rating = rating;
            Administrator = administrator;
        }

        public Dictionary<string, object> List => new Dictionary<string, object>
        {
            { "@id_item_doado", DonatedItem.ID },
            { "@nota", Rating },
            { "@id_administrador", Administrator.ID },
        };
    }
}