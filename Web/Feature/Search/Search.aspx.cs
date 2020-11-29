using Solidare.Core.Architecture.Model;
using System;
using System.Collections.Generic;

namespace SolidareWeb.Feature.Search
{
    public partial class SearchPage : System.Web.UI.Page
    {
        private SearchController controller;

        protected void Page_Load(object sender, EventArgs e)
        {
            controller = new SearchController(this);
        }

        protected void BtnSearch_Click(object sender, EventArgs e)
        {
            controller.OnSearchButtonClicked(TxtSearch.Text);
        }

        internal void ShowCityNotFoundMessage()
        {
            Message.Show(this, "Cidade não encontrada");
        }

        internal void ShowNoOrganizationFoundMessage()
        {
            Message.Show(this, "Não foram encontradas ONGs nessa cidade");
        }

        internal void ShowResultsScreen(List<City> organizations)
        {
            Session[Data.SearchResults] = organizations;

            Response.Redirect(AppPage.Results);
        }
    }
}