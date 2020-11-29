using Solidare.Core.Architecture;
using Solidare.Core.Architecture.Model;
using System.Collections.Generic;

namespace SolidareWeb.Feature.Results
{
    public class ResultsController : Controller<ResultsPage>
    {
        private List<Organization> organizations;

        private Organization recipient;

        public ResultsController(ResultsPage toAttach) : base(toAttach) { }

        internal void OnPageLoaded(object searchResults)
        {
            var organizations = (List<Organization>) searchResults;

            view.ShowResults(organizations);
        }

        internal void OnResultSelected(int selectedIndex)
        {
            recipient = organizations[selectedIndex];
        }

        internal void OnDonateButtonClicked()
        {
            view.ShowDonationScreen(recipient);
        }
    }
}