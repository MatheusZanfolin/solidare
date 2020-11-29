using Solidare.Core.Architecture.Model;
using System;
using System.Collections.Generic;
using static Solidare.Core.Database;

namespace Solidare.Feature.Donation.Operations
{
    class DonationConfirmation : Operation
    {
        public string Query => "INSERT INTO Confirmacoes (id_doacao, data, id_administrador) VALUES (@id_doacao, @data, @id_administrador)";
    }

    class DonationConfirmationParameters : Parameters
    {
        private Core.Architecture.Model.Donation Donation { get; }
        private DateTime Date { get; }
        private Administrator Administrator { get; }

        public DonationConfirmationParameters(Core.Architecture.Model.Donation donation, DateTime date, Administrator administrator)
        {
            Donation = donation;
            Date = date;
            Administrator = administrator;
        }

        public Dictionary<string, object> List => new Dictionary<string, object>
        {
            { "@id_doacao", Donation.ID },
            { "@data", Date },
            { "@id_administrador", Administrator }
        };
    }
}
