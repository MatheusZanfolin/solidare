using Solidare.Core.Architecture.Model;
using System.Collections.Generic;
using System.Data.SqlClient;
using static Solidare.Core.Database;

namespace Solidare.Feature.Profile.Operations
{
    class CityDetails : Operation
    {
        public string Query => "SELECT * FROM Cidades WHERE id = @id";
    }

    class CityDetailsParameters : Parameters
    {
        private int ID { get; }

        public CityDetailsParameters(Donor donor) : this(donor.CityID) { }

        public CityDetailsParameters(Organization organization) : this(organization.CityID) { }

        private CityDetailsParameters(int id)
        {
            ID = id;
        }

        public Dictionary<string, object> List => new Dictionary<string, object>
        {
            { "@id", ID }
        };
    }

    class CityDetailsMapper : Mapper<City>
    {
        public City Map(Dictionary<string, object> reader)
        {
            return new City
            (
                (int) reader["id"],
                (string) reader["nome"],
                (int) reader["id_estado"]
            );
        }
    }
}
