using Solidare.Core.Architecture.Model;
using System.Collections.Generic;
using static Solidare.Core.Database;

namespace SolidareWeb.Feature.Search.Operations
{
    class CityDetails : Operation
    {
        public string Query => "SELECT * FROM Cidades WHERE nome = @nome";
    }

    class CityDetailsParameters : Parameters
    {
        private string CityName { get; }

        public CityDetailsParameters(string cityName)
        {
            CityName = cityName;
        }

        public Dictionary<string, object> List => new Dictionary<string, object>
        {
            { "@nome", CityName }
        };
    }

    class CityDetailsMapper : Mapper<City>
    {
        public City Map(Dictionary<string, object> reader)
        {
            return new City
            (
                (int)reader["id"],
                (string)reader["nome"],
                (int)reader["id_estado"]
            );
        }
    }
}
