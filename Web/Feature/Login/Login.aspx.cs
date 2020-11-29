using System;
using Solidare.Core.Architecture.Model;

namespace SolidareWeb.Feature.Login
{
    public partial class LoginPage : System.Web.UI.Page
    {
        private LoginController controller;

        protected void Page_Load(object sender, EventArgs e)
        {
            controller = new LoginController(this);
        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            controller.OnLoginButtonClicked(TxtUser.Text, TxtPassword.Text);
        }

        internal void ShowSearchScreen(Donor user)
        {
            Session[Data.LoggedUser] = user;

            Response.Redirect(AppPage.Search);
        }

        internal void ShowErrorMessage()
        {
            Message.Show(this, "Acesso negado: login ou senha inválidos");
        }
    }
}