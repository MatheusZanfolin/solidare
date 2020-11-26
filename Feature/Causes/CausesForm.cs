using Solidare.Core.Architecture.Model;
using Solidare.Feature.Profile;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Solidare.Feature.Causes
{
    public partial class CausesForm : Form
    {
        private CausesController controller;

        private ProfileForm parent;

        public CausesForm(ProfileForm profile, List<Cause> organizationCauses)
        {
            InitializeComponent();

            parent = profile;
            controller = new CausesController(this, organizationCauses);

            controller.OnScreenCreated();
        }

        private void BtnConfirm_Click(object sender, System.EventArgs e)
        {
            controller.OnConfirmButtonClicked();
        }

        private void BtnCancel_Click(object sender, System.EventArgs e)
        {
            controller.OnCancelButtonClicked();
        }

        private void BtnAddCause_Click(object sender, System.EventArgs e)
        {
            controller.OnAddButtonClicked();
        }

        private void BtnRemoveCause_Click(object sender, System.EventArgs e)
        {
            controller.OnRemoveButtonClicked();
        }

        private void LstAvailableCauses_SelectedIndexChanged(object sender, EventArgs e)
        {
            controller.OnAvailableCauseSelected(LstAvailableCauses.SelectedIndex);
        }

        private void LstOrganizationCauses_SelectedIndexChanged(object sender, EventArgs e)
        {
            controller.OnOrganizationCauseSelected(LstOrganizationCauses.SelectedIndex);
        }

        internal void ShowCauses(List<Cause> availableCauses, List<Cause> organizationCauses)
        {
            ShowList(LstAvailableCauses, availableCauses);
            ShowList(LstOrganizationCauses, organizationCauses);
        }

        internal void ShowResult(List<Cause> organizationCauses)
        {
            parent.ShowCauses(organizationCauses);

            Close();
        }

        internal void CloseScreen()
        {
            Close();
        }

        private void ShowList(ListBox list, List<Cause> causes)
        {
            list.Items.Clear();

            foreach (Cause cause in causes)
            {
                list.Items.Add(cause.Name);
            }
        }
    }
}
