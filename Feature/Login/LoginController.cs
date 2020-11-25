using Solidare.Core;
using Solidare.Core.Architecture;
using Solidare.Feature.Login.Operations;

namespace Solidare.Feature.Login
{
    public class LoginController : Controller<LoginForm>
    {
        public LoginController(LoginForm view) : base(view) { }

        internal void OnLoginButtonClicked(string login, string password)
        {
            var administrator = Database.Get(new SignIn(), new SignInMapper(), new SignInParameters(login, password));

            if (administrator == null)
            {
                view.ShowErrorMessage();
            }
            else
            {
                view.ShowMenuScreen(administrator);
            }
        }
    }
}
