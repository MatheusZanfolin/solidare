using Solidare.Core.Architecture;
using Solidare.Core;
using SolidareWeb.Feature.Search.Operations;
using System;
using Solidare.Core.Architecture.Model;

namespace SolidareWeb.Feature.Search
{
    public class SearchController : Controller<SearchPage>
    {
        public SearchController(SearchPage toAttach) : base(toAttach) { }

        internal void OnSearchButtonClicked(string cityName)
        {
            var city = Database.Get(new CityDetails(), new CityDetailsMapper(), new CityDetailsParameters(cityName));

            if (city == null)
            {
                view.ShowCityNotFoundMessage();
            }
            else
            {
               ShowResults(city);
            }
        }

        private void ShowResults(City city)
        {
            var organizations = Database.GetAll(new CityOrganizations(), new CityOrganizationsMapper(), new CityOrganizationsParameters(city));

            if (organizations == null || organizations.Count == 0)
            {
                view.ShowNoOrganizationFoundMessage();
            }
            else
            {
                view.ShowResultsScreen(organizations);
            }
        }
    }
}