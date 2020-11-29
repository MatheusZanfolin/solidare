using System;
using Solidare.Core.Architecture;
using Solidare.Core.Architecture.Model;

namespace Solidare.Feature.Menu
{
    public class MenuController : Controller<MenuForm>
    {
        private Administrator loggedUser;

        public MenuController(MenuForm view, Administrator user) : base(view)
        {
            this.loggedUser = user;
        }

        internal void OnProfileButtonClicked()
        {
            view.ShowProfileEditScreen(loggedUser);
        }

        internal void OnDonationsButtonClicked()
        {
            view.ShowPendingDonationsScreen(loggedUser);
        }

        internal void OnLogoutButtonClicked()
        {
            view.CloseApp();
        }
    }
}