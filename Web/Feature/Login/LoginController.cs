using System;
using Solidare.Core.Architecture;
using Solidare.Core;
using SolidareWeb.Feature.Login.Operations;

namespace SolidareWeb.Feature.Login
{
    public class LoginController : Controller<LoginPage>
    {
        public LoginController(LoginPage page) : base(page) { }

        internal void OnLoginButtonClicked(string username, string password)
        {
            var user = Database.Get(new SignIn(), new SignInMapper(), new SignInParameters(username, password));
            
            if (user != null)
            {
                view.ShowSearchScreen(user);
            } 
            else
            {
                view.ShowErrorMessage();
            }
        }
    }
}