using Solidare.Core.Architecture.Model;
using Solidare.Feature.Causes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Solidare.Feature.Profile
{
    public partial class ProfileForm : Form
    {
        internal delegate string TextCallback<D>(D data);

        internal delegate object ValueCallback<D>(D data);

        private ProfileController controller;

        public ProfileForm(Administrator loggedUser)
        {
            InitializeComponent();

            controller = new ProfileController(this, loggedUser);

            controller.OnScreenCreated();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            controller.OnCancelButtonClicked();
        }

        private void BtnEditSave_Click(object sender, EventArgs e)
        {
            controller.OnEditButtonClicked
            (
                TxtName.Text,
                TxtEmail.Text,
                TxtPhone.Text,
                TxtAddress.Text,
                TxtCNPJ.Text,
                TxtWebsiteLink.Text,
                TxtAppLink.Text
            );
        }

        private void CmbState_SelectedIndexChanged(object sender, EventArgs e)
        {
            controller.OnStateSelected(CmbState.SelectedValue, CmbState.SelectedText);
        }

        private void CmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            controller.OnCitySelected(CmbState.SelectedValue, CmbState.SelectedText, CmbState.SelectedValue);
        }

        private void TxtCausesList_Click(object sender, EventArgs e)
        {
            controller.OnCausesFieldClicked();
        }

        internal void ShowOrganizationDetails(Organization organization, List<Cause> causes, List<State> states, List<City> cities, State state, City city)
        {
            TxtName.Text = organization.Name;
            TxtPhone.Text = organization.Phone;
            TxtEmail.Text = organization.Email;
            TxtAddress.Text = organization.Address;
            TxtWebsiteLink.Text = organization.Website;
            TxtAppLink.Text = organization.App;

            var selectedState = states.IndexOf(state);
            var selectedCity = cities.IndexOf(city);

            ShowCauses(causes);
            ShowCombo(CmbState, states, (current) => current.Name, (current) => current.ID, selectedState);
            ShowCombo(CmbCity, cities, (current) => current.Name, (current) => current.ID, selectedCity);
        }

        internal void CloseScreen()
        {
            Close();
        }

        internal void ShowCities(List<City> cities)
        {
            ShowCombo(CmbCity, cities, (city) => city.Name, (city) => city.ID, 0);
        }

        internal void ShowCausesScreen(List<Cause> causes)
        {
            ShowDialog(new CausesForm(this, causes));
        }

        public void ShowCauses(List<Cause> causes)
        {
            TxtCausesList.Text = string.Join(", ", causes);
        }

        internal void ShowCombo<D>(ComboBox combo, List<D> items, TextCallback<D> text, ValueCallback<D> value, int selectedIndex)
        {
            combo.Items.Clear();
            
            var data = new List<dynamic>();

            items.ForEach((item) => data.Add(new { Text = text(item), Value = value(item) }));

            combo.DataSource = data;
        }

        internal void DisableFields()
        {
            ToggleFields(false);
        }

        internal void EnableFields()
        {
            ToggleFields(true);
        }

        private void ToggleFields(bool areEnabled)
        {
            TxtName.Enabled =
            TxtEmail.Enabled =
            TxtPhone.Enabled =
            TxtAddress.Enabled =
            TxtCNPJ.Enabled =
            TxtWebsiteLink.Enabled = 
            TxtAppLink.Enabled = 
            TxtCausesList.Enabled = 
            CmbState.Enabled = 
            CmbCity.Enabled = areEnabled;
        }
    }
}
