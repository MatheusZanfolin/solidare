using Solidare.Core.Architecture.Model;
using System;
using System.Collections.Generic;
using static Solidare.Core.Database;

namespace SolidareWeb.Feature.Search.Operations
{
    public class CityOrganizations : Operation
    {
        public string Query => "SELECT * FROM ONGs WHERE id_cidade = @id_cidade";
    }

    public class CityOrganizationsParameters : Parameters
    {
        private City City;

        public CityOrganizationsParameters(City city)
        {
            City = city;
        }

        public Dictionary<string, object> List => new Dictionary<string, object>
        {
            { "@id_cidade", City.ID }
        };
    }

    public class CityOrganizationsMapper : Mapper<City>
    {
        public City Map(Dictionary<string, object> reader)
        {
            return new City
            (
                (int) reader["id"],
                (string) reader["nome"],
                (int) reader["id_cidade"]
            );
        }
    }
}
