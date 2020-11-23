using Solidare.Core;
using System.Windows.Forms;

namespace Solidare.Feature.Login
{
    public partial class LoginForm : Form, View<LoginController>
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public LoginController CreateController()
        {
            return new LoginController();
        }
    }
}
