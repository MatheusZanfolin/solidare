using System;
using System.Collections.Generic;
using Solidare.Core;
using Solidare.Core.Architecture;
using Solidare.Core.Architecture.Model;
using Solidare.Feature.Profile.Operations;

namespace Solidare.Feature.Profile
{
    public class ProfileController : Controller<ProfileForm>
    {
        private bool isEditing = false;

        private Administrator loggedUser;

        private Organization organization;

        private City city;

        private List<Cause> causes = new List<Cause>();

        public ProfileController(ProfileForm form, Administrator loggedUser) : base(form)
        {
            this.loggedUser = loggedUser;
        }

        internal void OnScreenCreated()
        {
            organization = Database.Get(new OrganizationDetails(), new OrganizationDetailsMapper(), new OrganizationDetailsParameters(loggedUser));

            causes = Database.GetAll(new OrganizationCausesDetails(), new OrganizationCausesMapper(), new OrganizationCausesDetailsParameters(organization));

            city = Database.Get(new CityDetails(), new CityDetailsMapper(), new CityDetailsParameters(organization));

            var state = Database.Get(new StateFromCityDetails(), new StatesDetailsMapper(), new StateFromCityDetailsParameters(city));

            var cities = Database.GetAll(new CitiesFromStateDetails(), new CityDetailsMapper(), new CitiesFromStateDetailsParameters(state));

            var states = Database.GetAll(new StatesDetails(), new StatesDetailsMapper());

            view.ShowOrganizationDetails(organization, causes, states, cities, state, city);
        }

        internal void OnCancelButtonClicked()
        {
            view.CloseScreen();
        }

        internal void OnEditButtonClicked(string name, string email, string phone, string address, string cnpj, string websiteLink, string appLink)
        {
            if (isEditing)
            {
                SaveChanges(name, email, phone, address, cnpj,  websiteLink, appLink);
            }
            else
            {
                EnableEditing();
            }

            isEditing = !isEditing;
        }

        internal void OnStateSelected(object id, string name)
        {
            var state = new State((int)id, name);
            
            var cities = Database.GetAll(new CitiesFromStateDetails(), new CityDetailsMapper(), new CitiesFromStateDetailsParameters(state));

            view.ShowCities(cities);
        }

        internal void OnCitySelected(object id, string name, object stateID)
        {
            city = new City((int)id, name, (int)stateID);
        }

        internal void OnCausesFieldClicked()
        {
            view.ShowCausesScreen(causes);
        }

        private void SaveChanges(string name, string email, string phone, string address, string cnpj, string websiteLink, string appLink)
        {
            organization = GetUpdated(name, email, phone, address, cnpj, websiteLink, appLink);

            Database.Update(new OrganizationSaving(), new OrganizationSavingParameters(organization));

            Database.Update(new OrganizationCausesReset(), new OrganizationCausesResetParameters(organization));

            foreach (Cause cause in causes)
            {
                Database.Update(new OrganizationCausesSaving(), new OrganizationCausesSavingParameters(organization, cause)); 
            }

            isEditing = false;

            view.DisableFields();
        }

        private void EnableEditing()
        {
            isEditing = true;

            view.EnableFields();
        }

        private Organization GetUpdated(string name, string email, string phone, string address, string cnpj, string websiteLink, string appLink)
        {
            return new Organization(organization.ID, name, email, phone, address, cnpj, websiteLink, appLink, organization.Logo, city.ID);
        }
    }
}
