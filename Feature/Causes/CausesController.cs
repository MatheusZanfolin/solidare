using System;
using System.Collections.Generic;
using Solidare.Core;
using Solidare.Core.Architecture;
using Solidare.Core.Architecture.Model;
using Solidare.Feature.Causes.Operations;
using Solidare.Feature.Profile.Operations;

namespace Solidare.Feature.Causes
{
    class CausesController : Controller<CausesForm>
    {
        private List<Cause> organizationCauses;
        private List<Cause> availableCauses;

        private Cause organizationCause;
        private Cause availableCause;

        public CausesController(CausesForm form, List<Cause> defendedCauses) : base(form)
        {
            organizationCauses = defendedCauses;
        }

        internal void OnScreenCreated()
        {
            availableCauses = Database.GetAll(new CausesDetails(), new OrganizationCausesMapper());

            view.ShowCauses(availableCauses, organizationCauses);
        }

        internal void OnConfirmButtonClicked()
        {
            view.ShowResult(organizationCauses);
        }

        internal void OnCancelButtonClicked()
        {
            view.CloseScreen();
        }

        internal void OnAddButtonClicked()
        {
            availableCauses.Remove(availableCause);
            organizationCauses.Add(availableCause);

            availableCause = null;

            view.ShowCauses(availableCauses, organizationCauses);
        }

        internal void OnRemoveButtonClicked()
        {
            organizationCauses.Remove(organizationCause);
            availableCauses.Add(organizationCause);

            organizationCause = null;

            view.ShowCauses(availableCauses, organizationCauses);
        }

        internal void OnOrganizationCauseSelected(int selectedIndex)
        {
            organizationCause = organizationCauses[selectedIndex];
        }

        internal void OnAvailableCauseSelected(int selectedIndex)
        {
            availableCause = availableCauses[selectedIndex];
        }
    }
}
